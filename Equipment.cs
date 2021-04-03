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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();

            this.comboBox_Workshop.AutoCompleteMode = this.comboBox_GroupEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_Workshop.AutoCompleteSource = this.comboBox_GroupEquipment.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dataGridView.Columns[0].DataPropertyName = "PK_Equipment";
            dataGridView.Columns[1].DataPropertyName = "name";
            dataGridView.Columns[2].DataPropertyName = "inventory_number";
            dataGridView.Columns[3].DataPropertyName = "PK_Workshop";
            dataGridView.Columns[4].DataPropertyName = "workshop";
            dataGridView.Columns[5].DataPropertyName = "PK_Equipment_Group";
            dataGridView.Columns[6].DataPropertyName = "equipment_Group";
            dataGridView.Columns[7].DataPropertyName = "serial_number";
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddEquipment().ShowDialog();
        }

        private DataTable create_temp_table()
        {
            List<OGM.Equipment> equipments = Program.db.Equipments.ToList();


            var data = new DataTable("TempGroupEquipment");

            data.Columns.Add("PK_Equipment", typeof(int));
            data.Columns.Add("name", typeof(string));
            data.Columns.Add("inventory_number", typeof(string));
            data.Columns.Add("PK_Workshop", typeof(int));
            data.Columns.Add("workshop", typeof(string));
            data.Columns.Add("PK_Equipment_Group", typeof(int));
            data.Columns.Add("equipment_Group", typeof(string));
            data.Columns.Add("serial_number", typeof(string));

            /*
            foreach (OGM.Equipment item in equipments)
                try
                {
                    data.Rows.Add(item., item.name, item.сipher, item.PK_Workshop, Program.db.Workshops.Find(item.PK_Workshop));
                }
                catch (Exception)
                {
                    data.Rows.Add(item.PK_Equipment_Group, item.name, item.сipher, item.PK_Workshop, "Указанный цех не существует...");
                    throw;
            */

            return data;
        }

        private void Equipment_Activated(object sender, EventArgs e)
        {
            List<Workshop> workshops = Program.db.Workshops.ToList();


            dataGridView.DataSource = create_temp_table();
            dataGridView.ClearSelection();


            //dataGridView_DataSearch.DataSource = equipmentGroups;
            this.comboBox_Workshop.DataSource = workshops;

            this.comboBox_Workshop.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            this.comboBox_Workshop.SelectedItem = null;
        }
    }
}
