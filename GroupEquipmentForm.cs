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
            data.Columns.Add("name", typeof(string));
            data.Columns.Add("сipher", typeof(string));
            data.Columns.Add("Workshop", typeof(string));

            foreach (EquipmentGroup item in equipmentGroups)
                try
                {
                    data.Rows.Add(item.name, item.сipher, Program.db.Workshops.Find(item.PK_Workshop));
                }
                catch (Exception)
                {
                    data.Rows.Add(item.name, item.сipher, "Указанный цех не существует...");
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
        }
    }
}
