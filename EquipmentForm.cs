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

namespace OGM
{
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();

            this.comboBox_Workshop.AutoCompleteMode = this.comboBox_GroupEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Workshop.AutoCompleteSource = this.comboBox_GroupEquipment.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns[0].DataPropertyName = "PK_Equipment";
            dataGridView.Columns[1].DataPropertyName = "name";
            dataGridView.Columns[2].DataPropertyName = "inventory_number";
            dataGridView.Columns[3].DataPropertyName = "PK_Workshop";
            dataGridView.Columns[4].DataPropertyName = "workshop";
            dataGridView.Columns[5].DataPropertyName = "PK_Equipment_Group";
            dataGridView.Columns[6].DataPropertyName = "equipment_Group";
            dataGridView.Columns[7].DataPropertyName = "serial_number";
            dataGridView.Columns[8].DataPropertyName = "cost";
            dataGridView.Columns[9].DataPropertyName = "is_debit";
            dataGridView.Columns[10].DataPropertyName = "is_leasing";
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddEquipment().ShowDialog();
        }
        

        private void Equipment_Activated(object sender, EventArgs e)
        {
            List<Equipment> equipments = Program.db.Equipments.ToList();

            dataGridView.DataSource = equipments;
            dataGridView.ClearSelection();

            this.comboBox_Workshop.DataSource = Program.db.Workshops.ToList();
            this.comboBox_Workshop.SelectedIndex = -1;
        }

        private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // при выборе цеха нужно найти его первичный ключ цех
            // потом нужно найти все группы, принадлежащие данному цеху

            if (comboBox_Workshop.SelectedIndex != -1 && comboBox_Workshop.SelectedItem != null)
            {

                int PK_Workshop = ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop;

                List<EquipmentGroup> equipmentGroups = Program.db.EquipmentGroups.ToList();
                List<EquipmentGroup> equipmentGroupsResult = new List<EquipmentGroup>();

                foreach (EquipmentGroup item in equipmentGroups)
                    if (item.PK_Workshop == PK_Workshop)
                        equipmentGroupsResult.Add(item);

                this.comboBox_GroupEquipment.DataSource = equipmentGroupsResult;
                this.comboBox_GroupEquipment.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_GroupEquipment.DataSource = null;
                this.comboBox_GroupEquipment.Text = "";
                this.comboBox_GroupEquipment.SelectedIndex = -1;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(this.textBox_InventoryNum.Text)) this.textBox_InventoryNum.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_NameEquipment.Text)) this.textBox_NameEquipment.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_SerialNum.Text)) this.textBox_SerialNum.Text = "";


            List<Equipment> equipments = Program.db.Equipments.ToList();
            List<Equipment> equipmentsResult = new List<Equipment>();

            int PK_Workshop = -1;
            if (((Workshop)comboBox_Workshop.SelectedItem) != null)
                PK_Workshop = ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop;

            int PK_Equipment_Group = -1;
            if (((EquipmentGroup)comboBox_GroupEquipment.SelectedItem) != null)
                PK_Equipment_Group = ((EquipmentGroup)comboBox_GroupEquipment.SelectedItem).PK_Equipment_Group;


            bool is_debit = this.radioButton_is_debit.Checked;
            bool is_leasing = this.radioButton_is_leasing.Checked;

            foreach (Equipment item in equipments)
                if (item.name.ToLower().Contains(this.textBox_NameEquipment.Text.ToLower())
                    && item.inventory_number.ToLower().Contains(this.textBox_InventoryNum.Text.ToLower())
                    && item.serial_number.ToLower().Contains(this.textBox_SerialNum.Text.ToLower()))
                {

                    bool is_good_row = true;
                    if (PK_Workshop != -1)
                        if (item.PK_Workshop != PK_Workshop)
                            is_good_row = false;

                    if (PK_Equipment_Group != -1)
                        if (item.PK_Equipment_Group != PK_Equipment_Group)
                            is_good_row = false;

                    if (is_debit)
                        if (item.is_debit == false)
                            is_good_row = false;

                    if (is_leasing)
                        if (item.is_leasing == false)
                            is_good_row = false;



                    if (is_good_row)
                        equipmentsResult.Add(item);

                }
                    


            dataGridView.DataSource = equipmentsResult;
            dataGridView.ClearSelection();
        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_GroupEquipment.SelectedIndex = -1;
            this.comboBox_Workshop.SelectedIndex = -1;
            this.textBox_NameEquipment.Text = "";
            this.textBox_InventoryNum.Text = "";
            this.textBox_SerialNum.Text = "";

            List<Equipment> equipments = Program.db.Equipments.ToList();
            dataGridView.DataSource = equipments;
            dataGridView.ClearSelection();

            this.comboBox_Workshop.Focus();

        }

        private void button_EditEquipment_Click(object sender, EventArgs e)
        {
            int PK_Equipment = -1;
            try
            {
                PK_Equipment = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Выберите запись, которую нужно изменить", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Equipment equipment = Program.db.Equipments.Find(PK_Equipment);

            if (equipment != null)
                new AddEquipment(equipment).ShowDialog();
        }

        private void button_RemoveEquipment_Click(object sender, EventArgs e)
        {
            // сформируем список для удаления 
            // заранее - потому что messagebox, который отвечает за подтверждение удаления (ниже)
            // вызывает событие Activated, что обновляет таблицу
            // из-за этого selectedrows сбрасывается...

            List<Equipment> EquipmentForRemove = new List<Equipment>();

            int PK_Equipment = -1;
            try
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    PK_Equipment = Convert.ToInt32(row.Cells[0].Value);
                    Equipment curEquipment = Program.db.Equipments.Find(PK_Equipment);

                    if (curEquipment != null)
                        EquipmentForRemove.Add(curEquipment);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить выбранное оборудование? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            // применим удаление
            foreach (var equipment in EquipmentForRemove)
                Program.db.Remove(equipment);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }
    }
}
