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

            dataGridView_DataSearch[4, 0].Value = "Просмотреть";

        }

		private void LeasingModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Visible = true;
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EquipmentForm().ShowDialog();
        }

        private void группаОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupEquipmentForm().ShowDialog();
        }

        private void цехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkshopForm().ShowDialog();
        }

        private void причинаСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReasonDebitForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddLeasingForm(this).Show();
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationForm().ShowDialog();
        }

		private void dataGridView_DataSearch_CellClick(object sender, DataGridViewCellEventArgs e) {

            if(e.ColumnIndex == 4) {
                // по сути выбрать строку и открыть форму LeasingViewForm передав что-то чтоб загрузить объект из БД

                new LeasingViewForm().ShowDialog();
			}
		}
	}
}
