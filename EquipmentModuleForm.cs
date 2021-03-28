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
		}

		private void EquipmentModuleForm_FormClosed(object sender, FormClosedEventArgs e) {
			Owner.Visible = true;
		}
	}
}
