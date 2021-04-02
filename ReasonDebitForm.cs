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
    public partial class ReasonDebitForm : Form
    {
        public ReasonDebitForm()
        {
            InitializeComponent();
            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Reason_Debit";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "code";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "name";
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddReasonDebitForm().ShowDialog();
        }

        private void button_EditReasonDebit_Click(object sender, EventArgs e)
        {
            int PK_Reason_Debit = -1;
            try
            {
                PK_Reason_Debit = Convert.ToInt32(dataGridView_DataSearch.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception exception)
            {

            }

            ReasonDebit reasonDebit = Program.db.ReasonDebits.Find(PK_Reason_Debit);

            if (reasonDebit != null)
                new AddReasonDebitForm(reasonDebit).ShowDialog();
        }

        private void ReasonDebitForm_Load(object sender, EventArgs e)
        {
            dataGridView_DataSearch.AutoGenerateColumns = false;
            dataGridView_DataSearch.ReadOnly = true;
        }


        private void updateReasonsTable()
        {
            List<ReasonDebit> reasonDebits = Program.db.ReasonDebits.ToList();
            dataGridView_DataSearch.DataSource = reasonDebits;
        }

        private void ReasonDebitForm_Activated(object sender, EventArgs e)
        {
            updateReasonsTable();
        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.textBox_CipherReasonDebit.Text = "";
            this.textBox_NameReasonDebit.Text = "";
            updateReasonsTable();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            List<ReasonDebit> reasonDebits = Program.db.ReasonDebits.ToList();

            List<ReasonDebit> reasonDebitsResult = new List<ReasonDebit>();

            foreach (var item in reasonDebits)
                if (item.name.Contains(this.textBox_NameReasonDebit.Text) && item.code.Contains(this.textBox_CipherReasonDebit.Text))
                    reasonDebitsResult.Add(item);


            dataGridView_DataSearch.DataSource = reasonDebitsResult;
        }
    }
}
