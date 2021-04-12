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

using OGM.Additions;
using OGM.Models;

namespace OGM {
	public partial class LeasingViewForm : Form
	{

		private Organization lessee = null;
		private Organization leaser = null;
		private Organization seller = null;
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

			dataGridView1.ClearSelection();
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
			this.textBox_DateEnd.Text = DateToString.Translate(this.contract.date, "г.");

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
			this.textBox_DateDelivery.Text = DateToString.Translate(this.contract.date, "г.");
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
	}
}
