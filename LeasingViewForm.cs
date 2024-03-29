﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OGM.Additions;
using OGM.Models;

namespace OGM {
	public partial class LeasingViewForm : Form
	{

		private Organization lessee = null;
		private Organization leaser = null;
		private Organization seller = null;
		private LeasingContract contract = null;

		private decimal LeasingContractTotalCost = 0;

		OfficeExport.ExportData exportData;
		OfficeExport officeExport;

		public LeasingViewForm(LeasingContract leasingContract = null)
		{
			InitializeComponent();

			this.DoubleBuffered = true;
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

			// удаляю стрелочки для numeric
			numericUpDown_DaysForFirstPayment.Controls.RemoveAt(0);
			numericUpDown_DaysForForceMajeure.Controls.RemoveAt(0);
			numericUpDown_DaysForReport.Controls.RemoveAt(0);
			numericUpDown_MaxPenalty.Controls.RemoveAt(0);
			numericUpDown_Penalty.Controls.RemoveAt(0);
			numericUpDown_PenaltyFee.Controls.RemoveAt(0);
			numericUpDown_PeriodOfUse.Controls.RemoveAt(0);

			// устанавливаю цвет для readonly полей
			this.textBox_AddressDelivery.BackColor = this.textBox_LeasingNum.BackColor = Color.White;
			this.textBox_AddressDelivery.ForeColor = this.textBox_LeasingNum.ForeColor = Color.Black;

			this.textBox_Date.BackColor = this.textBox_DateEnd.BackColor = this.textBox_DateDelivery.BackColor = Color.White;
			this.textBox_Date.ForeColor = this.textBox_DateEnd.ForeColor = this.textBox_DateDelivery.ForeColor = Color.Black;

			numericUpDown_DaysForFirstPayment.BackColor = Color.White;
			numericUpDown_DaysForForceMajeure.BackColor = Color.White;
			numericUpDown_DaysForReport.BackColor = Color.White;
			numericUpDown_MaxPenalty.BackColor = Color.White;
			numericUpDown_Penalty.BackColor = Color.White;
			numericUpDown_PenaltyFee.BackColor = Color.White;
			numericUpDown_PeriodOfUse.BackColor = Color.White;
			textBox_Leaser.BackColor = Color.White;
			textBox_Lessee.BackColor = Color.White;
			textBox_Seller.BackColor = Color.White;

			numericUpDown_DaysForFirstPayment.ForeColor = Color.Black;
			numericUpDown_DaysForForceMajeure.ForeColor = Color.Black;
			numericUpDown_DaysForReport.ForeColor = Color.Black;
			numericUpDown_MaxPenalty.ForeColor = Color.Black;
			numericUpDown_Penalty.ForeColor = Color.Black;
			numericUpDown_PenaltyFee.ForeColor = Color.Black;
			numericUpDown_PeriodOfUse.ForeColor = Color.Black;
			textBox_Leaser.ForeColor = Color.Black;
			textBox_Lessee.ForeColor = Color.Black;
			textBox_Seller.ForeColor = Color.Black;


			// сохраняю ссылку на договор
			contract = leasingContract;
		}

		private void GenerateTable()
		{
			// получаем из бд строки спецификации

			List<RowAttachmentSpecification> rows = new List<RowAttachmentSpecification>();

			using (OGMContext db = new OGMContext())
				rows = db.RowsAttachmentSpecification.Where(row => row.PK_Leasing_Contract == contract.PK_Leasing_Contract).ToList();

			if (rows.Count == 0)
				return;

			// заполняем таблицу
			foreach (RowAttachmentSpecification row in rows) {
				dataGridView_Data.Rows.Add(row.EquipmentGroup.name, row.cost, row.amount, "шт.", row.amount * row.cost);

				LeasingContractTotalCost += row.amount * row.cost;
			}

			dataGridView_Data.ClearSelection();
		}

		private void LeasingViewForm_Load(object sender, EventArgs e)
		{
			// заполнение инфы о договоре
			if (contract == null) return;

			///// то, что хранится непосредственно в таблице договора /////

			// номер и дата
			this.label_LeasingContractNumber.Text += " " + contract.contract_number;
			this.textBox_LeasingNum.Text = contract.contract_number;
			this.textBox_Date.Text = DateToString.Translate(this.contract.date, "г.");
			this.textBox_DateEnd.Text = DateToString.Translate(this.contract.date_end, "г.");

			// сроки
			this.numericUpDown_DaysForFirstPayment.Value = contract.days_for_first_payment;
			this.numericUpDown_DaysForReport.Value = contract.days_for_report;
			this.numericUpDown_DaysForForceMajeure.Value = contract.days_for_force_majeure;

			// ответственность
			this.numericUpDown_Penalty.Value = contract.penalty;
			this.numericUpDown_MaxPenalty.Value = contract.max_penalty;
			this.numericUpDown_PenaltyFee.Value = contract.penalty_fee;

			// об оборудовании
			this.numericUpDown_PeriodOfUse.Text = contract.period_of_use;
			this.textBox_DateDelivery.Text = DateToString.Translate(this.contract.date_delivery, "г.");
			this.textBox_AddressDelivery.Text = contract.address_delivery;

			//// организации подгружаем через поиск связей ////
			///
			RelationshipOrganizationLeasingContract r_lessee = null;
			RelationshipOrganizationLeasingContract r_seller = null;
			RelationshipOrganizationLeasingContract r_leaser = null;

			using (OGMContext db = new OGMContext())
			{
				r_lessee = db.relationships_organization_leasing_contract.Where(r => r.PK_Leasing_Contract == contract.PK_Leasing_Contract && r.PK_Role == 1).FirstOrDefault();
				r_seller = db.relationships_organization_leasing_contract.Where(r => r.PK_Leasing_Contract == contract.PK_Leasing_Contract && r.PK_Role == 3).FirstOrDefault();
				r_leaser = db.relationships_organization_leasing_contract.Where(r => r.PK_Leasing_Contract == contract.PK_Leasing_Contract && r.PK_Role == 2).FirstOrDefault();
			}

			if (r_lessee != null)
			{
				this.lessee = r_lessee.Organization;
				this.textBox_Lessee.Text = lessee.name;
			}
			if (r_seller != null)
			{
				this.seller = r_seller.Organization;
				this.textBox_Seller.Text = seller.name;
			}
			if (r_leaser != null)
			{
				this.leaser = r_leaser.Organization;
				this.textBox_Leaser.Text = leaser.name;
			}

			GenerateTable();
		}

		private void button_Export_Click(object sender, EventArgs e) {
			if (contract == null) {
				MessageBox.Show("Что-то пошло не так и акта списания нет...");
				return;
			}

			//if (debitEquipments.Count < 1) {
			//	MessageBox.Show("Нет строк в акте списания. Отказ в экспорте...");
			//	return;
			//}

			SaveFileDialog saveFileDialog = new SaveFileDialog {
				Filter = "Документ Word (*.docx)|*.docx",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				button_Export.Enabled = false;

				ExportDoc(saveFileDialog.FileName);

				officeExport = new OfficeExport(exportData);
				officeExport.ReplaceText();
				BGWorker.RunWorkerAsync();
			}
		}

		private void ExportDoc(string nameFileExport) {

			exportData = new OfficeExport.ExportData();

			exportData.nameFileTemplate = Application.StartupPath + "\\..\\..\\resources\\docs\\leasing_contract_template.docx";
			exportData.nameFileExport = nameFileExport;         // Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_number" + ActDebit.act_number + ".docx";
			exportData.tableIndex = 3;                          // номер таблицы в доке
			exportData.textToReplace = new List<string>() {
				"[<номер_лизинга>]",						// 123
				"[<шапка_город>]",							// г. Барнаул
				"[<шапка_дата>]",							// «1» апрель 2021 г.
				"[<организация_лизингодатель>]",			// ООО "Хомячки"
				"[<представитель_лизингодатель>]", 			// Хомяков Х.Х.
				"[<организация_мы>]", 						// ООО "Хомячки2"
				"[<представитель_мы>]", 					// Хомяков Х.Х.2

				"[<1.3_стоимость_оборудования>]",			// хз - пропись или цифры
				"[<1.4_дата_поставки_оборудования>]", 		// «1» апрель 2021

				"[<2.2_срок_пользования_оборудованием>]", 	// 5 лет, 11 месяцев
				"[<2.3_дата_окончания_договора>]",			// «1» апреля 2021 года

				"[<3.1.1_дата_договора>]",					// «1» апрель 2021
				"[<3.2.1_пункт_поставки>]",					// ну какой-то адрес

				"[<4.1_лизингодатель_расчетный_счет>]",
				"[<4.1_лизингодатель_банк>]",
				"[<4.1_лизингодатель_бик>]",

				"[<4.4_дней_для_первого_платежа>]",			// 10

				"[<5.1_пункт_поставки>]",					// дублирование п1.4
				"[<5.4_срок_отказа>]",						// 3

				"[<6.1_пеня>]",								// 0,5
				"[<6.1_макс_платеж>]",						// 5
				"[<6.2_неустойка>]",						// хз - пропись или цифры

				"[<7.1_дней_форс_мажора>]",

				"[<9.3_лизингодатель_юр_адрес_и_телефон>]",
				"[<9.3_мы_юр_адрес_и_телефон>]",


				"[<лизингодатель_юр_адрес>]",
				"[<лизингодатель_почт_адрес>]",
				"[<лизингодатель_телефон>]",
				"[<лизингодатель_инн>]",
				"[<лизингодатель_расчет_счет>]",
				"[<лизингодатель_банк>]",
				"[<лизингодатель_корресп_счет>]",
				"[<лизингодатель_бик>]",

				"[<мы_юр_адрес>]",
				"[<мы_почт_адрес>]",
				"[<мы_телефон>]",
				"[<мы_инн>]",
				"[<мы_расчет_счет>]",
				"[<мы_банк>]",
				"[<мы_корресп_счет>]",
				"[<мы_бик>]",

				"[<приложение_номер_договора>]",
				"[<приложение_дата_договора>]",				//«1» апрель 2021 года

				"[<приложение_лизингодатель>]",
				"[<приложение_лизингополучат>]"
			};

			string rubles = new MoneyToStr("RUR", "RUS", "NUMBER").convertValue(Convert.ToDouble(LeasingContractTotalCost));

			// тут какие-то текстбоксы видимо с формы
			exportData.textReplaceWith = new List<string>() {
				contract.contract_number,
				"г. " + textBox_City.Text,
				DateToString.Translate(contract.date, "г."),
				leaser.name,
				textBox_FIO_Leaser.Text,
				lessee.name,
				textBox_FIO_Lessee.Text,

				rubles,
				DateToString.Translate(contract.date_delivery),

				ConvertYearsMonths.Translate(contract.period_of_use),
				DateToString.Translate(contract.date_end, "года"),

				DateToString.Translate(contract.date),
				contract.address_delivery,

				leaser.payment_account,
				leaser.bank,
				leaser.BIK,

				contract.days_for_first_payment.ToString(),

				contract.address_delivery,
				contract.days_for_report.ToString(),

				contract.penalty.ToString(),
				contract.max_penalty.ToString(),
				contract.penalty_fee.ToString(),

				contract.days_for_force_majeure.ToString(),

				leaser.legal_address + " " + leaser.phone,
				lessee.legal_address + " " + lessee.phone,

				leaser.legal_address,
				leaser.mailing_address,
				leaser.phone,
				leaser.INN,
				leaser.payment_account,
				leaser.bank,
				leaser.correspondent_account,
				leaser.BIK,

				lessee.legal_address,
				lessee.mailing_address,
				lessee.phone,
				lessee.INN,
				lessee.payment_account,
				lessee.bank,
				lessee.correspondent_account,
				lessee.BIK,

				contract.contract_number,
				DateToString.Translate(contract.date, "года"),

				leaser.name + " " + textBox_FIO_Leaser.Text,
				lessee.name + " " + textBox_FIO_Lessee.Text
			};

			// если надо открыть файл после экспорта автоматически
			exportData.openFileExport = checkBox_OpenFileExport.Checked;

			// и самый интересный момент - таблица
			// количество строк с учетом что одна строка по умолчанию есть внутри шаблона
			// какой столбик из datagridview в какой столбик в доке
			// и еще есть столбцы по умолчанию
			exportData.indicesDefaultValues = new List<int>() {
				5	// наименование ед. измерения
			};
			exportData.valuesDefaultValues = new List<string>() {
				"шт."	// наименование ед. измерения
			};

			exportData.indicesCustomValues = new List<int>() {
				2,	// наименование оборудования
				3,	// стоимость за ед.
				4,	// кол-во
				6	// стоимость
			};

			exportData.valuesCustomValues = new List<List<string>>();

			foreach (DataGridViewRow row in dataGridView_Data.Rows) {
				string name = row.Cells[0].Value.ToString();
				string cost_per_one = row.Cells[1].Value.ToString();
				string amount = row.Cells[2].Value.ToString();
				string cost_per_all = row.Cells[4].Value.ToString();

				exportData.valuesCustomValues.Add(
					new List<string>() {
						name,
						cost_per_one,
						amount,
						cost_per_all
				});
			}
		}

        private void numericUpDown_DaysForFirstPayment_Paint(object sender, PaintEventArgs e) {
			e.Graphics.Clear(SystemColors.Window);
			base.OnPaint(e);
		}

		/* Для ресайза окна, чтоб не лагало */
		private void LeasingViewForm_ResizeBegin(object sender, EventArgs e) {
			SuspendLayout();
		}
		private void LeasingViewForm_ResizeEnd(object sender, EventArgs e) {
			ResumeLayout();
		}
		/* END Для ресайза окна, чтоб не лагало */


		/* Ассинхронный экспорт через BGWorker */
		private void BGWorker_DoWork(object sender, DoWorkEventArgs e) {
			while (officeExport.HasNextRow) {
				int percentage = officeExport.CurrentRow * 100 / officeExport.NumberRows;
				officeExport.AddRowToTable();
				BGWorker.ReportProgress(percentage);
			}
		}
		private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
			progressBar.Value = e.ProgressPercentage;
		}
		private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			button_Export.Enabled = true;
			officeExport.Close();
		}
		/* END Ассинхронный экспорт через BGWorker */

		/* Меню */
		private void ToolStripMenuItem_Export_File_Click(object sender, EventArgs e){
			tabControl.SelectedTab = tabControl.TabPages[2];
		}
		private void ToolStripMenuItem_Exit_File_Click(object sender, EventArgs e) {
			this.Close();
		}
		/* END Меню */
	}
}
