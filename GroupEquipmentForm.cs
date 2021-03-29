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
    public partial class GroupEquipmentForm : Form
    {
        public GroupEquipmentForm()
        {
            InitializeComponent();
        }

        private void button_AddGroupEquipment_Click(object sender, EventArgs e)
        {
            new AddGroupEquipment().ShowDialog();
        }
    }
}
