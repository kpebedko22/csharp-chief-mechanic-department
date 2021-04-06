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
	public partial class AddEquipmentDebitForm : Form {

		private Form Owner;

		public AddEquipmentDebitForm(Form owner) {
			InitializeComponent();

			Owner = owner;

			dataGridView_Debit.AutoGenerateColumns = false;
			dataGridView_Debit.ReadOnly = true;

			comboBox_Workshop.DataSource = Program.db.Workshops.ToList();
			comboBox_Workshop.SelectedIndex = -1;

			comboBox_ReasonDebit.DataSource = Program.db.ReasonDebits.ToList();
			comboBox_ReasonDebit.SelectedIndex = -1;
		}

		private void AddEquipmentDebitForm_FormClosed(object sender, FormClosedEventArgs e) {
			Owner.Visible = true;
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

        private void checkBox_AllGroupDebit_CheckedChanged(object sender, EventArgs e) {
			comboBox_Equipment.Enabled = !checkBox_AllGroupDebit.Checked;
			button_Debit.Text = checkBox_AllGroupDebit.Checked ? "Списать всю группу" : "Списать";
		}

		private void ToolStripMenuItem_Find_EquipmentDebit_Click(object sender, EventArgs e) {
			this.Close();
		}


		private List<EquipmentGroup> EquipmentGroupsForWorkshop(Workshop workshop) {

			if (workshop == null) return null;

			List<EquipmentGroup> all = Program.db.EquipmentGroups.ToList();
			List<EquipmentGroup> res = new List<EquipmentGroup>();

			foreach (var item in all) if (item.PK_Workshop == workshop.PK_Workshop) res.Add(item);

			return res;
		}

		private List<Equipment> EquipmentsForEquipmentGroup(EquipmentGroup equipmentGroup) {
			if (equipmentGroup == null) return null;

			List<Equipment> all = Program.db.Equipments.ToList();
			List<Equipment> res = new List<Equipment>();

			foreach (var item in all) if (item.PK_Equipment_Group == equipmentGroup.PK_Equipment_Group) res.Add(item);

			return res;
		}

		private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e) {
			comboBox_GroupEquipment.DataSource = EquipmentGroupsForWorkshop((Workshop)comboBox_Workshop.SelectedItem);
			comboBox_GroupEquipment.SelectedIndex = -1;
		}

		private void comboBox_GroupEquipment_SelectedIndexChanged(object sender, EventArgs e) {
			comboBox_Equipment.DataSource = EquipmentsForEquipmentGroup((EquipmentGroup)comboBox_GroupEquipment.SelectedItem);
			comboBox_Equipment.DisplayMember = "inventory_number";
			comboBox_Equipment.SelectedIndex = -1;
		}

		private void button_Debit_Click(object sender, EventArgs e) {

			// если чекбокс тру - списываем все оборудование из группы
			if (checkBox_AllGroupDebit.Checked) {
				foreach(Equipment item in comboBox_Equipment.Items)
					AddToTable(item);
			}
			// иначе только одно выбранное
			else {
				AddToTable((Equipment)(comboBox_Equipment.SelectedItem));
			}

			// отключить выделение в таблице
			dataGridView_Debit.ClearSelection();
		}

		private void button_Delete_Click(object sender, EventArgs e) {
			foreach(DataGridViewRow row in dataGridView_Debit.SelectedRows)
				dataGridView_Debit.Rows.RemoveAt(row.Index);

			UpdateIndicesInTable();
		}

		private void AddToTable(Equipment equipment) {
			dataGridView_Debit.Rows.Add(
						dataGridView_Debit.Rows.Count + 1,
						comboBox_Workshop.SelectedItem,
						equipment.inventory_number,
						equipment.name,
						equipment.cost,
						comboBox_ReasonDebit.SelectedItem
					);
		}

		private void UpdateIndicesInTable() {
			foreach(DataGridViewRow row in dataGridView_Debit.Rows)
				row.Cells[0].Value = row.Index + 1;
		}

		private bool AddActDebit() {
			try {
				// проверка на заполнение
				if (String.IsNullOrWhiteSpace(textBox_ActNumber.Text)) {
					MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}

				if (dataGridView_Debit.Rows.Count < 1) {
					MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}

				ActDebit actDebit = new ActDebit();

				actDebit.act_number = textBox_ActNumber.Text;
				actDebit.date = dateTimePicker_DateDebit.Value.Date;

				//EquipmentGroup equipmentGroup = 
				actDebit.PK_Equipment_Group = 1;


				Program.db.ActDebits.Add(actDebit);

				Program.db.SaveChanges();

				int PK = actDebit.PK_Aсt_Debit;

				List<DebitEquipment> temp = new List<DebitEquipment>();
				foreach (DataGridViewRow row in dataGridView_Debit.Rows) {

					DebitEquipment debitEquipment = new DebitEquipment();
					debitEquipment.inventory_number = row.Cells[2].Value.ToString();
					debitEquipment.PK_Reason_Debit = (((ReasonDebit)row.Cells[5].Value).PK_Reason_Debit);
					debitEquipment.PK_Act_Debit = PK;

					//Program.db.DebitEquipments.Add(debitEquipment);

					temp.Add(debitEquipment);
					//Program.db.SaveChanges();
				}

				Program.db.AddRange(temp);

				Program.db.SaveChanges();
				return true;
			}
			catch (Exception e) {

				MessageBox.Show(e.Message);
				return false;
			}

			
		}

		private void button_Close_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void button_AddAndClose_Click(object sender, EventArgs e) {
			if (AddActDebit()) this.Close();
		}

		private void button_Add_Click(object sender, EventArgs e) {
			AddActDebit();
		}
	}
}
