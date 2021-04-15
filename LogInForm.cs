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

			// если логин и пароль
			//panel_Login.Visible = true;
			//panel_ChooseModel.Visible = false;
			//textBox_Login.Text = "admin";
			//textBox_Password.Text = "admin";

			panel_Login.Visible = false;
			panel_ChooseModel.Visible = true;
			this.Text = "Выбор модуля";
		}

		public bool is_fullscreen() {
			return this.checkBox_FullScreen.Checked;
        }

		private void button_LogIn_Click(object sender, EventArgs e) {
			panel_Login.Visible = false;
			panel_ChooseModel.Visible = true;
		}


		private void button_LogOut_Click(object sender, EventArgs e) {
			// если есть логин и пароль
			//panel_Login.Visible = true;
			//panel_ChooseModel.Visible = false;

			this.Close();
		}

		private void button_Exit_Click(object sender, EventArgs e) {
			this.Close();
		}

		/* Работа по модулям */
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
		private void button_LeasingSearch_Click(object sender, EventArgs e) {
			// открытие формы LeasingModuleForm
			LeasingModuleForm form = new LeasingModuleForm(this);
			this.Hide();
			form.Visible = true;
		}
		private void button_EquipmentSearch_Click(object sender, EventArgs e) {
			// открытие формы EquipmentModuleForm
			EquipmentModuleForm form = new EquipmentModuleForm(this);
			this.Hide();
			form.Visible = true;
		}
		/* END Работа по модулям */
	}
}
