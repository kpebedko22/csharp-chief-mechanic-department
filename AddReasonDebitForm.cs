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
    public partial class AddReasonDebitForm : Form
    {

        private ReasonDebit EditReasonDebit = null;

        public AddReasonDebitForm(ReasonDebit reasonDebit = null)
        {
            InitializeComponent();

            if (reasonDebit != null)
            {
                this.Text = "Справочник - Редактировать причину списания";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";
                this.textBox_CipherReasonDebit.Text = reasonDebit.code;
                this.textBox_NameReasonDebit.Text = reasonDebit.name;

                this.EditReasonDebit = reasonDebit;
            }
        }

        // метод добавления/редактирования причины списания
        private void add_edit_reason_debit()
        {

            if (String.IsNullOrWhiteSpace(this.textBox_CipherReasonDebit.Text) || String.IsNullOrWhiteSpace(this.textBox_NameReasonDebit.Text))
            {
                MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
               

            // если добавляем
            if (this.EditReasonDebit == null)
            {          
                ReasonDebit newReasonDebit = new ReasonDebit();

                newReasonDebit.code = this.textBox_CipherReasonDebit.Text;
                newReasonDebit.name = this.textBox_NameReasonDebit.Text;

                Program.db.ReasonDebits.Add(newReasonDebit);
                MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            // редактируем
            else
            {

                this.EditReasonDebit.code = this.textBox_CipherReasonDebit.Text;
                this.EditReasonDebit.name = this.textBox_NameReasonDebit.Text;

                Program.db.ReasonDebits.Update(this.EditReasonDebit);
                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Program.db.SaveChanges();

        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            add_edit_reason_debit();
            this.textBox_CipherReasonDebit.Focus();
        }

        private void button_AddAndClose_Click(object sender, EventArgs e)
        {
            add_edit_reason_debit();
            this.Close();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
