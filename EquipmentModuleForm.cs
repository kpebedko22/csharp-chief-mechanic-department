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

		private Form Owner;

		public EquipmentModuleForm(Form owner) {
			InitializeComponent();

			Owner = owner;

			dataGridView_DataSearch.Columns[1].DataPropertyName = "PK_Aсt_Debit";
			dataGridView_DataSearch.Columns[2].DataPropertyName = "act_number";
			dataGridView_DataSearch.Columns[3].DataPropertyName = "date";
			SetIndexNums();

			dateTimePicker_DateDebit.Checked = false;
		}

		private void EquipmentModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
			Owner.Visible = true;
		}

		private void ToolStripMenuItem_Add_EquipmentDebit_Click(object sender, EventArgs e) {
			this.Visible = false;
			new AddEquipmentDebitForm(this).Show();
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

				//Console.WriteLine(e.RowIndex);

				//Console.WriteLine(dataGridView_DataSearch.Rows[e.RowIndex].Cells[1].Value);

				// берем первичный ключ акта в скрытом столбце (столбец 1)
				int PK_ActDebit = Convert.ToInt32(dataGridView_DataSearch[1, e.RowIndex].Value);
				//Console.WriteLine(PK_ActDebit);
				ActDebit actDebit = Program.db.ActDebits.Find(PK_ActDebit);

				if (actDebit != null)
					new DebitViewForm(actDebit).ShowDialog();
			}
		}


		private void updateTable() {
			dataGridView_DataSearch.DataSource = Program.db.ActDebits.ToList();
			SetIndexNums();
		}

		private void EquipmentModuleForm_Load(object sender, EventArgs e) {
			dataGridView_DataSearch.AutoGenerateColumns = false;
			dataGridView_DataSearch.ReadOnly = true;
		}

		private void EquipmentModuleForm_Activated(object sender, EventArgs e) {
			button_Search.PerformClick();
			dataGridView_DataSearch.ClearSelection();
		}

		private void button_Search_Click(object sender, EventArgs e) {
			List<ActDebit> actDebits = Program.db.ActDebits.ToList();

			List<ActDebit> actDebitsResult = new List<ActDebit>();

			// вопрос с датой - как она тут хранится
			foreach (var item in actDebits) {
				if (!item.act_number.ToLower().Contains(textBox_ActNumber.Text.ToLower()))
					continue;

				Console.WriteLine(item.date.Date);
				Console.WriteLine(dateTimePicker_DateDebit.Value.Date);

				if (dateTimePicker_DateDebit.Checked)
					if (item.date.Date != dateTimePicker_DateDebit.Value.Date)
						continue;

				actDebitsResult.Add(item);
			}

			dataGridView_DataSearch.DataSource = actDebitsResult;
			SetIndexNums();
			dataGridView_DataSearch.ClearSelection();
			textBox_ActNumber.Focus();
		}

		private void button_ResetSearch_Click(object sender, EventArgs e) {
			textBox_ActNumber.Text = "";
			dateTimePicker_DateDebit.Value = DateTime.Now;

			updateTable();
			dataGridView_DataSearch.ClearSelection();
			textBox_ActNumber.Focus();
		}

		private void SetIndexNums() {
			foreach(DataGridViewRow row in dataGridView_DataSearch.Rows) {
				row.Cells[0].Value = row.Cells[0].RowIndex + 1;

				row.Cells[4].Value = "Просмотреть";
			}
		}
	}
}
