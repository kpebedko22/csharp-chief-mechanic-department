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
    public partial class GroupEquipmentForm : Form
    {
        public GroupEquipmentForm()
        {
            InitializeComponent();

            this.comboBox_Workshop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Workshop.AutoCompleteSource = AutoCompleteSource.CustomSource;
            

            dataGridView_DataSearch.Columns[0].DataPropertyName = "PK_Equipment_Group";
            dataGridView_DataSearch.Columns[1].DataPropertyName = "name";
            dataGridView_DataSearch.Columns[2].DataPropertyName = "сipher";
            dataGridView_DataSearch.Columns[3].DataPropertyName = "PK_Workshop";
            dataGridView_DataSearch.Columns[4].DataPropertyName = "Workshop";            
        }

        private void button_AddGroupEquipment_Click(object sender, EventArgs e)
        {
            new AddGroupEquipment().ShowDialog();
        }


        private DataTable create_temp_table()
        {
            List<EquipmentGroup> equipmentGroups = Program.db.EquipmentGroups.ToList();


            var data = new DataTable("TempGroupEquipment");

            data.Columns.Add("PK_Equipment_Group", typeof(int));
            data.Columns.Add("name", typeof(string));
            data.Columns.Add("сipher", typeof(string));
            data.Columns.Add("PK_Workshop", typeof(int));
            data.Columns.Add("Workshop", typeof(string));

            foreach (EquipmentGroup item in equipmentGroups)
                try
                {
                    data.Rows.Add(item.PK_Equipment_Group, item.name, item.сipher, item.PK_Workshop ,Program.db.Workshops.Find(item.PK_Workshop));
                }
                catch (Exception)
                {
                    data.Rows.Add(item.PK_Equipment_Group, item.name, item.сipher, item.PK_Workshop, "Указанный цех не существует...");
                    throw;
                }
               
            return data;
        }



        private void GroupEquipmentForm_Activated(object sender, EventArgs e)
        {
            List<Workshop> workshops = Program.db.Workshops.ToList();
            
            
            dataGridView_DataSearch.DataSource = create_temp_table();
            dataGridView_DataSearch.ClearSelection();


            //dataGridView_DataSearch.DataSource = equipmentGroups;
            this.comboBox_Workshop.DataSource = workshops;
            
            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedItem = null;
        }

        private void button_EditGroupEquipment_Click(object sender, EventArgs e)
        {
            int PK_Group_Equipment = -1;
            try
            {
                PK_Group_Equipment = Convert.ToInt32(dataGridView_DataSearch.SelectedRows[0].Cells[1].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            EquipmentGroup equipmentGroup = Program.db.EquipmentGroups.Find(PK_Group_Equipment);

            if (equipmentGroup != null)
                new AddGroupEquipment(equipmentGroup).ShowDialog();


        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DataTable table = create_temp_table();
            DataTable tableresult = new DataTable();
            tableresult.Columns.Add("PK_Equipment_Group", typeof(int));
            tableresult.Columns.Add("name", typeof(string));
            tableresult.Columns.Add("сipher", typeof(string));
            tableresult.Columns.Add("PK_Workshop", typeof(int));
            tableresult.Columns.Add("Workshop", typeof(string));



            foreach (DataRow item in table.Rows)
            {

                if (item.ItemArray[1].ToString().Contains(this.textBox_NameEquipment.Text)
                     && item.ItemArray[2].ToString().Contains(this.textBox_Сipher.Text)
                     && item.ItemArray[4].ToString().Contains(this.comboBox_Workshop.Text))
                    tableresult.Rows.Add(item.ItemArray[0], item.ItemArray[1], item.ItemArray[2], item.ItemArray[3], item.ItemArray[4]);
            }



            dataGridView_DataSearch.DataSource = tableresult;
            dataGridView_DataSearch.ClearSelection();
            this.comboBox_Workshop.Focus();
        }

        private void button_ResetSearch_Click(object sender, EventArgs e)
        {
            this.textBox_NameEquipment.Text = "";
            this.textBox_Сipher.Text = "";
            this.comboBox_Workshop.SelectedItem = null;
            dataGridView_DataSearch.DataSource = create_temp_table();
            dataGridView_DataSearch.ClearSelection();
            this.comboBox_Workshop.Focus();
        }

        private void button_RemoveGroupEquipment_Click(object sender, EventArgs e)
        {
            // сформируем список для удаления 
            // заранее - потому что messagebox, который отвечает за подтверждение удаления (ниже)
            // вызывает событие Activated, что обновляет таблицу
            // из-за этого selectedrows сбрасывается...

            List<EquipmentGroup> EquipmentGroupsForRemove = new List<EquipmentGroup>();

            int PK_EquipmentGroup = -1;
            try
            {
                foreach (DataGridViewRow row in dataGridView_DataSearch.SelectedRows)
                {
                    PK_EquipmentGroup = Convert.ToInt32(row.Cells[1].Value);
                    EquipmentGroup curEquipmentGroup = Program.db.EquipmentGroups.Find(PK_EquipmentGroup);

                    if (curEquipmentGroup != null)
                        EquipmentGroupsForRemove.Add(curEquipmentGroup);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            // запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить выбранные цеха? Данное действие нельзя будет отменить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            // применим удаление
            foreach (var workshop in EquipmentGroupsForRemove)
                Program.db.Remove(workshop);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }
    }
}
