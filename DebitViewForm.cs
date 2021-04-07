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
using OGM.Additions;

namespace OGM {
	public partial class DebitViewForm : Form {

		private ActDebit ActDebit = null;

		//string rtfActDebit = null;

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
			//
			//richTextBox_ActDebit.Find("[<номер_акта>]");
			//richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<номер_акта>]", ActDebit.act_number);
			//
			//string d = "«" + ActDebit.date.Day + "» " + ActDebit.date.ToString("MMMM").ToLower() + " " + ActDebit.date.Year + "г.";
			//richTextBox_ActDebit.Find("[<дата_списания>]");
			//richTextBox_ActDebit.SelectedText = richTextBox_ActDebit.SelectedText.Replace("[<дата_списания>]", d);
			//
			//// сохраняем текст дока в переменную
			//rtfActDebit = richTextBox_ActDebit.Rtf;
		}

		private void button_Save_Click(object sender, EventArgs e) {

			if (ActDebit == null) return;

			ExportDoc();

		}

		private void ExportDoc() {

			OfficeExport.ExportData exportData;

			exportData.nameFileTemplate = Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_template3.docx";
			exportData.nameFileExport = Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_number" + ActDebit.act_number + ".docx";
			exportData.tableIndex = 2; //скорее всего по умолчанию так и будет
			exportData.textToReplace = new List<string>() {
				"[<наименование_организации>]"          ,
				"[<фио_гл_механик>]"                    ,
				"[<дата_списания>]"                     ,
				"[<номер_акта>]"                        ,
				"[<сумма_списания_прописью_рубли>]"     ,
				"[<сумма_списания_копейки>]"            ,
				"[<фио_зам_ген_директор>]"              ,
				"[<фио_нач_отд_закупок>]"               ,
				"[<фио_инженер>]"                       ,
				"[<фио_зам_главбух>]"
			};

			// тут какие-то текстбоксы видимо с формы
			exportData.textReplaceWith = new List<string>() {
				 "----",
				textBox_FIO_MainMechanic.Text,
				ActDebit.date.ToString(),
				ActDebit.act_number.ToString(),
				 "----",
				 "----",
				 textBox_FIO_DeputyDirector.Text,
				 textBox_FIO_HeadProcurement.Text,
				 textBox_FIO_Engineer.Text,
				 textBox_FIO_DeputyAccountant.Text
			};
			exportData.openFileExport = true; // если надо открыть файл после экспорта автоматически - checkBox_openFileExport.Checked - с формы юзать такую хуйню

			// и самый интересный момент - таблица
			// количество строк с учетом что одна строка по умолчанию есть внутри шаблона
			// какой столбик из datagridview в какой столбик в доке
			// и еще есть столбцы по умолчанию
			exportData.indicesDefaultValues = new List<int>() {
				5,	// код по ОКЕИ ед. измерения
				6,	// наименование ед. измерения
				7	// количество
			};
			exportData.valuesDefaultValues = new List<string>() {
				"766",	// код по ОКЕИ ед. измерения
				"шт.",	// наименование ед. измерения
				"1"		// количество
			};

			exportData.indicesCustomValues = new List<int>() {
				2,	// цех
				3,	// инвентарный номер
				4,	// наименование оборудования
				8,	// остаточная стоимость
				9	// причина списания
			};

			exportData.valuesCustomValues = new string[,] {
				{"цех1", "инв номер1", "наим оборудования 1", "оста стоим 1 ", "причина списания 1" },
				{"цех2", "инв номер2", "наим оборудования 2", "оста стоим 2", "причина списания 2" }
			};

			OfficeExport.Export(exportData);
		}
	}
}
