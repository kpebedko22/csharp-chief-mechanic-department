using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using OGM.Models;

namespace OGM {
	public partial class LeasingViewForm : Form
	{

		private LeasingContract contract = null;

		public LeasingViewForm(LeasingContract leasingContract = null)
		{
			InitializeComponent();

			// удаляю стрелочки для numeric
			numericUpDown_DaysForFirstPayment.Controls.RemoveAt(0);
			numericUpDown_DaysForForceMajeure.Controls.RemoveAt(0);
			numericUpDown_DaysForReport.Controls.RemoveAt(0);
			numericUpDown_MaxPenalty.Controls.RemoveAt(0);
			numericUpDown_Penalty.Controls.RemoveAt(0);
			numericUpDown_PenaltyFee.Controls.RemoveAt(0);
			numericUpDown_PeriodOfUse.Controls.RemoveAt(0);

			// сохраняю ссылку на договор
			contract = leasingContract;
		}



		private void ToolStripMenuItem_Export_File_Click(object sender, EventArgs e)
		{
			new ExportLeasingForm().ShowDialog();
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
			foreach (RowAttachmentSpecification row in rows)
				dataGridView1.Rows.Add(row.EquipmentGroup.name, row.cost, row.amount, "шт.", row.amount * row.cost);


		}



		private void LeasingViewForm_Load(object sender, EventArgs e)
		{
			// заполнение инфы о договоре
			if (contract == null) return;

			///// то, что хранится непосредственно в таблице договора /////

			// номер и дата
			this.label_LeasingContractNumber.Text += " " + contract.contract_number;
			this.textBox_LeasingNum.Text = contract.contract_number;
			this.dateTimePicker_DateConclusion.Value = contract.date;

			// сроки
			this.numericUpDown_DaysForFirstPayment.Value = contract.days_for_first_payment;
			this.numericUpDown_DaysForReport.Value = contract.days_for_report;
			this.numericUpDown_DaysForForceMajeure.Value = contract.days_for_force_majeure;

			// ответственность
			this.numericUpDown_Penalty.Value = contract.penalty;
			this.numericUpDown_MaxPenalty.Value = contract.max_penalty;
			this.numericUpDown_PenaltyFee.Value = contract.penalty_fee;

			// об оборудовании
			this.numericUpDown_PeriodOfUse.Value = contract.period_of_use;
			this.dateTimePicker_DateDelivery.Value = contract.date_delivery;
			this.textBox_AddressDelivery.Text = contract.address_delivery;



			//// организации подгружаем через поиск связей ////
			///
			RelationshipOrganizationLeasingContract r_seller = null;
			RelationshipOrganizationLeasingContract r_leaser = null;

			using (OGMContext db = new OGMContext())
			{
				r_seller = db.relationships_organization_leasing_contract.Where(r => r.PK_Leasing_Contract == contract.PK_Leasing_Contract && r.PK_Role == 3).FirstOrDefault();
				r_leaser = db.relationships_organization_leasing_contract.Where(r => r.PK_Leasing_Contract == contract.PK_Leasing_Contract && r.PK_Role == 2).FirstOrDefault();
			}

			if (r_seller != null) this.comboBox_Seller.Text = r_seller.Organization.name;
			if (r_leaser != null) this.comboBox_Leaser.Text = r_leaser.Organization.name;

			GenerateTable();


		}
	}
}
