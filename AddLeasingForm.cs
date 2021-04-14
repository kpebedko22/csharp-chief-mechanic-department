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
    public partial class AddLeasingForm : Form
    {
        private bool showOwner = true;
        private new Form Owner;

        int index_row_in_edit;
        Workshop workshop_saved = null;
        EquipmentGroup group_saved = null;
        string amount_saved = "";
        Decimal cost_saved = 0;

        private void save_row_data()
        {
            workshop_saved = ((Workshop)comboBox_Workshop.SelectedItem);
            group_saved = ((EquipmentGroup)comboBox_Equipment.SelectedItem);
            amount_saved = this.textBox_Amount.Text;
            cost_saved = this.numericUpDown_Cost.Value;
        }

        private void restore_row_data()
        {
            comboBox_Workshop.SelectedItem = this.workshop_saved;
            comboBox_Equipment.SelectedItem = this.group_saved;
            this.textBox_Amount.Text = this.amount_saved;
            this.numericUpDown_Cost.Value = this.cost_saved;
            this.index_row_in_edit = -1;
            }



        public AddLeasingForm(Form owner)
        {
            InitializeComponent();

            Owner = owner;

            if (((LogInForm)owner).is_fullscreen()) this.WindowState = FormWindowState.Maximized;

            this.numericUpDown_PenaltyFee.Controls[0].Visible = false;
            this.numericUpDown_Cost.Controls[0].Visible = false;


            this.dateTimePicker_DateDelivery.MinDate = this.dateTimePicker_DateConclusion.Value.Date;
            this.dateTimePicker_DateEnd.MinDate = this.dateTimePicker_DateEnd.Value.Date;
            this.dateTimePicker_DateEnd.Value = this.dateTimePicker_DateEnd.Value.AddYears(3);
            this.dateTimePicker_DateEnd.MaxDate = this.dateTimePicker_DateConclusion.Value.Date.AddYears(100);


            this.comboBox_lessee.AutoCompleteMode = this.comboBox_Leaser.AutoCompleteMode = this.comboBox_Seller.AutoCompleteMode = this.comboBox_Equipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_lessee.AutoCompleteSource = this.comboBox_Leaser.AutoCompleteSource = this.comboBox_Seller.AutoCompleteSource = this.comboBox_Equipment.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<Organization> lessee = Program.db.Organizations.Where(b => b.PK_Role == 1).ToList();
            this.comboBox_lessee.DataSource = lessee;
            this.comboBox_lessee.AutoCompleteCustomSource.AddRange(lessee.Select(i => i.name).ToArray());
            this.comboBox_lessee.SelectedIndex = -1;

            List<Organization> leasers = Program.db.Organizations.Where(b => b.PK_Role == 2).ToList();
            this.comboBox_Leaser.DataSource = leasers;
            this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(leasers.Select(i => i.name).ToArray());
            this.comboBox_Leaser.SelectedIndex = -1;

            List<Organization> sellers = Program.db.Organizations.Where(b => b.PK_Role == 3).ToList();
            this.comboBox_Seller.DataSource = sellers;
            this.comboBox_Seller.AutoCompleteCustomSource.AddRange(sellers.Select(i => i.name).ToArray());
            this.comboBox_Seller.SelectedIndex = -1;

            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedIndex = -1;

           
        }


        private void AddLeasingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (showOwner)
                Owner.Visible = true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOwner = false;

            LeasingModuleForm form = new LeasingModuleForm(Owner);
            this.Close();
            form.Visible = true;
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EquipmentForm().ShowDialog();
        }

        private void причинаСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReasonDebitForm().ShowDialog();
        }

        private void группаОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupEquipmentForm().ShowDialog();
        }

        private void цехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkshopForm().ShowDialog();
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationForm().ShowDialog();
        }

        private void button_RemoveEquipment_Click(object sender, EventArgs e)
        {

            // отмена изменения строки таблицы
            if (this.button_RemoveEquipment.Text == "Отменить")
            {
                restore_row_data();
                this.button_RemoveEquipment.Text = "Удалить";
                this.button_AddRowEquipment.Text = "Добавить";
                return;
            }

            // удаление
            List<DataGridViewRow> rows_for_delete = new List<DataGridViewRow>();

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                rows_for_delete.Add(item);

            if (rows_for_delete.Count == 0)
                return;

            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить строки из таблицы? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // удаляем
            foreach (var item in rows_for_delete)
                dataGridView1.Rows.Remove(item);


        }


        private void comboBox_Seller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Seller.SelectedItem == null || this.comboBox_Seller.SelectedIndex == -1)
            {
                //this.label_nameSeller.Text = "Наименование: ";
                //this.label_phoneSeller.Text = "Телефон: ";
                //this.label_INNSeller.Text = "ИНН: ";

                this.label_nameSeller_value.Text = "...";
                this.label_phoneSeller_value.Text = "...";
                this.label_INNSeller_value.Text = "...";
            }    
            else
            {
                //this.label_nameSeller.Text = "Наименование: " + ((Organization)this.comboBox_Seller.SelectedItem).name;
                //this.label_phoneSeller.Text = "Телефон: " + ((Organization)this.comboBox_Seller.SelectedItem).phone;
                //this.label_INNSeller.Text = "ИНН: " + ((Organization)this.comboBox_Seller.SelectedItem).INN;

                this.label_nameSeller_value.Text = ((Organization)this.comboBox_Seller.SelectedItem).name;
                this.label_phoneSeller_value.Text = ((Organization)this.comboBox_Seller.SelectedItem).phone;
                this.label_INNSeller_value.Text = ((Organization)this.comboBox_Seller.SelectedItem).INN;
            }
        }

        private void comboBox_Leaser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Leaser.SelectedItem == null || this.comboBox_Leaser.SelectedIndex == -1)
            {
                //this.label_nameLeaser.Text = "Наименование: ";
                //this.label_phoneLeaser.Text = "Телефон: ";
                //this.label_INNLeaser.Text = "ИНН: ";

                this.label_nameLeaser_value.Text = "...";
                this.label_phoneLeaser_value.Text = "...";
                this.label_INNLeaser_value.Text = "...";
            }
            else
            {
                //this.label_nameLeaser.Text = "Наименование: " + ((Organization)this.comboBox_Leaser.SelectedItem).name;
                //this.label_phoneLeaser.Text = "Телефон: " + ((Organization)this.comboBox_Leaser.SelectedItem).phone;
                //this.label_INNLeaser.Text = "ИНН: " + ((Organization)this.comboBox_Leaser.SelectedItem).INN;

                this.label_nameLeaser_value.Text = ((Organization)this.comboBox_Leaser.SelectedItem).name;
                this.label_phoneLeaser_value.Text = ((Organization)this.comboBox_Leaser.SelectedItem).phone;
                this.label_INNLeaser_value.Text = ((Organization)this.comboBox_Leaser.SelectedItem).INN;
            }
        }

        private void button_AddRowEquipment_Click(object sender, EventArgs e)
        {
            // все поля должны быть заполнены
            if ((this.comboBox_Equipment.SelectedItem == null || this.comboBox_Equipment.SelectedIndex == -1)
                || String.IsNullOrWhiteSpace(this.textBox_Amount.Text)
                || String.IsNullOrWhiteSpace(this.numericUpDown_Cost.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля, чтобы добавить строку в таблицу", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // стоисть и кол-во - это числа + они ещё и положительные
            try 
            {
                int value = Convert.ToInt32(this.textBox_Amount.Text);

                if (value < 0)
                    throw new Exception("Negative value!");

            }
            catch
            {
                MessageBox.Show("Количество должно иметь неотрицательное целочисленное значение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Decimal value = this.numericUpDown_Cost.Value;
                if (value < 0)
                    throw new Exception("Negative value!");
            }
            catch
            {
                MessageBox.Show("Стоимость - это неотрицательное численное значение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            EquipmentGroup group = (EquipmentGroup)this.comboBox_Equipment.SelectedItem;

            // изменение строки таблицы
            if (this.button_AddRowEquipment.Text == "Применить")
            {
                this.dataGridView1.Rows[this.index_row_in_edit].Cells[0].Value = group.PK_Equipment_Group;
                this.dataGridView1.Rows[this.index_row_in_edit].Cells[1].Value = group.name;
                this.dataGridView1.Rows[this.index_row_in_edit].Cells[2].Value = this.numericUpDown_Cost.Value;
                this.dataGridView1.Rows[this.index_row_in_edit].Cells[3].Value = this.textBox_Amount.Text;
                this.dataGridView1.Rows[this.index_row_in_edit].Cells[5].Value = Convert.ToInt32(this.textBox_Amount.Text) * this.numericUpDown_Cost.Value;
                
                restore_row_data();
                this.button_AddRowEquipment.Text = "Добавить";
                this.button_RemoveEquipment.Text = "Удалить";
                return;
            }


            // добавление в таблицу    
            dataGridView1.Rows.Add(group.PK_Equipment_Group, group.name, this.numericUpDown_Cost.Text, this.textBox_Amount.Text, "шт", Convert.ToInt32(this.textBox_Amount.Text) * this.numericUpDown_Cost.Value);

        }

        private void UpdatePeriodOfUse()
        {
            DateTime start = this.dateTimePicker_DateConclusion.Value.Date;
            DateTime end = this.dateTimePicker_DateEnd.Value.Date;

            string result = "";

            int years = end.Year - start.Year;
            int months = end.Month - start.Month;

            if (months < 0)
            {
                years--;
                months = 12 + months;
            }

            result = years.ToString() + "," + months.ToString();

            this.textBox_PeriodOfUse.Text = result;

        }

        private void dateTimePicker_DateConclusion_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_DateDelivery.MinDate = this.dateTimePicker_DateConclusion.Value.Date;
            this.dateTimePicker_DateEnd.MinDate = this.dateTimePicker_DateConclusion.Value.Date;
            this.dateTimePicker_DateEnd.MaxDate = this.dateTimePicker_DateConclusion.Value.Date.AddYears(100);

            UpdatePeriodOfUse();
        }

        private bool ShowMessage(String msg)
        {
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool checkFields()
        {
            if (String.IsNullOrWhiteSpace(this.textBox_LeasingNum.Text))
                return ShowMessage("Введите номер договора!");

            if (this.comboBox_lessee.SelectedItem == null || this.comboBox_lessee.SelectedIndex == -1)
                return ShowMessage("Укажите лизингополучателя!");

            if (this.comboBox_Leaser.SelectedItem == null || this.comboBox_Leaser.SelectedIndex == -1)
                return ShowMessage("Укажите лизингодателя!");

            if (this.comboBox_Seller.SelectedItem == null || this.comboBox_Seller.SelectedIndex == -1)
                return ShowMessage("Укажите продавца!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_DaysForFirstPayment.Text))
                return ShowMessage("Укажите кол-во дней для 1-го платежа!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_DaysForReport.Text))
                return ShowMessage("Укажите кол-во дней принятия претензий!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_DaysForForceMajeure.Text))
                return ShowMessage("Укажите кол-во дней решение на форс-мажорных ситуаций!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_Penalty.Text))
                return ShowMessage("Укажите % пени!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_MaxPenalty.Text))
                return ShowMessage("Укажите максимальный % пени!");

            if (String.IsNullOrWhiteSpace(this.numericUpDown_PenaltyFee.Text))
                return ShowMessage("Укажите неустойку, в руб.!");

            if (String.IsNullOrWhiteSpace(this.textBox_PeriodOfUse.Text))
                return ShowMessage("Укажите срок использования оборудования!");

            if (String.IsNullOrWhiteSpace(this.textBox_AddressDelivery.Text))
                return ShowMessage("Укажите адрес доставки оборудования!");

            if (this.dataGridView1.Rows.Count < 1)
                return ShowMessage("Таблица оборудования, приобритаемого в лизинг не может быть пустой!");

            return true;
        }

        private bool AddLeasing()
        {
            // проверяем поля на заполненность и корректность ввода
            if (checkFields() == false)
                return false;

            this.button_Add.Enabled = this.button_AddAndClose.Enabled = false;

            // добавляем в бд договор

            LeasingContract leasingContract = new LeasingContract();
            leasingContract.contract_number = this.textBox_LeasingNum.Text;
            leasingContract.date = this.dateTimePicker_DateConclusion.Value.Date;
            leasingContract.date_end = this.dateTimePicker_DateEnd.Value.Date;
            leasingContract.date_delivery  = this.dateTimePicker_DateConclusion.Value.Date;
            leasingContract.period_of_use = this.textBox_PeriodOfUse.Text;
            leasingContract.address_delivery = this.textBox_AddressDelivery.Text;
            leasingContract.days_for_first_payment = (int)this.numericUpDown_DaysForFirstPayment.Value;
            leasingContract.days_for_report = (int)this.numericUpDown_DaysForReport.Value;
            leasingContract.penalty = this.numericUpDown_Penalty.Value;
            leasingContract.max_penalty = this.numericUpDown_MaxPenalty.Value;
            leasingContract.days_for_force_majeure = (int)this.numericUpDown_DaysForForceMajeure.Value;
            leasingContract.penalty_fee = this.numericUpDown_DaysForForceMajeure.Value;

            Program.db.LeasingContracts.Add(leasingContract);
            Program.db.SaveChanges();

            // после сохранения изменений нам доступен первичный ключ договора
            // создадим второстепенные таблицы - связь между организацией и договором
            RelationshipOrganizationLeasingContract lessee = new RelationshipOrganizationLeasingContract();
            RelationshipOrganizationLeasingContract seller = new RelationshipOrganizationLeasingContract();
            RelationshipOrganizationLeasingContract leaser = new RelationshipOrganizationLeasingContract();

            lessee.PK_Leasing_Contract = seller.PK_Leasing_Contract = leaser.PK_Leasing_Contract = leasingContract.PK_Leasing_Contract;

            lessee.PK_Organization = ((Organization)this.comboBox_lessee.SelectedItem).PK_Organization;
            lessee.PK_Role = ((Organization)this.comboBox_lessee.SelectedItem).PK_Role;

            seller.PK_Organization = ((Organization)this.comboBox_Seller.SelectedItem).PK_Organization;
            seller.PK_Role = ((Organization)this.comboBox_Seller.SelectedItem).PK_Role;

            leaser.PK_Organization = ((Organization)this.comboBox_Leaser.SelectedItem).PK_Organization;
            leaser.PK_Role = ((Organization)this.comboBox_Leaser.SelectedItem).PK_Role;

            Program.db.relationships_organization_leasing_contract.Add(lessee);
            Program.db.relationships_organization_leasing_contract.Add(seller);
            Program.db.relationships_organization_leasing_contract.Add(leaser);
            Program.db.SaveChanges();

            // далее создадим экземпляры оборудования, приобритённого в лизинг
            int count = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {  
                // 3 ячейка - это кол-во оборудования в строке
                int amount = Convert.ToInt32(row.Cells[3].Value);
                // 2 ячейка - это стоимость за ед.
                decimal cost = Convert.ToDecimal(row.Cells[2].Value);

                // 0 ячейка - это пк_группы оборудования
                int pk_group = Convert.ToInt32(row.Cells[0].Value);
                for (int i = 0; i < amount; i++)
                {
                    // создаём новый экземпляр оборудования
                    Equipment equipment = new Equipment();
                    equipment.name = row.Cells[1].Value.ToString();
                    equipment.inventory_number = "ЛИЗ-" + leasingContract.contract_number + "-" + count.ToString();
                    equipment.cost = this.numericUpDown_Cost.Value;
                    equipment.PK_Equipment_Group = pk_group;
                    equipment.serial_number = " ";
                    equipment.is_debit = false;
                    equipment.is_leasing = true;

                    Program.db.Equipments.Add(equipment);

                    count++;
                }

                RowAttachmentSpecification rowAttachmentSpecification = new RowAttachmentSpecification();
                rowAttachmentSpecification.amount = amount;
                rowAttachmentSpecification.cost = cost;
                rowAttachmentSpecification.PK_Equipment_Group = pk_group;
                rowAttachmentSpecification.PK_Leasing_Contract = leasingContract.PK_Leasing_Contract;

                Program.db.RowsAttachmentSpecification.Add(rowAttachmentSpecification);
            }
            Program.db.SaveChanges();


            MessageBox.Show("Договор за номером " + leasingContract.contract_number + " успешно создан!", "Успех!");

            this.button_Add.Enabled = this.button_AddAndClose.Enabled = true;
            return true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (AddLeasing())
            {
                this.textBox_LeasingNum.Text = "";
                this.textBox_Amount.Text = "";
                this.textBox_AddressDelivery.Text = "";
                this.numericUpDown_Cost.Value = 0;
                
                this.numericUpDown_DaysForFirstPayment.Value = 10;
                this.numericUpDown_DaysForForceMajeure.Value = 7;
                this.numericUpDown_DaysForReport.Value = 5;
                this.numericUpDown_Penalty.Value = (Decimal)(0.5);
                this.numericUpDown_MaxPenalty.Value = 5;
                this.numericUpDown_PenaltyFee.Value = 0;

                this.textBox_PeriodOfUse.Text = "3";

                this.comboBox_Workshop.SelectedItem = null;
                this.comboBox_Equipment.SelectedItem = null;

                this.dataGridView1.Rows.Clear();

                this.tabControl.SelectedIndex = 0;

            }
        }

        private void button_AddAndClose_Click(object sender, EventArgs e)
        {
            if (AddLeasing())
                this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Workshop_SelectedIndexChanged(object sender, EventArgs e)
        {

            Workshop workshop = null;
            
            if (this.comboBox_Workshop.SelectedItem == null || this.comboBox_Workshop.SelectedIndex == -1)
            {
                this.comboBox_Equipment.DataSource = null;
                this.comboBox_Equipment.SelectedItem = null;
                this.comboBox_Equipment.SelectedIndex = -1;
                return;
            }


            List<EquipmentGroup> equipmentGroups = Program.db.EquipmentGroups.Where(b => b.PK_Workshop == ((Workshop)this.comboBox_Workshop.SelectedItem).PK_Workshop).ToList();
            this.comboBox_Equipment.DataSource = equipmentGroups;
            this.comboBox_Equipment.AutoCompleteCustomSource.AddRange(equipmentGroups.Select(i => i.name).ToArray());
            this.comboBox_Equipment.SelectedIndex = -1;

            this.comboBox_Equipment.Focus();
        }

        private void comboBox_Equipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Equipment.SelectedItem == null || this.comboBox_Equipment.SelectedIndex == -1)
                return;
            this.textBox_Amount.Focus();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                index = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Выберите строку в таблице, которую нужно изменить", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (index == -1)
                return;

            this.index_row_in_edit = index;

            // сохраняем введенные данные
            save_row_data();

            // заполняем поля из таблицы

            EquipmentGroup equipmentGroupInEdit = Program.db.EquipmentGroups.Find(Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));

            this.comboBox_Workshop.SelectedItem = equipmentGroupInEdit.workshop;
            this.comboBox_Equipment.SelectedItem = equipmentGroupInEdit;
            this.textBox_Amount.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            this.numericUpDown_Cost.Value = Convert.ToDecimal(dataGridView1.Rows[index].Cells[2].Value);

            // переименовываем кнопки

            this.button_AddRowEquipment.Text = "Применить";
            this.button_RemoveEquipment.Text = "Отменить";

        }

        private void AddLeasingForm_Activated(object sender, EventArgs e)
        {
            Workshop workshop = ((Workshop)this.comboBox_Workshop.SelectedItem);
            EquipmentGroup group = ((EquipmentGroup)this.comboBox_Equipment.SelectedItem);
            Organization leaser = ((Organization)this.comboBox_Leaser.SelectedItem);
            Organization seller = ((Organization)this.comboBox_Seller.SelectedItem);



            List<Organization> leasers = Program.db.Organizations.Where(b => b.PK_Role == 2).ToList();
            this.comboBox_Leaser.DataSource = leasers;
            this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(leasers.Select(i => i.name).ToArray());
            this.comboBox_Leaser.SelectedItem = leaser;

            List<Organization> sellers = Program.db.Organizations.Where(b => b.PK_Role == 3).ToList();
            this.comboBox_Seller.DataSource = sellers;
            this.comboBox_Seller.AutoCompleteCustomSource.AddRange(sellers.Select(i => i.name).ToArray());
            this.comboBox_Seller.SelectedItem = seller;

            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedItem = workshop;


            List<EquipmentGroup> groups = Program.db.EquipmentGroups.ToList();
            this.comboBox_Equipment.DataSource = groups;
            this.comboBox_Equipment.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Equipment.SelectedItem = group;
        }

        private void dateTimePicker_DateEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdatePeriodOfUse();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Cost_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Window);
            base.OnPaint(e);
        }

        private void numericUpDown_PenaltyFee_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Window);
            base.OnPaint(e);
        }

		private void ToolStripMenuItem_File_ExitModule_Click(object sender, EventArgs e) {
            this.Close();
		}

		private void ToolStripMenuItem_File_ExitProg_Click(object sender, EventArgs e) {
            Application.Exit();
		}
	}
}
