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

    }
}
