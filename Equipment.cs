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
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddEquipment().ShowDialog();
        }

        private void Equipment_Activated(object sender, EventArgs e)
        {
            List<Workshop> workshops = Program.db.Workshops.ToList();
            //List<Workshop> groups = Program.db.GroupsEquipment.ToList();
            //List<Workshop> equipments = Program.db.Equipments.ToList();


            //dataGridView.DataSource = workshops;
            this.comboBox_Workshop.DataSource = workshops;
        }
    }
}
