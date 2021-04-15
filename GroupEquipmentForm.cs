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
            // сохраним выбор
            Workshop selected_wrokshop = ((Workshop)this.comboBox_Workshop.SelectedItem);
            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox_Workshop.DataSource = workshops;
            // восстановим выбор
            if (selected_wrokshop != null && workshops.Contains(selected_wrokshop))
                this.comboBox_Workshop.SelectedItem = selected_wrokshop;
            else
                this.comboBox_Workshop.SelectedItem = null;

            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());

            if (selected_wrokshop == null)
                dataGridView_DataSearch.DataSource = Program.db.EquipmentGroups.ToList();
            else 
                button_Search.PerformClick();

            dataGridView_DataSearch.ClearSelection();
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




            // Оставим в списке те, которые можно удалить
            List<EquipmentGroup> good_list = new List<EquipmentGroup>();
            bool check = false; // флаг - имеются записи, которые не будут удалены
            foreach (var item in EquipmentGroupsForRemove)
                if (item.is_there_relationships() == false)
                    good_list.Add(item);
                else
                    check = true;


            // запрос подтверждения
            if (good_list.Count() > 0 && check)
            {
                if (MessageBox.Show("Среди выбранных групп оборудования есть те, которые невозможно удалить! \n\nПричины могут быть следующие\n в группе имеется в себе оборудование;\n группа указана хотя бы в одном акте списания;\n группа указана хотя бы в одном договоре лизинга. \nУдалить группы оборудования, которые не вызвали такого конфликта?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            else if (good_list.Count() == 0 && check)
                MessageBox.Show("Невозможно выполнить удаление.\n\nПричины могут быть следующие\n в группе имеется в себе оборудование;\n группа указана хотя бы в одном акте списания;\n группа указана хотя бы в одном договоре лизинга.");


            // применим удаление
            foreach (var equipmentGroup in good_list)
                Program.db.Remove(equipmentGroup);


            Program.db.SaveChanges();


            this.button_Search.PerformClick();
        }


    }
}
