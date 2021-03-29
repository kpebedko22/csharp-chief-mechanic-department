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
    public partial class WorkshopForm : Form
    {
        public WorkshopForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddWorkshopForm().ShowDialog();
        }
    }
}
