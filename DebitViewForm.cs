using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using OGM.Models;
using OGM.Additions;

namespace OGM {
	public partial class DebitViewForm : Form {

		private ActDebit ActDebit = null;
		private List<DebitEquipment> debitEquipments = null;

		private double ActDebitTotalCost = 0;// 1556800.48;

		public DebitViewForm(ActDebit actDebit) {
			InitializeComponent();

			// сохраняем текущий акт списания в переменную формы
			ActDebit = actDebit;

			// выводим лейбл формы
			label_ActDebitNum.Text = "Акт списания оборудования №" + ActDebit.act_number;

			// загрузка документа в таб "шаблон документа"
			OpenTemplateDocument();

			// выбрать все строки акта списания из БД
			debitEquipments = Program.db.DebitEquipments.Where(b => b.PK_Aсt_Debit == ActDebit.PK_Aсt_Debit).ToList();

			UpdateTable();

			//
			textBox_ActNumber.Text = ActDebit.act_number;
			dateTimePicker_ActDate.Value = ActDebit.date;
			textBox_ActTotalPrice.Text = ActDebitTotalCost.ToString();
		}

		private void UpdateTable() {

			dataGridView_Data.AutoGenerateColumns = false;
			dataGridView_Data.ReadOnly = true;

			//dataGridView_Data.Columns[0].DataPropertyName = "PK_Organization";

			//dataGridView_Data.Columns[1].DataPropertyName = "PK_Workshop";
			//dataGridView_Data.Columns[2].DataPropertyName = "PK_Equipment_Group";
			dataGridView_Data.Columns[3].DataPropertyName = "inventory_number";
			//dataGridView_Data.Columns[4].DataPropertyName = "PK_Equipment";
			//dataGridView_Data.Columns[5].DataPropertyName = "cost";
			dataGridView_Data.Columns[6].DataPropertyName = "ReasonDebit";

			dataGridView_Data.DataSource = debitEquipments;

			foreach (var item in debitEquipments) {
				//dataGridView_Data.
				//ActDebitTotalCost += item.cost;
			}


		}

		private void OpenTemplateDocument() {
			try {
				string path = Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_template.rtf";
				richTextBox_ActDebit.LoadFile(path);
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void ExportDoc(string nameFileExport) {

			OfficeExport.ExportData exportData = new OfficeExport.ExportData();

			exportData.nameFileTemplate = Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_template3.docx";
			exportData.nameFileExport = nameFileExport;			// Application.StartupPath + "\\..\\..\\resources\\docs\\act_debit_number" + ActDebit.act_number + ".docx";
			exportData.tableIndex = 2;							// номер таблицы в доке
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

			string rubles = NumToWord.Translate(Math.Floor(ActDebitTotalCost));
			string pennys = (Math.Round(100 * (ActDebitTotalCost - Math.Floor(ActDebitTotalCost)))).ToString();


			// тут какие-то текстбоксы видимо с формы
			exportData.textReplaceWith = new List<string>() {
				 "----",												// название конторы
				 textBox_FIO_MainMechanic.Text,							// фио главного механика
				 DateToString.Translate(ActDebit.date, "г."),			// дата как «___»________202_г.
				 ActDebit.act_number.ToString(),						// номер акта
				 rubles,												// сумма прописью - рубли
				 pennys,												// сумма цифрами - копейки
				 textBox_FIO_DeputyDirector.Text,						// фио зам.ген.директора
				 textBox_FIO_HeadProcurement.Text,						// нач отдела закупок
				 textBox_FIO_Engineer.Text,								// инженер
				 textBox_FIO_DeputyAccountant.Text						// зам главбуха
			};

			// если надо открыть файл после экспорта автоматически
			exportData.openFileExport = checkBox_OpenFileExport.Checked;	

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
				"796",	// код по ОКЕИ ед. измерения
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

			exportData.valuesCustomValues = new List<List<string>>();

			foreach(DataGridViewRow row in dataGridView_Data.Rows) {

				string workshop = "";// row.Cells[1].Value.ToString();
				string group = "";// row.Cells[2].Value.ToString();
				string inventory = row.Cells[3].Value.ToString();
				string name = "";//row.Cells[4].Value.ToString();
				string cost = "";//row.Cells[5].Value.ToString();
				string reason = row.Cells[6].Value.ToString();

				//group,	// группа оборудования

				exportData.valuesCustomValues.Add( 
					new List<string>() {
						workshop,		// цех
						inventory,		// инвентарный номер
						name,		// наименование
						cost,		// остаточная стоимость
						reason		// причина списания
				});
			}

			OfficeExport.Export(exportData);
		}

		private void button_Export_Click(object sender, EventArgs e) {

			if (ActDebit == null) {
				MessageBox.Show("Что-то пошло не так и акта списания нет...");
				return;
			}

			if (debitEquipments.Count < 1) {
				MessageBox.Show("Нет строк в акте списания. Отказ в экспорте...");
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Документ Word (*.docx)|*.docx";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				ExportDoc(saveFileDialog.FileName);
			}
		}
	}
}
