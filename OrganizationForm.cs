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

namespace OGM {
    public partial class OrganizationForm : Form {

        private List<TextBox> textBoxesOnForm;

        public OrganizationForm(){
            InitializeComponent();

            textBoxesOnForm = new List<TextBox>() {
                textBox_NameOrganiztion,
                textBox_LegalAddress,
                textBox_PostAddress,
                textBox_Phone,
                textBox_INN,
                textBox_PaymentAccount,
                textBox_Bank,
                textBox_CorrespondentAccount,
                textBox_BIK
            };

            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Organization";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "name";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "Role";

            dataGridView_DataSearch.Columns[3].DataPropertyName = "legal_address";
            dataGridView_DataSearch.Columns[4].DataPropertyName = "mailing_address";
            dataGridView_DataSearch.Columns[5].DataPropertyName = "phone";

            dataGridView_DataSearch.Columns[6].DataPropertyName = "INN";
            dataGridView_DataSearch.Columns[7].DataPropertyName = "payment_account";
            dataGridView_DataSearch.Columns[8].DataPropertyName = "bank";

            dataGridView_DataSearch.Columns[9].DataPropertyName = "correspondent_account";
            dataGridView_DataSearch.Columns[10].DataPropertyName = "BIK";

            comboBox_Role.DataSource = Program.db.Roles.ToList();
            comboBox_Role.SelectedIndex = -1;
            comboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button_AddOrganization_Click(object sender, EventArgs e){
            new AddOrganizationForm().ShowDialog();
        }

        private void updateTable() {
            dataGridView_DataSearch.DataSource = Program.db.Organizations.ToList();
        }

		private void OrganizationForm_Load(object sender, EventArgs e) {
            dataGridView_DataSearch.AutoGenerateColumns = false;
            dataGridView_DataSearch.ReadOnly = true;
        }

		private void OrganizationForm_Activated(object sender, EventArgs e) {
            button_Search.PerformClick();
            dataGridView_DataSearch.ClearSelection();
        }

		private void button_ResetSearch_Click(object sender, EventArgs e) {
            foreach (var item in textBoxesOnForm)
                item.Text = "";
            comboBox_Role.SelectedIndex = -1;

            updateTable();
            dataGridView_DataSearch.ClearSelection();
            textBox_NameOrganiztion.Focus();
        }

		private void button_Search_Click(object sender, EventArgs e) {

            List<Organization> organizations = Program.db.Organizations.ToList();

            List<Organization> organizationsResult = new List<Organization>();

            foreach (var item in organizations) {

                if (comboBox_Role.SelectedIndex != -1)
                    if (item.Role != (Role)comboBox_Role.SelectedItem) continue;

                List<string> itemParams = new List<string>() {
                    item.name.ToLower(),
                    item.legal_address.ToLower(),
                    item.mailing_address.ToLower(),
                    item.phone.ToLower(),
                    item.INN.ToLower(),
                    item.payment_account.ToLower(),
                    item.bank.ToLower(),
                    item.correspondent_account.ToLower(),
                    item.BIK.ToLower()
                };

                int numParams = itemParams.Count;
                bool checkNextItem = false;

                for (int i = 0; i < numParams; i++) {
                    if (itemParams[i].Contains(textBoxesOnForm[i].Text.ToLower())) {
                        continue;
                    }
					else {
                        checkNextItem = true;
                        break;
                    }
                }

                if (checkNextItem) continue; else organizationsResult.Add(item);
			}
            


            dataGridView_DataSearch.DataSource = organizationsResult;
            dataGridView_DataSearch.ClearSelection();
            textBox_NameOrganiztion.Focus();

        }

		private void button_ResetComboBoxRole_Click(object sender, EventArgs e) {
            comboBox_Role.SelectedIndex = -1;
		}

		private void button_EditOrganization_Click(object sender, EventArgs e) {
            int PK = -1;
            try {
                PK = Convert.ToInt32(dataGridView_DataSearch.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            Organization organization = Program.db.Organizations.Find(PK);

            if (organization != null)
                new AddOrganizationForm(organization).ShowDialog();
        }

        private void button_RemoveOrganization_Click(object sender, EventArgs e) {
            List<Organization> organizations = new List<Organization>();

            int PK = -1;
            try {
                foreach (DataGridViewRow row in dataGridView_DataSearch.SelectedRows) {
                    PK = Convert.ToInt32(row.Cells[0].Value);
                    Organization curOrganization = Program.db.Organizations.Find(PK);

                    if (curOrganization != null)
                        organizations.Add(curOrganization);
                }

            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить выбранные организации из справочника? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            // Оставим в списке те, которые можно удалить
            List<Organization> good_list = new List<Organization>();
            bool check = false; // флаг - имеются записи, которые не будут удалены
            foreach (var item in organizations)
                if (item.is_there_relationship() == false)
                    good_list.Add(item);
                else
                    check = true;


            // запрос подтверждения
            if (good_list.Count() > 0 && check)
            {
                if (MessageBox.Show("Среди выбранных организаций есть те, которые невозможно удалить, т.к. с ними уже составлен договор. \n\nУдалить организации, которые не вызвали такого конфликта?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            else if (good_list.Count() == 0 && check)
                MessageBox.Show("Невозможно выполнить удаление. С выбранными организациями заключен как минимум один договор лизинга!");


                // применим удаление
                foreach (var item in good_list)
                    Program.db.Remove(item);

            Program.db.SaveChanges();

            this.button_Search.PerformClick();
        }
	}
}
