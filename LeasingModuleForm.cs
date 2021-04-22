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

            //DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView_DataSearch.Columns[4];
            //c.FlatStyle = FlatStyle.System;
            //c.DefaultCellStyle.BackColor = Color.LightGray;

           

            //dataGridView_DataSearch.Columns[3].DataPropertyName = "leaser";
            //dataGridView_DataSearch.Columns[4].DataPropertyName = "view";



            this.comboBox_before_end.SelectedIndex = 0;
            this.comboBox_before_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }




        private void updateTable()
        {
            using (OGMContext db = new OGMContext())
            {
                var relationships = db.relationships_organization_leasing_contract
                    .Select(r => new { r.PK_Leasing_Contract, r.Leasing_Contract.contract_number, r.Leasing_Contract.date, r.Leasing_Contract.date_end, r.PK_Role, r.Organization.name})
                    .Where(r => r.PK_Role == 2);

                dataGridView_DataSearch.DataSource = relationships.ToList();
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

            if (e.ColumnIndex == 4)
            {
                // выбираем строку
                int PK_LeasingContract = -1;
                try
                {
                    PK_LeasingContract = Convert.ToInt32(this.dataGridView_DataSearch.Rows[e.RowIndex].Cells[0].Value);

                    if (PK_LeasingContract == -1)
                        throw new Exception();

                    RelationshipOrganizationLeasingContract r_leasingContract = null;
                    using (OGMContext db = new OGMContext())
                    {
                        r_leasingContract = db.relationships_organization_leasing_contract
                            .Where(r => r.PK_Role == 2 && r.PK_Leasing_Contract == PK_LeasingContract)
                            .FirstOrDefault();
                    }

                    if (r_leasingContract == null)
                        throw new Exception();

                    new AddOrganizationForm(r_leasingContract.Organization, true).ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть информацию о лизингодателе", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


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

            using (OGMContext db = new OGMContext())
            {

                var request = db.relationships_organization_leasing_contract
                    .Select(r => new { r.PK_Leasing_Contract, r.Leasing_Contract.contract_number, r.Leasing_Contract.date, r.Leasing_Contract.date_end, r.PK_Role, r.Organization.name, r.PK_Organization })
                    .Where(r => r.PK_Role == 2).ToList();


                int PK_Leaser = -1;
                if (this.comboBox_Leaser.SelectedIndex != -1 && this.comboBox_Leaser.SelectedItem != null)
                    PK_Leaser = ((Organization)this.comboBox_Leaser.SelectedItem).PK_Organization;



                bool before_end = this.radioButton_before_end.Checked;
                bool after_end = this.radioButton_after_end.Checked;

                DateTime somedate = DateTime.Now.Date;

                int index_before_end = this.comboBox_before_end.SelectedIndex;

                // смещение даты
                if (before_end)
                {
                    switch (index_before_end)
                    {
                        case 0:
                            break;

                        case 1:
                            somedate = somedate.AddDays(7);
                            break;

                        case 2:
                            somedate = somedate.AddMonths(1);
                            break;

                        case 3:
                            somedate = somedate.AddMonths(3);
                            break;

                        case 4:
                            somedate = somedate.AddMonths(6);
                            break;

                        case 5:
                            somedate = somedate.AddYears(1);
                            break;

                        default:
                            break;
                    }
                }


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

                    if (before_end)
                    {
                        if ((item.date_end > somedate && index_before_end != -1 && index_before_end != 0) || item.date_end < DateTime.Now.Date)
                            continue;
                        else
                        {
                            if (index_before_end == 0)
                                if (item.date_end < DateTime.Now.Date)
                                    continue;
                        }
                    }


                    if (after_end)
                        if (item.date_end >= somedate)
                            continue;

                    data.Rows.Add(item.PK_Leasing_Contract, item.contract_number, item.date, item.date_end, item.name);
                }


                dataGridView_DataSearch.DataSource = data;
                dataGridView_DataSearch.ClearSelection();
            }

        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_Leaser.SelectedIndex = -1;
            this.comboBox_Leaser.Text = "";
            this.textBox_ContractNumber.Text = "";
            this.dateTimePicker_DateContract_Start.Checked = false;
            this.dateTimePicker_DateContract_End.Checked = false;
            this.radioButton_all.Checked = true;

            //updateTable(Program.db.LeasingContracts.ToList());
            //updateTable();
            dataGridView_DataSearch.DataSource = null;

        }

        private void LeasingModuleForm_Load(object sender, EventArgs e)
        {

            //updateTable(Program.db.LeasingContracts.ToList());
            // updateTable();

            this.comboBox_Leaser.DataSource = Program.db.Organizations.Where(org => org.PK_Role == 2).ToList();
            this.comboBox_Leaser.SelectedItem = null;
        }

		private void ToolStripMenuItem_File_ExitModule_Click(object sender, EventArgs e) {
            this.Close();
		}

		private void ToolStripMenuItem_File_ExitProg_Click(object sender, EventArgs e) {
            Application.Exit();
		}

        private void radioButton_before_end_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox_before_end.Enabled = this.radioButton_before_end.Checked;
        }

        private void button_leaser_info_Click(object sender, EventArgs e)
        {




            

        }

        private void dataGridView_DataSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == -1) return;
            ((DataGridView)sender).Rows[e.RowIndex].Cells[5].Value = "Просмотреть";
        }
    }
}
