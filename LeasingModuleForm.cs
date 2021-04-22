using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using OGM.Models;

namespace OGM
{


    public partial class LeasingModuleForm : Form
    {
        private bool showOwner = true;
        private new Form Owner;

        public LeasingModuleForm(Form owner)
        {
            InitializeComponent();

            Owner = owner;
            if (((LogInForm)owner).is_fullscreen()) this.WindowState = FormWindowState.Maximized;


            this.comboBox_Leaser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Leaser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.DoubleBuffered = true;

            dataGridView_DataSearch.AutoGenerateColumns = false;
            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Leasing_Contract";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "contract_Number";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "Date";
            dataGridView_DataSearch.Columns[3].DataPropertyName = "date_end";
            dataGridView_DataSearch.Columns[4].DataPropertyName = "name";
            //dataGridView_DataSearch.Columns[3].DataPropertyName = "leaser";
            //dataGridView_DataSearch.Columns[4].DataPropertyName = "view";

        }


        private void SetTextLastColumn()
        {
            foreach (DataGridViewRow row in dataGridView_DataSearch.Rows)
                row.Cells[5].Value = "Просмотреть";
        }


        private void updateTable()
        {
            using (OGMContext db = new OGMContext())
            {
                var relationships = db.relationships_organization_leasing_contract
                    .Select(r => new { r.PK_Leasing_Contract, r.Leasing_Contract.contract_number, r.Leasing_Contract.date, r.Leasing_Contract.date_end, r.PK_Role, r.Organization.name})
                    .Where(r => r.PK_Role == 2);

                dataGridView_DataSearch.DataSource = relationships.ToList();
                SetTextLastColumn();
                dataGridView_DataSearch.ClearSelection();
            }

        }


        private void LeasingModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (showOwner)
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
            showOwner = false;

            AddLeasingForm form = new AddLeasingForm(Owner);
            this.Close();
            form.Visible = true;
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationForm().ShowDialog();
        }

		private void dataGridView_DataSearch_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex == -1) return;


            if(e.ColumnIndex == 4)
            {
                int PK_Leasing_Contract = Convert.ToInt32(this.dataGridView_DataSearch.Rows[e.RowIndex].Cells[0].Value);
                LeasingContract leasingContract = Program.db.LeasingContracts.Find(PK_Leasing_Contract);

                if (leasingContract != null)
                    new LeasingViewForm(leasingContract).ShowDialog();
			}
		}

        private void LeasingModuleForm_Activated(object sender, EventArgs e)
        {

           // this.button_Search.PerformClick();
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(this.textBox_ContractNumber.Text)) this.textBox_ContractNumber.Text = "";

            var data = new DataTable("Temp");
            data.Columns.Add("PK_Leasing_Contract", typeof(int));
            data.Columns.Add("contract_Number", typeof(string));
            data.Columns.Add("Date", typeof(DateTime));
            data.Columns.Add("date_end", typeof(DateTime));
            data.Columns.Add("name", typeof(string));

            var request = Program.db.relationships_organization_leasing_contract
                .Select(r => new { r.PK_Leasing_Contract, r.Leasing_Contract.contract_number, r.Leasing_Contract.date, r.Leasing_Contract.date_end, r.PK_Role, r.Organization.name, r.PK_Organization })
                .Where(r => r.PK_Role == 2).ToList();


            int PK_Leaser = -1;
            if (this.comboBox_Leaser.SelectedIndex != -1 && this.comboBox_Leaser.SelectedItem != null)
                PK_Leaser = ((Organization)this.comboBox_Leaser.SelectedItem).PK_Organization;




            foreach (var item in request)
            {
                if (this.dateTimePicker_DateContract_Start.Checked)
                    if (item.date < this.dateTimePicker_DateContract_Start.Value.Date)
                        continue;

                if (this.dateTimePicker_DateContract_End.Checked)
                    if (item.date > this.dateTimePicker_DateContract_End.Value.Date)
                        continue;

                if (item.contract_number.ToLower().Contains(this.textBox_ContractNumber.Text.ToLower()) == false)
                    continue;

                if (PK_Leaser != -1)
                    if (item.PK_Organization != PK_Leaser)
                        continue;

                data.Rows.Add(item.PK_Leasing_Contract, item.contract_number, item.date, item.date_end, item.name);
            }


            dataGridView_DataSearch.DataSource = data;
            SetTextLastColumn();
            dataGridView_DataSearch.ClearSelection();


        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_Leaser.SelectedIndex = -1;
            this.comboBox_Leaser.Text = "";
            this.textBox_ContractNumber.Text = "";
            this.dateTimePicker_DateContract_Start.Checked = false;
            this.dateTimePicker_DateContract_End.Checked = false;

            //updateTable(Program.db.LeasingContracts.ToList());
            updateTable();

        }

        private void LeasingModuleForm_Load(object sender, EventArgs e)
        {

            //updateTable(Program.db.LeasingContracts.ToList());
            updateTable();

            this.comboBox_Leaser.DataSource = Program.db.Organizations.Where(org => org.PK_Role == 2).ToList();
            this.comboBox_Leaser.SelectedItem = null;
        }

		private void ToolStripMenuItem_File_ExitModule_Click(object sender, EventArgs e) {
            this.Close();
		}

		private void ToolStripMenuItem_File_ExitProg_Click(object sender, EventArgs e) {
            Application.Exit();
		}
	}
}
