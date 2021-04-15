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
    public partial class WorkshopForm : Form
    {
        public WorkshopForm()
        {
            InitializeComponent();
            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Workshop";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "name";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "phone_number";
            dataGridView_DataSearch.Columns[3].DataPropertyName = "email";
        }

        private void updateTable()
        {
            List<Workshop> workshops = Program.db.Workshops.ToList();
            dataGridView_DataSearch.DataSource = workshops;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBox_Email.Text)) this.textBox_Email.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_NameWorkshop.Text)) this.textBox_NameWorkshop.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_PhoneWorkshop.Text)) this.textBox_PhoneWorkshop.Text = "";

            List<Workshop> workshops = Program.db.Workshops.ToList();
            List<Workshop> workshopsResult = new List<Workshop>();


            foreach (var item in workshops)

                if (item.name.ToLower().Contains(this.textBox_NameWorkshop.Text.ToLower()) 
                && item.phone_number.ToLower().Contains(this.textBox_PhoneWorkshop.Text.ToLower())
                && item.email.ToLower().Contains(this.textBox_Email.Text.ToLower()))

                    workshopsResult.Add(item);


            dataGridView_DataSearch.DataSource = workshopsResult;
            dataGridView_DataSearch.ClearSelection();
            this.textBox_NameWorkshop.Focus();
        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.textBox_Email.Text = "";
            this.textBox_NameWorkshop.Text = "";
            this.textBox_PhoneWorkshop.Text = "";
            updateTable();
            dataGridView_DataSearch.ClearSelection();
            this.textBox_NameWorkshop.Focus();
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddWorkshopForm().ShowDialog();
        }

        private void button_EditEquipment_Click(object sender, EventArgs e)
        {
            int PK_Workshop = -1;
            try
            {
                PK_Workshop = Convert.ToInt32(dataGridView_DataSearch.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            Workshop workshop = Program.db.Workshops.Find(PK_Workshop);

            if (workshop != null)
                new AddWorkshopForm(workshop).ShowDialog();
        }


        private void WorkshopForm_Activated(object sender, EventArgs e)
        {
            //updateTable();
            button_Search.PerformClick();
            dataGridView_DataSearch.ClearSelection();
        }

        private void button_RemoveEquipment_Click(object sender, EventArgs e)
        {
            // сформируем список для удаления 
            // заранее - потому что messagebox, который отвечает за подтверждение удаления (ниже)
            // вызывает событие Activated, что обновляет таблицу
            // из-за этого selectedrows сбрасывается...

            List<Workshop> workshopsForRemove = new List<Workshop>();

            int PK_Workshop = -1;
            try
            {
                foreach (DataGridViewRow row in dataGridView_DataSearch.SelectedRows)
                {
                    PK_Workshop = Convert.ToInt32(row.Cells[0].Value);
                    Workshop curWorkshop = Program.db.Workshops.Find(PK_Workshop);

                    if (curWorkshop != null)
                        workshopsForRemove.Add(curWorkshop);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить выбранные цеха? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            // Оставим в списке те, которые можно удалить
            List<Workshop> good_list = new List<Workshop>();
            bool check = false; // флаг - имеются записи, которые не будут удалены
            foreach (var item in workshopsForRemove)
                if (item.is_there_group() == false)
                    good_list.Add(item);
                else
                    check = true;


            // запрос подтверждения
            if (good_list.Count() > 0 && check)
            {
                if (MessageBox.Show("Среди выбранных цехов есть те, которые невозможно удалить, т.к. имеются группы оборудования для данных цехов. \n\nУдалить цеха, которые не вызвали такого конфликта?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            else if (good_list.Count() == 0 && check)
                MessageBox.Show("Невозможно выполнить удаление. В выбранных цехах имеются группы оборудования!");


            // применим удаление
            foreach (var workshop in good_list)
                Program.db.Remove(workshop);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }
    }
}
