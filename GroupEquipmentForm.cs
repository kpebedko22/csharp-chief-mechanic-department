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



        private void GroupEquipmentForm_Activated(object sender, EventArgs e)
        {
            dataGridView_DataSearch.DataSource = Program.db.EquipmentGroups.ToList();
            dataGridView_DataSearch.ClearSelection();

            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            
            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedItem = null;
        }

        private void button_EditGroupEquipment_Click(object sender, EventArgs e)
        {
            int PK_Group_Equipment = -1;
            try
            {
                PK_Group_Equipment = Convert.ToInt32(dataGridView_DataSearch.SelectedRows[0].Cells[0].Value);
            }
            catch 
            {
                MessageBox.Show("Выбранная запись отсутствует в таблице!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            EquipmentGroup equipmentGroup = Program.db.EquipmentGroups.Find(PK_Group_Equipment);

            if (equipmentGroup != null)
                new AddGroupEquipment(equipmentGroup).ShowDialog();


        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBox_NameEquipment.Text)) this.textBox_NameEquipment.Text = "";
            if (String.IsNullOrWhiteSpace(this.textBox_Сipher.Text)) this.textBox_Сipher.Text = "";

            List<EquipmentGroup> table = Program.db.EquipmentGroups.ToList();
            List<EquipmentGroup> tableresult = new List<EquipmentGroup>();

            int PK_Workshop = -1;
            if (this.comboBox_Workshop.SelectedItem != null)
                PK_Workshop = ((Workshop)this.comboBox_Workshop.SelectedItem).PK_Workshop;


            foreach (EquipmentGroup item in table)
                if (item.name.ToLower().Contains(this.textBox_NameEquipment.Text.ToLower())
                     && item.сipher.ToLower().Contains(this.textBox_Сipher.Text.ToLower()))
                {

                    if (PK_Workshop != -1)
                    {
                        if (item.PK_Workshop == PK_Workshop)
                            tableresult.Add(item);
                    }
                    else
                        tableresult.Add(item);
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
            dataGridView_DataSearch.DataSource = Program.db.EquipmentGroups.ToList();
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
                    PK_EquipmentGroup = Convert.ToInt32(row.Cells[0].Value);
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
            foreach (var equipmentGroup in EquipmentGroupsForRemove)
                Program.db.Remove(equipmentGroup);

            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }


    }
}
