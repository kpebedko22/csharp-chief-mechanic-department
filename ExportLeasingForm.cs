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
    public partial class ExportLeasingForm : Form
    {
        public ExportLeasingForm()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportLeasingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Введенные данные будут несохранены. Вы уверены, что хотите отменить экспорт договора ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
