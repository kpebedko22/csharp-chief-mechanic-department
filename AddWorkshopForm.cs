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
    public partial class AddWorkshopForm : Form
    {
        private Workshop EditWorkshop = null;

        public AddWorkshopForm(Workshop workshop = null)
        {
            InitializeComponent();

            if (workshop != null)
            {
                this.Text = "Справочник - Редактировать цех";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";
                this.textBox_NameWorkshop.Text = workshop.name;
                this.textBox_PhoneWorkshop.Text = workshop.phone_number;
                this.textBox_Email.Text = workshop.email;

                this.EditWorkshop = workshop;
            }
        }


        private void add_edit_workshop()
        {

            if (String.IsNullOrWhiteSpace(this.textBox_Email.Text) 
                || String.IsNullOrWhiteSpace(this.textBox_NameWorkshop.Text)
                || String.IsNullOrWhiteSpace(this.textBox_PhoneWorkshop.Text))
            {
                MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // если добавляем
            if (this.EditWorkshop == null)
            {
                Workshop newWorkshop = new Workshop();

                newWorkshop.name = this.textBox_NameWorkshop.Text;
                newWorkshop.phone_number = this.textBox_PhoneWorkshop.Text;
                newWorkshop.email = this.textBox_Email.Text;

                Program.db.Workshops.Add(newWorkshop);
                MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            // редактируем
            else
            {

                this.EditWorkshop.name = this.textBox_NameWorkshop.Text;
                this.EditWorkshop.phone_number = this.textBox_PhoneWorkshop.Text;
                this.EditWorkshop.email = this.textBox_Email.Text;

                Program.db.Workshops.Update(this.EditWorkshop);
                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Program.db.SaveChanges();

        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            add_edit_workshop();
        }

        private void button_AddAndClose_Click(object sender, EventArgs e)
        {
            add_edit_workshop();
            this.Close();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
