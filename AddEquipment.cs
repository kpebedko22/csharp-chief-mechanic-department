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

namespace OGM
{
    public partial class AddEquipment : Form
    {

        private Equipment EditEquipment = null;

        private List<EquipmentGroup> get_group_list(Workshop workshop)
        {
            if (workshop == null)
                return null;

            List<EquipmentGroup> equipmentGroup = Program.db.EquipmentGroups.ToList();
            List<EquipmentGroup> result = new List<EquipmentGroup>();

            foreach (EquipmentGroup item in equipmentGroup)
                if (item.PK_Workshop == workshop.PK_Workshop)
                    result.Add(item);

            return result;
        }
       


        public AddEquipment(Equipment equipment = null)
        {
            InitializeComponent();

            this.comboBox_Workshop.AutoCompleteMode = this.comboBox_GroupEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Workshop.AutoCompleteSource = this.comboBox_GroupEquipment.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedIndex = -1;

            if (equipment != null)
            {
                this.Text = "Справочник - Редактировать оборудование";
                this.button_AddEquipment.Text = "Изменить";
                this.button_AddEquipmentAndClose.Text = "Изменить и закрыть";
                this.textBox_NameEquipment.Text = equipment.name;
                this.textBox_InventoryNum.Text = equipment.inventory_number;
                this.textBox_SerialNum.Text = equipment.serial_number;

                Workshop workshop = Program.db.Workshops.Find(equipment.PK_Workshop);
                this.comboBox_Workshop.SelectedItem = workshop;

                this.comboBox_GroupEquipment.DataSource = get_group_list(workshop);
                this.comboBox_GroupEquipment.SelectedItem = equipment.equipment_Group;

                this.EditEquipment = equipment;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool add_edit_Equipment()
        {
            // проверка на заполненность строк
            if (String.IsNullOrWhiteSpace(this.textBox_InventoryNum.Text)
                || String.IsNullOrWhiteSpace(this.textBox_NameEquipment.Text)
                || String.IsNullOrWhiteSpace(this.textBox_SerialNum.Text)
                || this.comboBox_Workshop.SelectedItem == null || this.comboBox_Workshop.SelectedIndex == -1
                || this.comboBox_GroupEquipment.SelectedItem == null || this.comboBox_Workshop.SelectedIndex == -1)
            {
                MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            // если добавляем
            if (this.EditEquipment == null)
            {
                Equipment newEquipment = new Equipment();

                newEquipment.name = this.textBox_NameEquipment.Text;
                newEquipment.inventory_number = this.textBox_InventoryNum.Text;
                newEquipment.serial_number = this.textBox_SerialNum.Text;
                newEquipment.PK_Equipment_Group = ((EquipmentGroup)this.comboBox_GroupEquipment.SelectedItem).PK_Equipment_Group;

                MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            // редактируем
            else
            {

                this.EditEquipment.name = this.textBox_NameEquipment.Text;
                this.EditEquipment.inventory_number = this.textBox_InventoryNum.Text;
                this.EditEquipment.serial_number = this.textBox_SerialNum.Text;

                // Workshop workshop = ((Workshop)this.comboBox_Workshop.SelectedItem);
                EquipmentGroup equipmentGroup = ((EquipmentGroup)this.comboBox_GroupEquipment.SelectedItem);

                this.EditEquipment.PK_Equipment_Group = equipmentGroup.PK_Equipment_Group;

                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Program.db.SaveChanges();

            return true;
        }


        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            add_edit_Equipment();
        }

        private void button_AddEquipmentAndClose_Click(object sender, EventArgs e)
        {
            if (add_edit_Equipment())
                this.Close();
        }

        private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // при выборе цеха нужно найти его первичный ключ цех
            // потом нужно найти все группы, принадлежащие данному цеху

            if (comboBox_Workshop.SelectedIndex != -1 && comboBox_Workshop.SelectedIndex != null)
            {

                int PK_Workshop = ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop;

                List<EquipmentGroup> equipmentGroups = Program.db.EquipmentGroups.ToList();
                List<EquipmentGroup> equipmentGroupsResult = new List<EquipmentGroup>();

                foreach (EquipmentGroup item in equipmentGroups)
                    if (item.PK_Workshop == PK_Workshop)
                        equipmentGroupsResult.Add(item);

                this.comboBox_GroupEquipment.DataSource = equipmentGroupsResult;
                this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(equipmentGroupsResult.Select(i => i.name).ToArray());
                this.comboBox_GroupEquipment.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_GroupEquipment.DataSource = null;
                this.comboBox_GroupEquipment.Text = "";
                this.comboBox_GroupEquipment.SelectedIndex = -1;
            }
        }
    }
}
