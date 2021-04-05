using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OGM.Models;

namespace OGM {
	public partial class DebitViewForm : Form {

		private ActDebit ActDebit = null;

		string rtfActDebit = null;

		public DebitViewForm(ActDebit actDebit) {
			InitializeComponent();

			ActDebit = actDebit;

			label_ActDebitNum.Text = "Акт списания оборудования №" + ActDebit.act_number;


			OpenDocument();
		}

		private void OpenDocument() {
			//act_debit_template.rtf

			string path = Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_template.rtf";

			richTextBox_ActDebit.LoadFile(path);

			richTextBox_ActDebit.Find("[<номер_акта>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<номер_акта>]", ActDebit.act_number);

			string d = "«" + ActDebit.date.Day + "» " + ActDebit.date.ToString("MMMM").ToLower() + " " + ActDebit.date.Year + "г.";
			richTextBox_ActDebit.Find("[<дата_списания>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<дата_списания>]", d);

			// сохраняем текст дока в переменную
			rtfActDebit = richTextBox_ActDebit.Rtf;
		}

		private void button_Save_Click(object sender, EventArgs e) {

			// заменяем текст в ричтекстбоксе на шаблон для дока
			richTextBox_ActDebit.Rtf = rtfActDebit;

			// проходим по всем полям чтоб заменить
			richTextBox_ActDebit.Find("[<фио_гл_механик>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<фио_гл_механик>]", textBox_FIO_MainMechanic.Text);


			richTextBox_ActDebit.Find("[<фио_зам_ген_директор>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<фио_зам_ген_директор>]", textBox_FIO_DeputyDirector.Text);


			richTextBox_ActDebit.Find("[<фио_нач_отд_закупок>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<фио_нач_отд_закупок>]", textBox_FIO_HeadProcurement.Text);


			richTextBox_ActDebit.Find("[<фио_инженер>]");
			richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<фио_инженер>]", textBox_FIO_Engineer.Text);

			//richTextBox_ActDebit.Find("[<фио_зам_главбух>]");
			//richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<фио_зам_главбух>]", textBox_FIO_DeputyAccountant.Text);



			/*
			 * [<сумма_списания_прописью_рубли>] 
			 * [<сумма_списания_копейки>] 
			 * */

			//richTextBox_ActDebit.
		}
	}
}
