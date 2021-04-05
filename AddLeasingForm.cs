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

        private Form Owner;
        public AddLeasingForm(Form owner)
        {
            InitializeComponent();

            Owner = owner;

            this.dateTimePicker_DateDelivery.MinDate = this.dateTimePicker_DateConclusion.Value.Date;

            this.comboBox_Leaser.AutoCompleteMode = this.comboBox_Seller.AutoCompleteMode = this.comboBox_Equipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Leaser.AutoCompleteSource = this.comboBox_Seller.AutoCompleteSource = this.comboBox_Equipment.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<Organization> organizations = Program.db.Organizations.ToList();
            List<Organization> leasers = new List<Organization>();
            List<Organization> sellers = new List<Organization>();

            // PK_Role = 1 - лизингополучатель
            // PK_Role = 2 - лизингодатель
            // PK_Role = 3 - Продавец
            foreach (Organization item in organizations)
            {
                if (item.PK_Role == 2) leasers.Add(item);
                if (item.PK_Role == 3) sellers.Add(item);
            }

            this.comboBox_Leaser.DataSource = leasers;
            this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(leasers.Select(i => i.name).ToArray());
            this.comboBox_Leaser.SelectedIndex = -1;

            this.comboBox_Seller.DataSource = sellers;
            this.comboBox_Seller.AutoCompleteCustomSource.AddRange(sellers.Select(i => i.name).ToArray());
            this.comboBox_Seller.SelectedIndex = -1;

            List<EquipmentGroup> equipmentGroups = Program.db.EquipmentGroups.ToList();
            this.comboBox_Equipment.DataSource = equipmentGroups;
            this.comboBox_Equipment.AutoCompleteCustomSource.AddRange(equipmentGroups.Select(i => i.name).ToArray());
            this.comboBox_Equipment.SelectedIndex = -1;

        }


        private void AddLeasingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddLeasingForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_RowOfTable_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Seller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Seller.SelectedItem == null || this.comboBox_Seller.SelectedIndex == -1)
            {
                this.label_nameSeller.Text = "Наименование: ";
                this.label_phoneSeller.Text = "Телефон: ";
                this.label_INNSeller.Text = "ИНН: ";
            }    
            else
            {
                this.label_nameSeller.Text = "Наименование: " + ((Organization)this.comboBox_Seller.SelectedItem).name;
                this.label_phoneSeller.Text = "Телефон: " + ((Organization)this.comboBox_Seller.SelectedItem).phone;
                this.label_INNSeller.Text = "ИНН: " + ((Organization)this.comboBox_Seller.SelectedItem).INN;
            }
        }

        private void comboBox_Leaser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Leaser.SelectedItem == null || this.comboBox_Leaser.SelectedIndex == -1)
            {
                this.label_nameLeaser.Text = "Наименование: ";
                this.label_phoneLeaser.Text = "Телефон: ";
                this.label_INNLeaser.Text = "ИНН: ";
            }
            else
            {
                this.label_nameLeaser.Text = "Наименование: " + ((Organization)this.comboBox_Leaser.SelectedItem).name;
                this.label_phoneLeaser.Text = "Телефон: " + ((Organization)this.comboBox_Leaser.SelectedItem).phone;
                this.label_INNLeaser.Text = "ИНН: " + ((Organization)this.comboBox_Leaser.SelectedItem).INN;
            }
        }

        private void button_AddRowEquipment_Click(object sender, EventArgs e)
        {
            // все поля должны быть заполнены
            if ((this.comboBox_Equipment.SelectedItem == null || this.comboBox_Equipment.SelectedIndex == -1)
                || String.IsNullOrWhiteSpace(this.textBox_Amount.Text)
                || String.IsNullOrWhiteSpace(this.textBox_Cost.Text))
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
                Decimal value = Convert.ToDecimal(this.textBox_Cost.Text);
                if (value < 0)
                    throw new Exception("Negative value!");
            }
            catch
            {
                MessageBox.Show("Стоимость - это неотрицательное численное значение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // добавление в таблицу
            EquipmentGroup group = (EquipmentGroup)this.comboBox_Equipment.SelectedItem;
            dataGridView1.Rows.Add(group.PK_Equipment_Group, group.name, this.textBox_Cost.Text, this.textBox_Amount.Text, "шт", Convert.ToInt32(this.textBox_Amount.Text) * Convert.ToDecimal(this.textBox_Cost.Text));


        }

        private void dateTimePicker_DateConclusion_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_DateDelivery.MinDate = this.dateTimePicker_DateConclusion.Value.Date;
        }
    }
}
