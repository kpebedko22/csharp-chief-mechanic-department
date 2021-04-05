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
    public partial class LeasingModuleForm : Form
    {

        private Form Owner;

        public LeasingModuleForm(Form owner)
        {
            InitializeComponent();

            Owner = owner;

            dataGridView_DataSearch.AutoGenerateColumns = false;

            this.comboBox_Leaser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Leaser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.DoubleBuffered = true;


            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Leasing_Contract";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "contract_number";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "date";
            dataGridView_DataSearch.Columns[3].DataPropertyName = "leaser";
            dataGridView_DataSearch.Columns[4].DataPropertyName = "view";

        }

        private void updateTable()
        {
            List<LeasingContract> contracts = Program.db.LeasingContracts.ToList();
            dataGridView_DataSearch.DataSource = contracts;
            dataGridView_DataSearch.ClearSelection();
        }



		private void LeasingModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Visible = true;
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EquipmentForm().ShowDialog();
        }

        private void группаОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupEquipmentForm().ShowDialog();
        }

        private void цехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkshopForm().ShowDialog();
        }

        private void причинаСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReasonDebitForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddLeasingForm(this).Show();
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationForm().ShowDialog();
        }

		private void dataGridView_DataSearch_CellClick(object sender, DataGridViewCellEventArgs e) {

            if(e.ColumnIndex == 5)
            {
                int PK_Leasing_Contract = Convert.ToInt32(this.dataGridView_DataSearch.Rows[e.RowIndex].Cells[0].Value);
                LeasingContract leasingContract = Program.db.LeasingContracts.Find(PK_Leasing_Contract);

                if (leasingContract != null)
                    new LeasingViewForm(leasingContract).ShowDialog();
			}
		}

        private void LeasingModuleForm_Activated(object sender, EventArgs e)
        {
           // updateTable();

            //List<Organization> organizations = Program.db.Organizations.ToList();
            //this.comboBox_Leaser.DataSource = organizations;
            //this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(organizations.Select(i => i.name).ToArray());
            //this.comboBox_Leaser.SelectedItem = null;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBox_ContractNumber.Text)) this.textBox_ContractNumber.Text = "";



            List<LeasingContract> leasingContracts = null;
            List<LeasingContract> leasingContractsResult = new List<LeasingContract>();

            if (((Organization)comboBox_Leaser.SelectedItem) != null)
            {
                int PK_Leaser = ((Organization)comboBox_Leaser.SelectedItem).PK_Organization;
                leasingContracts = Program.db.LeasingContracts.Where(b => b.leaser.PK_Organization == PK_Leaser).ToList();
            }
            else
                leasingContracts = Program.db.LeasingContracts.ToList();


            if (this.dateTimePicker_DateContract.Checked || !String.IsNullOrWhiteSpace(this.textBox_ContractNumber.Text))
            {
                foreach (LeasingContract item in leasingContracts)
                    if (item.contract_number.ToLower().Contains(this.textBox_ContractNumber.Text.ToLower()))
                    {

                        if (this.dateTimePicker_DateContract.Checked == true)
                            if (item.date.Date != this.dateTimePicker_DateContract.Value.Date)
                                continue;

                        leasingContractsResult.Add(item);

                    }
                dataGridView_DataSearch.DataSource = leasingContractsResult;
            }



            dataGridView_DataSearch.DataSource = leasingContracts;
            dataGridView_DataSearch.ClearSelection();

        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_Leaser.SelectedIndex = -1;
            this.comboBox_Leaser.Text = "";
            this.textBox_ContractNumber.Text = "";
            this.dateTimePicker_DateContract.Checked = false;

            updateTable();

        }

        private void LeasingModuleForm_Load(object sender, EventArgs e)
        {

            updateTable();

            List<Organization> organizations = Program.db.Organizations.ToList();
            this.comboBox_Leaser.DataSource = organizations;
            this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(organizations.Select(i => i.name).ToArray());
            this.comboBox_Leaser.SelectedItem = null;
        }
    }
}
