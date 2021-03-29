using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGM
{
    public partial class LeasingModuleForm : Form
    {

        private Form Owner;

        public LeasingModuleForm(Form owner)
        {
            InitializeComponent();

            Owner = owner;

            dataGridView1[4, 0].Value = "Просмотреть";

        }

		private void LeasingModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Visible = true;
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Equipment().ShowDialog();
        }

        private void группаОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupEquipmentForm().ShowDialog();
        }
    }
}
