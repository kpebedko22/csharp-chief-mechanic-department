using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
            
            // сохраним выбор
            Workshop selected_wrokshop = ((Workshop)this.comboBox_Workshop.SelectedItem);
            EquipmentGroup selected_group = ((EquipmentGroup)this.comboBox_GroupEquipment.SelectedItem);

            //List<Equipment> equipments = Program.db.Equipments.ToList();

            //dataGridView.DataSource = equipments;
            //dataGridView.ClearSelection();

            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            if (selected_wrokshop != null && workshops.Contains(selected_wrokshop))
                this.comboBox_Workshop.SelectedItem = selected_wrokshop;
            else
                this.comboBox_Workshop.SelectedItem = null;

            this.comboBox_GroupEquipment.SelectedItem = selected_group;

            //this.button_Search.PerformClick();
            
        }

        private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // при выборе цеха нужно найти его первичный ключ цех
            // потом нужно найти все группы, принадлежащие данному цеху

            System.Console.WriteLine("\n\n index = " + comboBox_Workshop.SelectedIndex.ToString());

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

            string inventory_num = this.textBox_InventoryNum.Text.ToLower();
            string serial_num = this.textBox_SerialNum.Text.ToLower();
            string name = this.textBox_NameEquipment.Text.ToLower();


            int PK_Workshop = -1;
            if (((Workshop)comboBox_Workshop.SelectedItem) != null)
                PK_Workshop = ((Workshop)comboBox_Workshop.SelectedItem).PK_Workshop;

            int PK_Equipment_Group = -1;
            if (((EquipmentGroup)comboBox_GroupEquipment.SelectedItem) != null)
                PK_Equipment_Group = ((EquipmentGroup)comboBox_GroupEquipment.SelectedItem).PK_Equipment_Group;


            bool is_debit = this.radioButton_is_debit.Checked;
            bool is_leasing = this.radioButton_is_leasing.Checked;

            //bool searched = false; // был ли поиск по фильтрам?

            // для ускорения поиска
            IQueryable<Equipment> equipments = null;
            List<Equipment> result = new List<Equipment>();

            using (OGMContext db = new OGMContext())
            {

                if (PK_Workshop != -1 && PK_Equipment_Group != -1)
                    equipments = db.Equipments.AsNoTracking().Where(eq =>
                                                 eq.PK_Equipment_Group == PK_Equipment_Group
                                                && eq.name.ToLower().Contains(name)
                                                && eq.inventory_number.ToLower().Contains(inventory_num)
                                                && eq.serial_number.ToLower().Contains(serial_num)).AsNoTracking();

                else if (PK_Workshop != -1)
                {

                    List<EquipmentGroup> groups = db.EquipmentGroups.Where(g => g.PK_Workshop == PK_Workshop).ToList();
                    List<Equipment> result_for_workshop = new List<Equipment>();

                    foreach (EquipmentGroup item in groups)
                    {
                        int pk = item.PK_Equipment_Group;
                        List<Equipment> temp = db.Equipments.Where(eq => eq.PK_Equipment_Group == pk
                                            && eq.name.ToLower().Contains(name)
                                            && eq.inventory_number.ToLower().Contains(inventory_num)
                                            && eq.serial_number.ToLower().Contains(serial_num)).ToList();
   
                        if (temp != null)
                            foreach (Equipment eq in temp)
                                result_for_workshop.Add(eq);
                    }

                    equipments = result_for_workshop.AsQueryable();
                    

                }
                if (is_debit)
                {
                    if (equipments != null)
                        equipments = equipments.AsNoTracking().Where(eq => eq.is_debit == true);
                    else
                        equipments = db.Equipments.AsNoTracking().Where(eq => eq.is_debit == true
                                                    && eq.name.ToLower().Contains(name)
                                                    && eq.inventory_number.ToLower().Contains(inventory_num)
                                                    && eq.serial_number.ToLower().Contains(serial_num));
                }
                else if (is_leasing)
                {
                    if (equipments != null)
                        equipments = equipments.Where(eq => eq.is_leasing == true);
                    else
                        equipments = db.Equipments.AsNoTracking().Where(eq => eq.is_leasing == true
                                                    && eq.name.ToLower().Contains(name)
                                                    && eq.inventory_number.ToLower().Contains(inventory_num)
                                                    && eq.serial_number.ToLower().Contains(serial_num));
                }
                else if (equipments == null)
                    equipments = db.Equipments.AsNoTracking().Where(eq =>
                                   eq.name.ToLower().Contains(name)
                                && eq.inventory_number.ToLower().Contains(inventory_num)
                                && eq.serial_number.ToLower().Contains(serial_num));


                if (equipments != null)
                {
                    dataGridView.DataSource = equipments.ToList();
                    dataGridView.ClearSelection();
                    if (equipments.Count() == 0)
                        MessageBox.Show("Ничего не найдено!", "Ошибка!");

                }
                else 
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("Ничего не найдено!", "Ошибка!");

                }

            }
            
        }



        private static async Task<List<Equipment>> GetEquipmentAsync(int PK_Workshop)
        {
            using (OGMContext db = new OGMContext())
            {
                
            return await db.Equipments.Where(eq => eq.PK_Workshop == PK_Workshop).ToListAsync();
            }

        }


        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_GroupEquipment.SelectedIndex = -1;
            this.comboBox_Workshop.SelectedIndex = -1;
            this.textBox_NameEquipment.Text = "";
            this.textBox_InventoryNum.Text = "";
            this.textBox_SerialNum.Text = "";
            this.radioButton_all.Checked = true;

            //List<Equipment> equipments = Program.db.Equipments.ToList();
            //dataGridView.DataSource = equipments;
            dataGridView.DataSource = null;
            //dataGridView.ClearSelection();

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


            // нельзя удалять оборудование, которое приобретено в лизинг!
            // Оставим в списке те, которые можно удалить
            List<Equipment> good_list = new List<Equipment>();
            bool check = false; // флаг - имеются записи, которые не будут удалены
            foreach (var item in EquipmentForRemove)
                if (item.is_leasing == false)
                    good_list.Add(item);
                else
                    check = true;


            // запрос подтверждения
            if (good_list.Count() > 0 && check)
            {
                if (MessageBox.Show("Среди выбранного оборудования есть приобритённое в лизинг! Такое оборудование нельзя удалить! \n\nУдалить оборудование, которое не вызвало такого конфликта?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            else if (good_list.Count() == 0 && check)
                MessageBox.Show("Невозможно выполнить удаление. Выбранное оборудование приобретено в лизинг!");


            // применим удаление
            foreach (var equipment in good_list)
                Program.db.Remove(equipment);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 1 || this.dataGridView.SelectedRows.Count < 1)
                this.button_show_act_contract.Visible = false;
            else
            {
                this.button_show_act_contract.Visible = true;
                if (Convert.ToBoolean(dataGridView.SelectedRows[0].Cells[9].Value) == true)
                    this.button_show_act_contract.Text = "Перейти к акту";
                else if (Convert.ToBoolean(dataGridView.SelectedRows[0].Cells[10].Value) == true)
                        this.button_show_act_contract.Text = "Перейти к договору";
                else
                    this.button_show_act_contract.Visible = false;
   
            }
        }

        private void button_show_act_contract_Click(object sender, EventArgs e)
        {
            try
            {

                int PK_Equipment = Convert.ToInt32(this.dataGridView.SelectedRows[0].Cells[0].Value);
                Equipment equipment = null;
                using (OGMContext db = new OGMContext()) { equipment = db.Equipments.Find(PK_Equipment); }

                if (equipment == null)
                    throw new Exception();


                if (this.button_show_act_contract.Text == "Перейти к акту")
                {
                    ActDebit actDebit = null;
                    using (OGMContext db = new OGMContext()) { actDebit = db.ActDebits.Find(equipment.PK_Debit); }

                    if (actDebit == null)
                        throw new Exception();

                    new DebitViewForm(actDebit).ShowDialog();
                }
                else if (this.button_show_act_contract.Text == "Перейти к договору")
                {
                    LeasingContract leasingContract = null;
                    using (OGMContext db = new OGMContext()) { leasingContract = db.LeasingContracts.Find(equipment.PK_Leasing); }

                    if (leasingContract == null)
                        throw new Exception();

                    new LeasingViewForm(leasingContract).ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось перейти к документу", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
