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
                MessageBox.Show(exception.Message);
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
            //updateReasonsTable();
            button_Search.PerformClick();
            dataGridView_DataSearch.ClearSelection();
        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.textBox_CipherReasonDebit.Text = "";
            this.textBox_NameReasonDebit.Text = "";
            updateReasonsTable();
            dataGridView_DataSearch.ClearSelection();
            this.textBox_CipherReasonDebit.Focus();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(this.textBox_NameReasonDebit.Text)) this.textBox_NameReasonDebit.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_CipherReasonDebit.Text)) this.textBox_CipherReasonDebit.Text = "";


            List<ReasonDebit> reasonDebits = Program.db.ReasonDebits.ToList();
            List<ReasonDebit> reasonDebitsResult = new List<ReasonDebit>();

            foreach (var item in reasonDebits)
                if (item.name.ToLower().Contains(this.textBox_NameReasonDebit.Text.ToLower())
                    && item.code.ToLower().Contains(this.textBox_CipherReasonDebit.Text.ToLower()))
                    reasonDebitsResult.Add(item);


            dataGridView_DataSearch.DataSource = reasonDebitsResult;
            dataGridView_DataSearch.ClearSelection();
            this.textBox_CipherReasonDebit.Focus();
        }

        private void button_RemoveReasonDebit_Click(object sender, EventArgs e)
        {

            // сформируем список для удаления 
            // заранее - потому что messagebox, который отвечает за подтверждение удаления (ниже)
            // вызывает событие Activated, что обновляет таблицу
            // из-за этого selectedrows сбрасывается...

            List<ReasonDebit> reasonDebitsForRemove = new List<ReasonDebit>();

            int PK_Reason_Debit = -1;
            try
            {
                foreach (DataGridViewRow row in dataGridView_DataSearch.SelectedRows)
                {
                    PK_Reason_Debit = Convert.ToInt32(row.Cells[0].Value);
                    ReasonDebit curReasonDebit = Program.db.ReasonDebits.Find(PK_Reason_Debit);

                    if (curReasonDebit != null)
                        reasonDebitsForRemove.Add(curReasonDebit);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить выбранные причны списания? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
                        

            // применим удаление
            foreach (var reason in reasonDebitsForRemove)
                Program.db.Remove(reason);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();

        }
    }
}
