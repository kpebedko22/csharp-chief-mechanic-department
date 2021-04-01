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
	public partial class EquipmentModuleForm : Form {

		private Form Owner;

		public EquipmentModuleForm(Form owner) {
			InitializeComponent();

			Owner = owner;

			dataGridView_DataSearch[3, 0].Value = "Просмотреть";
		}

		private void EquipmentModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
			Owner.Visible = true;
		}

		private void ToolStripMenuItem_Add_EquipmentDebit_Click(object sender, EventArgs e) {
			this.Visible = false;
			new AddEquipmentDebitForm(this).Show();
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

	}
}
