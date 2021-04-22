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
    public partial class AddOrganizationForm : Form{

        private Organization EditOrganization = null;

        private List<TextBox> textBoxesOnForm;

        public AddOrganizationForm(Organization editOrganization=null, bool read_only=false) {
            InitializeComponent();

            comboBox_Role.DataSource = Program.db.Roles.ToList();
            comboBox_Role.SelectedIndex = -1;
            comboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

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

            if (editOrganization != null) {
                List<string> itemParams = new List<string>() {
                    editOrganization.name,
                    editOrganization.legal_address,
                    editOrganization.mailing_address,
                    editOrganization.phone,
                    editOrganization.INN,
                    editOrganization.payment_account,
                    editOrganization.bank,
                    editOrganization.correspondent_account,
                    editOrganization.BIK
                };

                int numParams = itemParams.Count;
                for (int i = 0; i < numParams; i++)
                    textBoxesOnForm[i].Text = itemParams[i];

                comboBox_Role.SelectedItem = editOrganization.Role;

                this.Text = "Справочник - Редактировать организацию";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";

                EditOrganization = editOrganization;
            }

            if (read_only)
            {

                foreach (TextBox item in textBoxesOnForm)
                    item.ReadOnly = true;

                this.comboBox_Role.Enabled = false;

                this.Text = "Справочник - Просмотреть организацию";
                this.button_Add.Visible = false;
                this.button_AddAndClose.Visible = false;
                this.button_Close.Text = "Закрыть";
            }
        }

        private bool AddOrEdit() {

            // проверка заполнения всех полей
            foreach(var item in textBoxesOnForm)
                if (String.IsNullOrWhiteSpace(item.Text)) {
                    MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            // добавление
            if (EditOrganization == null) {
                Organization organization = new Organization();

                organization.name = textBox_NameOrganiztion.Text;
                organization.legal_address = textBox_LegalAddress.Text;
                organization.mailing_address = textBox_PostAddress.Text;
                organization.phone = textBox_Phone.Text;
                organization.INN = textBox_INN.Text;
                organization.payment_account = textBox_PaymentAccount.Text;
                organization.bank = textBox_Bank.Text;
                organization.correspondent_account = textBox_CorrespondentAccount.Text;
                organization.BIK = textBox_BIK.Text;

                Role role = (Role)comboBox_Role.SelectedItem;
                organization.PK_Role = role.PK_Role;

                Program.db.Organizations.Add(organization);

                MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // редактирование
			else {

                EditOrganization.name = textBox_NameOrganiztion.Text;
                EditOrganization.legal_address = textBox_LegalAddress.Text;
                EditOrganization.mailing_address = textBox_PostAddress.Text;
                EditOrganization.phone = textBox_Phone.Text;
                EditOrganization.INN = textBox_INN.Text;
                EditOrganization.payment_account = textBox_PaymentAccount.Text;
                EditOrganization.bank = textBox_Bank.Text;
                EditOrganization.correspondent_account = textBox_CorrespondentAccount.Text;
                EditOrganization.BIK = textBox_BIK.Text;

                Role role = (Role)comboBox_Role.SelectedItem;
                EditOrganization.PK_Role = role.PK_Role;

                Program.db.Organizations.Update(EditOrganization);

                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // сохранение изменений в БД
            Program.db.SaveChanges();
            return true;
        }

		private void button_Add_Click(object sender, EventArgs e) {
            AddOrEdit();
            textBox_NameOrganiztion.Focus();
		}

		private void button_AddAndClose_Click(object sender, EventArgs e) {
            if (AddOrEdit())
                this.Close();
		}

		private void button_Close_Click(object sender, EventArgs e) {
            this.Close();
		}
	}
}
