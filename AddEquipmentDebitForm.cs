using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGM {
	public partial class AddEquipmentDebitForm : Form {

		private Form Owner;

		public AddEquipmentDebitForm(Form owner) {
			InitializeComponent();

			Owner = owner;
		}

		private void AddEquipmentDebitForm_FormClosed(object sender, FormClosedEventArgs e) {
			Owner.Visible = true;
		}

		private void ToolStripMenuItem_Equipment_Handbook_Click(object sender, EventArgs e) {
			new Equipment().ShowDialog();
		}

		private void ToolStripMenuItem_GroupEquipment_Handbook_Click(object sender, EventArgs e) {
			new GroupEquipmentForm().ShowDialog();
		}

		private void ToolStripMenuItem_Workshop_Handbook_Click(object sender, EventArgs e) {
			new WorkshopForm().ShowDialog();
		}

		private void ToolStripMenuItem_Organization_Handbook_Click(object sender, EventArgs e) {
			new OrganizationForm().ShowDialog();
		}

		private void ToolStripMenuItem_ReasonDebit_Handbook_Click(object sender, EventArgs e) {
			new ReasonDebitForm().ShowDialog();
		}

        private void checkBox_AllGroupDebit_CheckedChanged(object sender, EventArgs e)
        {
			comboBox_Equipment.Enabled = !checkBox_AllGroupDebit.Checked;

			button_Debit.Text = checkBox_AllGroupDebit.Checked ? "Списать всю группу" : "Списать";

		}

		private void ToolStripMenuItem_Find_EquipmentDebit_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
