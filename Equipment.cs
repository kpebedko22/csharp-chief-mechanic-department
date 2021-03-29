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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();

            dataGridView[5, 0].Value = "Просмотреть??";
        }

        private void button_AddEquipment_Click(object sender, EventArgs e)
        {
            new AddEquipment().ShowDialog();
        }
    }
}
