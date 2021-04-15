using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace OGM.Additions {
	public class OfficeExport {

		public struct ExportData {

			// Название шаблона файла
			public string nameFileTemplate;

			// Название нового файла
			public string nameFileExport;

			// Индекс таблицы в файле
			public int tableIndex;

			// Текст в шаблоне для замены 
			public List<string> textToReplace;

			// Текст используемый для замены
			public List<string> textReplaceWith;

			// Открыть файл после экспорта
			public bool openFileExport;

			// Индексы для столбцов таблицы по умолчанию
			public List<int> indicesDefaultValues;

			// Значения для столбцов таблицы по умолчанию
			public List<string> valuesDefaultValues;

			// Индексы для столбцов таблицы с уникальным значением
			public List<int> indicesCustomValues;

			// Значения для столбцов таблицы с уникальными значениями
			public List<List<string>> valuesCustomValues;
		}


		ExportData data;
		Word.Application wordApp = null;
		Word.Document document = null;
		Word.Table table = null;

		public int NumberRows { get; private set; }

		public int CurrentRow { get; private set; }

		public bool HasNextRow {
			get {
				return CurrentRow - 1 < NumberRows;
			}
		}

		public OfficeExport(ExportData data) {
			this.data = data;

			// копируем файл
			System.IO.File.Copy(data.nameFileTemplate, data.nameFileExport, true);
			// путь до нового файла
			//string path = Application.StartupPath + "\\" + data.nameFileExport;

			wordApp = new Word.Application();
			document = wordApp.Documents.OpenNoRepairDialog(data.nameFileExport);
			document.Activate();

			// выбираем таблицу
			table = document.Tables[data.tableIndex];

			CurrentRow = 1;
			NumberRows = data.valuesCustomValues.Count;
		}

		public void AddRowToTable() {

			Word.Row row = table.Rows.Add();

			// порядковый номер строки
			row.Cells[1].Range.Text = (CurrentRow++).ToString();

			// для каждого индекса дефолтного значения в строке заполняем дефолтным значением
			int numDefaultValues = data.indicesDefaultValues.Count;
			for (int j = 0; j < numDefaultValues; j++)
				row.Cells[data.indicesDefaultValues[j]].Range.Text = data.valuesDefaultValues[j];

			// кастомные значения
			int numCustomColumns = data.indicesCustomValues.Count;
			for (int k = 0; k < numCustomColumns; k++)
				row.Cells[data.indicesCustomValues[k]].Range.Text = data.valuesCustomValues[CurrentRow - 2][k];
		}

		public void ReplaceText() {
			// замена текста
			void ReplaceText(string TextToReplace, string TextReplaceWith) {
				document.Content.Find.Execute(TextToReplace, false, true, false, false, false, true, 1, false, TextReplaceWith, 2, false, false, false, false);
			}
			int numItems = data.textToReplace.Count;
			for (int i = 0; i < numItems; i++)
				ReplaceText(data.textToReplace[i], data.textReplaceWith[i]);
		}

		public void Close() {
			table.Rows.First.Delete();

			// конец экспорта
			if (data.openFileExport) {
				// сохранить изменения и открыть документ
				document.Save();
				wordApp.Visible = true;
			}
			else {
				// для закрытия документа без показа
				document.Save();
				document.Close();
				wordApp.Quit();
			}
		}







		public static void Export(ExportData data) {

			// копируем файл
			System.IO.File.Copy(data.nameFileTemplate, data.nameFileExport, true);

			// открываем ворд и документ вордовский (только что скопированный шаблон)
			Word.Application wordApp = new Word.Application();

			Word.Document document = wordApp.Documents.OpenNoRepairDialog(data.nameFileExport);
			document.Activate();

			// выбираем таблицу в ворде
			Word.Table table = document.Tables[data.tableIndex];

			// Добавление строки в таблицу
			// добавляет почему-то строку перед существующей
			// поэтому проще сначала создать нужное количество строк
			// а потом пройтись по ним и заполнить каждую
			int numRows = data.valuesCustomValues.Count - 1;
			for (int i = 0; i < numRows; i++) {
				// дублирование пустой строки таблицы
				var row = table.Rows.Add(table.Rows[1]);
			}


			// пройтись по каждой строке таблицы и через Cells[index] заполнить ее
			int numRow = 1; // порядковый номер
			foreach (Word.Row row in table.Rows) {

				// порядковый номер строки
				row.Cells[1].Range.Text = (numRow++).ToString();

				// для каждого индекса дефолтного значения в строке заполняем дефолтным значением
				int numDefaultValues = data.indicesDefaultValues.Count;
				for (int j = 0; j < numDefaultValues; j++)
					row.Cells[data.indicesDefaultValues[j]].Range.Text = data.valuesDefaultValues[j];

				// кастомные значения
				int numCustomColumns = data.indicesCustomValues.Count;
				for (int k = 0; k < numCustomColumns; k++)
					row.Cells[data.indicesCustomValues[k]].Range.Text = data.valuesCustomValues[numRow - 2][k];
			}

			// замена текста
			void ReplaceText(string TextToReplace, string TextReplaceWith) {
				document.Content.Find.Execute(TextToReplace, false, true, false, false, false, true, 1, false, TextReplaceWith, 2, false, false, false, false);
			}
			int numItems = data.textToReplace.Count;
			for (int i = 0; i < numItems; i++)
				ReplaceText(data.textToReplace[i], data.textReplaceWith[i]);

			// конец экспорта
			if (data.openFileExport) {
				// сохранить изменения и открыть документ
				document.Save();
				wordApp.Visible = true;
			}
			else {
				// для закрытия документа без показа
				document.Save();
				document.Close();
				wordApp.Quit();
			}
		}


	}
}
