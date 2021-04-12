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

		private bool showOwner = true;
		private new Form Owner;

		private bool EditingMode = false;
		private int EditingIndex = -1;
		private Workshop workshopSaved = null;
		private EquipmentGroup groupSaved = null;
		private Equipment equipmentSaved = null;
		private ReasonDebit reasonSaved = null;
		private bool stateAllSaved = false;

		private void SaveBeforeEdit() {
			workshopSaved = (Workshop)comboBox_Workshop.SelectedItem;
			groupSaved = (EquipmentGroup)comboBox_GroupEquipment.SelectedItem;
			equipmentSaved = (Equipment)comboBox_Equipment.SelectedItem;
			reasonSaved = (ReasonDebit)comboBox_ReasonDebit.SelectedItem;

			stateAllSaved = checkBox_AllGroupDebit.Checked;
		}

		private void RestoreEdit() {
			comboBox_Workshop.SelectedItem = workshopSaved;
			comboBox_GroupEquipment.SelectedItem = groupSaved;
			comboBox_Equipment.SelectedItem = equipmentSaved;
			comboBox_ReasonDebit.SelectedItem = reasonSaved;

			checkBox_AllGroupDebit.Enabled = true;
			checkBox_AllGroupDebit.Checked = stateAllSaved;

			button_Debit.Text = "Списать";
			button_Delete.Text = "Удалить";

			stateAllSaved = false;
			EditingMode = false;
			EditingIndex = -1;
		}

		private List<Workshop> cmbWorkshops;
		private List<ReasonDebit> cmbReasons;

		public AddEquipmentDebitForm(Form owner) {
			InitializeComponent();

			Owner = owner;

			dataGridView_Debit.AutoGenerateColumns = false;
			dataGridView_Debit.ReadOnly = true;

			//comboBox_Workshop.DataSource = Program.db.Workshops.ToList();
			//comboBox_Workshop.SelectedIndex = -1;
			//
			//comboBox_ReasonDebit.DataSource = Program.db.ReasonDebits.ToList();
			//comboBox_ReasonDebit.SelectedIndex = -1;


			comboBox_Workshop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_GroupEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_Equipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_ReasonDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			BG_Worker_OnLoad.RunWorkerAsync();
		}

		private void AddEquipmentDebitForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (showOwner)
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
			showOwner = false;

			EquipmentModuleForm form = new EquipmentModuleForm(Owner);
			this.Close();
			form.Visible = true;
		}

		/* Все работатет */
		private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e) {

			if (comboBox_Workshop.SelectedItem == null || comboBox_Workshop.SelectedIndex == -1) {
				comboBox_GroupEquipment.DataSource = null;
				comboBox_GroupEquipment.SelectedItem = null;
				comboBox_GroupEquipment.SelectedIndex = -1;
				return;
			}

			List<EquipmentGroup> list = Program.db.EquipmentGroups.Where(b => b.PK_Workshop == ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop).ToList();

			if (list.Count < 1) {
				comboBox_GroupEquipment.DataSource = null;
				comboBox_GroupEquipment.SelectedItem = null;
				comboBox_GroupEquipment.SelectedIndex = -1;
				return;
			}

			comboBox_GroupEquipment.DataSource = list;
			comboBox_GroupEquipment.SelectedIndex = -1;
		}
		private void comboBox_GroupEquipment_SelectedIndexChanged(object sender, EventArgs e) {
			
			if (comboBox_GroupEquipment.SelectedItem == null || comboBox_GroupEquipment.SelectedIndex == -1) {
				comboBox_Equipment.DataSource = null;
				comboBox_Equipment.SelectedItem = null;
				comboBox_Equipment.SelectedIndex = -1;
				return;
			}

			List<Equipment> list = Program.db.Equipments.Where(b => b.PK_Equipment_Group == ((EquipmentGroup)comboBox_GroupEquipment.SelectedItem).PK_Equipment_Group).ToList();
			
			if (list.Count < 1) {
				comboBox_Equipment.DataSource = null;
				comboBox_Equipment.SelectedItem = null;
				comboBox_Equipment.SelectedIndex = -1;
				return;
			}

			comboBox_Equipment.DataSource = list;
			comboBox_Equipment.DisplayMember = "inventory_number";
			comboBox_Equipment.SelectedIndex = -1;
		}
		/* End Все работатет */



		private void button_Debit_Click(object sender, EventArgs e) {

			if (!CheckBeforeAddingToTable()) { MessageBox.Show("Не все поля заполнены"); return; }

			// если редактирование строки
			if (EditingMode) {
				Equipment equipment = (Equipment)comboBox_Equipment.SelectedItem;

				dataGridView_Debit.Rows[EditingIndex].Cells[1].Value = comboBox_Workshop.SelectedItem;
				dataGridView_Debit.Rows[EditingIndex].Cells[2].Value = comboBox_GroupEquipment.SelectedItem;
				dataGridView_Debit.Rows[EditingIndex].Cells[3].Value = equipment;
				dataGridView_Debit.Rows[EditingIndex].Cells[4].Value = equipment.inventory_number;
				dataGridView_Debit.Rows[EditingIndex].Cells[5].Value = equipment.name;
				dataGridView_Debit.Rows[EditingIndex].Cells[6].Value = equipment.cost;
				dataGridView_Debit.Rows[EditingIndex].Cells[7].Value = comboBox_ReasonDebit.SelectedItem;

				RestoreEdit();
				return;
			}


			// иначе обычное списание
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
			// отмена изменения строки таблицы
			if (EditingMode) {
				RestoreEdit();
				return;
			}

			foreach (DataGridViewRow row in dataGridView_Debit.SelectedRows)
				dataGridView_Debit.Rows.RemoveAt(row.Index);

			UpdateIndicesInTable();
		}
		
		private void button_Edit_Click(object sender, EventArgs e) {

			if (dataGridView_Debit.SelectedRows.Count < 1) {
				MessageBox.Show("Выберите строку таблицы");
				return;
			}

			DataGridViewRow row = dataGridView_Debit.SelectedRows[0];
			EditingIndex = row.Index;
			EditingMode = true;

			SaveBeforeEdit();

			if (checkBox_AllGroupDebit.Checked) checkBox_AllGroupDebit.Checked = false;
			checkBox_AllGroupDebit.Enabled = false;

			comboBox_Workshop.SelectedItem = row.Cells[1].Value;
			comboBox_GroupEquipment.SelectedItem = row.Cells[2].Value;
			comboBox_Equipment.SelectedItem = row.Cells[3].Value;
			comboBox_ReasonDebit.SelectedItem = row.Cells[7].Value;

			button_Debit.Text = "Применить";
			button_Delete.Text = "Отменить";
		}



		private bool CheckBeforeAddingToTable() {

			// если не выбран цех
			if (comboBox_Workshop.SelectedIndex == -1) return false;

			// если не выбрана группа
			if (comboBox_GroupEquipment.SelectedIndex == -1) return false;
			
			// если не выбрано "списать всю группу" и не выбрано оборудование
			if (!checkBox_AllGroupDebit.Checked && comboBox_Equipment.SelectedIndex == -1) return false;

			// если не выбрана причина списания
			if (comboBox_ReasonDebit.SelectedIndex == -1) return false;

			// можно здесь проверять что такое оборудование уже есть в таблице на списание

			return true;
		}

		private void AddToTable(Equipment equipment) {
			dataGridView_Debit.Rows.Add(
						dataGridView_Debit.Rows.Count + 1,
						comboBox_Workshop.SelectedItem,
						comboBox_GroupEquipment.SelectedItem,
						equipment,
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
				
				
				Program.db.ActDebits.Add(actDebit);
				Program.db.SaveChanges();
				
				int PK = actDebit.PK_Aсt_Debit;


				List <DebitEquipment> debits = new List<DebitEquipment>();

				foreach (DataGridViewRow row in dataGridView_Debit.Rows) 
					debits.Add(new DebitEquipment {
						inventory_number = row.Cells[3].Value.ToString(),
						PK_Reason_Debit = ((ReasonDebit)row.Cells[7].Value).PK_Reason_Debit,
						PK_Aсt_Debit = PK
					});
				

				Program.db.DebitEquipments.AddRange(debits);
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

		

		private void BG_Worker_OnLoad_DoWork(object sender, DoWorkEventArgs e) {
			cmbWorkshops = Program.db.Workshops.ToList();
			cmbReasons = Program.db.ReasonDebits.ToList();
		}
		private void BG_Worker_OnLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			if (e.Error != null) { MessageBox.Show(e.Error.Message); return; }
			else {
				comboBox_Workshop.DataSource = cmbWorkshops;
				comboBox_Workshop.SelectedIndex = -1;


				Console.WriteLine(cmbReasons);
				Console.WriteLine(cmbReasons[0]);
				comboBox_ReasonDebit.DataSource = cmbReasons;
				comboBox_ReasonDebit.SelectedIndex = -1;

				cmbWorkshops.Clear();
				cmbReasons.Clear();
			}
		}

	}
}
