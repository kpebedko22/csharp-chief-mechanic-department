using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OGM.Models;

namespace OGM {
	public partial class EquipmentModuleForm : Form {

		private bool showOwner = true;
		private new Form Owner;

		public EquipmentModuleForm(Form owner) {
			InitializeComponent();

			Owner = owner;
			if (((LogInForm)owner).is_fullscreen()) this.WindowState = FormWindowState.Maximized;

			dataGridView_DataSearch.AutoGenerateColumns = false;
			dataGridView_DataSearch.ReadOnly = true;

			dataGridView_DataSearch.Columns[1].DataPropertyName = "PK_Aсt_Debit";
			dataGridView_DataSearch.Columns[2].DataPropertyName = "act_number";
			dataGridView_DataSearch.Columns[3].DataPropertyName = "date";
			
			dateTimePicker_DateDebit_From.Checked = false;

			UpdateTable();
			//SetIndexNums();
		}

		private void EquipmentModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (showOwner)
				Owner.Visible = true;
		}

		private void ToolStripMenuItem_Add_EquipmentDebit_Click(object sender, EventArgs e) {
			showOwner = false;

			AddEquipmentDebitForm form = new AddEquipmentDebitForm(Owner);
			this.Close();
			form.Visible = true;
		}

		private void ToolStripMenuItem_Equipment_Handbook_Click(object sender, EventArgs e) {
			new EquipmentForm().ShowDialog();
		}

		private void ToolStripMenuItem_GroupEquipment_Handbook_Click(object sender, EventArgs e) {
			new GroupEquipmentForm().ShowDialog();
		}

		private void ToolStripMenuItem_Workshop_Handbook_Click(object sender, EventArgs e) {
			new WorkshopForm().ShowDialog();
		}

		private void ToolStripMenuItem_Organization_Handbook_Click(object sender, EventArgs e) {
			new OrganizationForm().ShowDialog();
		}

		private void ToolStripMenuItem_ReasonDebit_Handbook_Click(object sender, EventArgs e) {
			new ReasonDebitForm().ShowDialog();
		}

		private void dataGridView_DataSearch_CellClick(object sender, DataGridViewCellEventArgs e) {

			if (e.RowIndex == -1) return;

			// если нажали на ссылку в 4 столбце
			if (e.ColumnIndex == 4) {
				// берем первичный ключ акта в скрытом столбце (столбец 1)
				int PK_ActDebit = Convert.ToInt32(dataGridView_DataSearch[1, e.RowIndex].Value);
				ActDebit actDebit = Program.db.ActDebits.Find(PK_ActDebit);
				if (actDebit != null) new DebitViewForm(actDebit).ShowDialog();
			}
		}


		private void UpdateTable() {
			using (OGMContext db = new OGMContext()) 
				dataGridView_DataSearch.DataSource = db.ActDebits.ToList();
		}

		private void button_Search_Click(object sender, EventArgs e) {

			using (OGMContext db = new OGMContext()) {
				List<ActDebit> actDebits = db.ActDebits.ToList();
				List<ActDebit> actDebitsResult = new List<ActDebit>();

				foreach (var item in actDebits) {
					if (!item.act_number.ToLower().Contains(textBox_ActNumber.Text.ToLower()))
						continue;

					if (dateTimePicker_DateDebit_From.Checked)
						if (item.date.Date < dateTimePicker_DateDebit_From.Value.Date)
							continue;

					if (dateTimePicker_DateDebit_To.Checked)
						if (item.date.Date > dateTimePicker_DateDebit_To.Value.Date)
							continue;

					actDebitsResult.Add(item);
				}

				dataGridView_DataSearch.DataSource = actDebitsResult;
				dataGridView_DataSearch.ClearSelection();
				textBox_ActNumber.Focus();
			}
		}

		private void button_ResetSearch_Click(object sender, EventArgs e) {
			textBox_ActNumber.Text = "";
			
			dateTimePicker_DateDebit_From.Value = DateTime.Now;
			dateTimePicker_DateDebit_To.Value = DateTime.Now;
			dateTimePicker_DateDebit_From.Checked = false;
			dateTimePicker_DateDebit_To.Checked = false;

			UpdateTable();
			dataGridView_DataSearch.ClearSelection();
			textBox_ActNumber.Focus();
		}

		private void ToolStripMenuItem_File_ExitModule_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void ToolStripMenuItem_File_ExitProg_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void dataGridView_DataSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {

			if (e.RowIndex == -1) return;

			((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
			((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value = "Просмотреть";
		}
	}
}
