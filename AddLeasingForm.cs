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
    }
}
