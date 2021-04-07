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
	public partial class LogInForm : Form {
		public LogInForm() {
			InitializeComponent();

			panel_Login.Visible = true;
			panel_ChooseModel.Visible = false;

			textBox_Login.Text = "admin";
			textBox_Password.Text = "admin";
		}

		private void button_LogIn_Click(object sender, EventArgs e) {
			panel_Login.Visible = false;
			panel_ChooseModel.Visible = true;
		}

		private void button_Leasing_Click(object sender, EventArgs e) {
			AddLeasingForm form = new AddLeasingForm(this);
			this.Hide();
			form.Visible = true;
		}

		private void button_Equipment_Click(object sender, EventArgs e) {
			AddEquipmentDebitForm form = new AddEquipmentDebitForm(this);
			this.Hide();
			form.Visible = true;
		}

		private void button_LogOut_Click(object sender, EventArgs e) {
			panel_Login.Visible = true;
			panel_ChooseModel.Visible = false;
		}

		private void button_Exit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void button_LeasingSearch_Click(object sender, EventArgs e) {
			// открытие формы LeasingModuleForm
			LeasingModuleForm form = new LeasingModuleForm(this);
			//AddLeasingForm form = new AddLeasingForm(this);
			this.Hide();
			form.Visible = true;
		}

		private void button_EquipmentSearch_Click(object sender, EventArgs e) {
			// открытие формы EquipmentModuleForm
			EquipmentModuleForm form = new EquipmentModuleForm(this);
			//AddEquipmentDebitForm form = new AddEquipmentDebitForm(this);
			this.Hide();
			form.Visible = true;
		}
	}
}
