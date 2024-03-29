﻿using System;
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


		public AddEquipmentDebitForm(Form owner) {
			InitializeComponent();

			Owner = owner;

			if (((LogInForm)owner).is_fullscreen())	this.WindowState = FormWindowState.Maximized;

			dataGridView_Debit.AutoGenerateColumns = false;
			dataGridView_Debit.ReadOnly = true;

			comboBox_Workshop.DataSource = Program.db.Workshops.ToList();
			comboBox_Workshop.SelectedIndex = -1;
			
			comboBox_ReasonDebit.DataSource = Program.db.ReasonDebits.ToList();
			comboBox_ReasonDebit.SelectedIndex = -1;

			comboBox_Workshop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_GroupEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_Equipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox_ReasonDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

		}

		private void AddEquipmentDebitForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (showOwner) Owner.Visible = true;
		}

		private void checkBox_AllGroupDebit_CheckedChanged(object sender, EventArgs e) {
			comboBox_Equipment.Enabled = !checkBox_AllGroupDebit.Checked;
			button_Debit.Text = checkBox_AllGroupDebit.Checked ? "Списать всю группу" : "Списать";
		}

		/* Загрузка данных в комбобоксы */
		private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e) {

			if (comboBox_Workshop.SelectedItem == null || comboBox_Workshop.SelectedIndex == -1) {
				comboBox_GroupEquipment.DataSource = null;
				comboBox_GroupEquipment.SelectedItem = null;
				comboBox_GroupEquipment.SelectedIndex = -1;
				return;
			}

			List<EquipmentGroup> list = Program.db.EquipmentGroups.Where(
				b => b.PK_Workshop == ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop).ToList();

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

			List<Equipment> list = Program.db.Equipments.Where(
				b => b.PK_Equipment_Group == ((EquipmentGroup)comboBox_GroupEquipment.SelectedItem).PK_Equipment_Group &&
				b.is_debit == false &&
				b.is_leasing == false).ToList();

			comboBox_Equipment.DataSource = list;
			comboBox_Equipment.DisplayMember = "inventory_number";
			comboBox_Equipment.SelectedIndex = -1;
		}
		/* End Загрузка данных в комбобоксы */


		/* Кнопки связанные со строками акта списания */
		private void button_Debit_Click(object sender, EventArgs e) {

			if (!CheckBeforeAddingToTable()) { return; }

			// если редактирование строки
			if (EditingMode) {
				Equipment equipment = (Equipment)comboBox_Equipment.SelectedItem;

				dataGridView_Debit.Rows[EditingIndex].Cells[1].Value = comboBox_Workshop.SelectedItem;
				dataGridView_Debit.Rows[EditingIndex].Cells[2].Value = comboBox_GroupEquipment.SelectedItem;
				dataGridView_Debit.Rows[EditingIndex].Cells[3].Value = equipment.PK_Equipment;
				dataGridView_Debit.Rows[EditingIndex].Cells[4].Value = equipment.inventory_number;
				dataGridView_Debit.Rows[EditingIndex].Cells[5].Value = equipment.name;
				dataGridView_Debit.Rows[EditingIndex].Cells[6].Value = equipment.cost;
				dataGridView_Debit.Rows[EditingIndex].Cells[7].Value = comboBox_ReasonDebit.SelectedItem;
				dataGridView_Debit.Rows[EditingIndex].Cells[8].Value = equipment;

				RestoreEdit();
				return;
			}


			// иначе обычное списание
			// если чекбокс тру - списываем все оборудование из группы
			if (checkBox_AllGroupDebit.Checked) {
				foreach(Equipment item in comboBox_Equipment.Items)
					if (!IsEquipmentInTable(item))
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

			comboBox_Workshop.Enabled = false;
			comboBox_GroupEquipment.Enabled = false;
			comboBox_Equipment.Enabled = false;

			comboBox_Workshop.SelectedItem = row.Cells[1].Value;
			comboBox_GroupEquipment.SelectedItem = row.Cells[2].Value;
			comboBox_Equipment.SelectedItem = row.Cells[8].Value;
			comboBox_ReasonDebit.SelectedItem = row.Cells[7].Value;

			button_Debit.Text = "Применить";
			button_Delete.Text = "Отменить";
		}
		/* END Кнопки связанные со строками акта списания */


		private bool CheckBeforeAddingToTable() {

			bool MSG(string msg) {
				MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// если не выбран цех
			if (comboBox_Workshop.SelectedIndex == -1) return MSG("Поле \"Цех\" не выбрано");

			// если не выбрана группа
			if (comboBox_GroupEquipment.SelectedIndex == -1) return MSG("Поле \"Группа оборудования\" не выбрано");

			// если не выбрано "списать всю группу" и не выбрано оборудование
			if (!checkBox_AllGroupDebit.Checked && comboBox_Equipment.SelectedIndex == -1) return MSG("Поле \"Оборудование\" не выбрано");

			// если не выбрана причина списания
			if (comboBox_ReasonDebit.SelectedIndex == -1) return MSG("Поле \"Причина списания\" не выбрано");

			// если списание одного оборудования, то чек что его нет в таблице 
			if (!checkBox_AllGroupDebit.Checked) {
				if (!EditingMode)
					if (IsEquipmentInTable((Equipment)comboBox_Equipment.SelectedItem))
						return MSG("Данное оборудование уже выбрано для списания");
			}

			return true;
		}

		private bool IsEquipmentInTable(Equipment equipment) {
			int PK = equipment.PK_Equipment;

			foreach (DataGridViewRow row in dataGridView_Debit.Rows)
				if (Convert.ToInt32(row.Cells[3].Value) == PK)
					return true;

			return false;
		}

		private void AddToTable(Equipment equipment) {
			dataGridView_Debit.Rows.Add(
						dataGridView_Debit.Rows.Count + 1,
						comboBox_Workshop.SelectedItem,
						comboBox_GroupEquipment.SelectedItem,
						equipment.PK_Equipment,
						equipment.inventory_number,
						equipment.name,
						equipment.cost,
						comboBox_ReasonDebit.SelectedItem,
						equipment
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
					MessageBox.Show("Номер акта не указан!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}

				if (dataGridView_Debit.Rows.Count < 1) {
					MessageBox.Show("Не выбрано оборудование для списания!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}

				ActDebit actDebit = new ActDebit {
					act_number = textBox_ActNumber.Text,
					date = dateTimePicker_DateDebit.Value.Date
				};

				Program.db.ActDebits.Add(actDebit);
				Program.db.SaveChanges();
				
				int PK = actDebit.PK_Aсt_Debit;

				List <DebitEquipment> debits = new List<DebitEquipment>();

				foreach (DataGridViewRow row in dataGridView_Debit.Rows) {
					debits.Add(new DebitEquipment {
						inventory_number = row.Cells[4].Value.ToString(),
						PK_Reason_Debit = ((ReasonDebit)row.Cells[7].Value).PK_Reason_Debit,
						PK_Aсt_Debit = PK,
						PK_Equipment_Group = ((EquipmentGroup)row.Cells[2].Value).PK_Equipment_Group,
						name = row.Cells[5].Value.ToString(),
						cost = (decimal)row.Cells[6].Value
					});

					Program.db.Equipments.Find(Convert.ToInt32(row.Cells[3].Value)).is_debit = true;
				}

				Program.db.DebitEquipments.AddRange(debits);
				Program.db.SaveChanges();

				MessageBox.Show("Акт списания оборудования № " + actDebit.act_number + " успешно создан!", "Успех!");
				return true;
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
				return false;
			}
		}

		/* Для редактирования строки акта */
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

			comboBox_Equipment.Enabled = !checkBox_AllGroupDebit.Checked;

			comboBox_Workshop.Enabled = true;
			comboBox_GroupEquipment.Enabled = true;

			button_Debit.Text = "Списать";
			button_Delete.Text = "Удалить";

			stateAllSaved = false;
			EditingMode = false;
			EditingIndex = -1;
		}
		/* END Для редактирования строки акта */

		/* Кнопки связанные с актом */
		private void button_Close_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void button_AddAndClose_Click(object sender, EventArgs e) {
			button_AddAndClose.Enabled = false;
			if (AddActDebit()) {
				button_AddAndClose.Enabled = true;
				this.Close(); 
			}
			button_AddAndClose.Enabled = true;
		}
		private void button_Add_Click(object sender, EventArgs e) {
			button_Add.Enabled = false;
			if (AddActDebit())
				RestoreForm();
			button_Add.Enabled = true;
		}
		/* END Кнопки связанные с актом */

		private void RestoreForm() {
			textBox_ActNumber.Text = "";
			dateTimePicker_DateDebit.Value = DateTime.Now;
			dataGridView_Debit.Rows.Clear();

			comboBox_ReasonDebit.SelectedIndex = -1;
			comboBox_Workshop.SelectedIndex = -1;
		}

		/* Меню */
		private void ToolStripMenuItem_File_ExitModule_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void ToolStripMenuItem_File_ExitProg_Click(object sender, EventArgs e) {
			Application.Exit();
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
		private void ToolStripMenuItem_Find_EquipmentDebit_Click(object sender, EventArgs e) {
			showOwner = false;

			EquipmentModuleForm form = new EquipmentModuleForm(Owner);
			this.Close();
			form.Visible = true;
		}
		/* END Меню */
	}
}
