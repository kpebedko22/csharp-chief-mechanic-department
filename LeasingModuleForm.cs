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

            dataGridView_DataSearch.Columns[0].DataPropertyName = "#";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "PK_Leasing_Contract";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "contract_number";
            dataGridView_DataSearch.Columns[3].DataPropertyName = "date";
            dataGridView_DataSearch.Columns[4].DataPropertyName = "leaser";
            dataGridView_DataSearch.Columns[5].DataPropertyName = "";

        }

        private void updateTable()
        {
            dataGridView_DataSearch.DataSource = Program.db.LeasingContracts.ToList();
            dataGridView_DataSearch.ClearSelection();
            SetIndexNums();
        }

        private void SetIndexNums()
        {
            foreach (DataGridViewRow row in this.dataGridView_DataSearch.Rows)
            {
                row.Cells[0].Value = row.Cells[0].RowIndex + 1;
                row.Cells[5].Value = "Просмотреть";
            }
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
                int PK_Leasing_Contract = Convert.ToInt32(this.dataGridView_DataSearch.Rows[e.RowIndex].Cells[1].Value);
                LeasingContract leasingContract = Program.db.LeasingContracts.Find(PK_Leasing_Contract);

                if (leasingContract != null)
                    new LeasingViewForm(leasingContract).ShowDialog();
			}
		}

        private void LeasingModuleForm_Activated(object sender, EventArgs e)
        {
            updateTable();

            List<Organization> organizations = Program.db.Organizations.ToList();
            this.comboBox_Leaser.DataSource = organizations;
            this.comboBox_Leaser.AutoCompleteCustomSource.AddRange(organizations.Select(i => i.name).ToArray());
            this.comboBox_Leaser.SelectedItem = null;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBox_ContractNumber.Text)) this.textBox_ContractNumber.Text = "";


            List<LeasingContract> leasingContracts = Program.db.LeasingContracts.ToList();
            List<LeasingContract> leasingContractsResult = new List<LeasingContract>();

            int PK_Leaser = -1;
            if (((Organization)comboBox_Leaser.SelectedItem) != null)
                PK_Leaser = ((Organization)comboBox_Leaser.SelectedItem).PK_Organization;

          

            foreach (LeasingContract item in leasingContracts)
                if (item.contract_number.ToLower().Contains(this.textBox_ContractNumber.Text.ToLower()))
                {

                    bool is_good_row = true;
                    if (PK_Leaser != -1)
                        if (item.leaser != null)
                            if (item.leaser.PK_Organization != PK_Leaser)
                                is_good_row = false;

                    if (this.dateTimePicker_DateContract.Checked == true)
                        if (item.date.Date != this.dateTimePicker_DateContract.Value.Date)
                            is_good_row = false;


                    if (is_good_row)
                        leasingContractsResult.Add(item);

                }



            dataGridView_DataSearch.DataSource = leasingContractsResult;
            SetIndexNums();
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
    }
}
