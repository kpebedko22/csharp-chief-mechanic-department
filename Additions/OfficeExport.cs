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
			public string[,] valuesCustomValues;
		}


		public static void Export(ExportData data) {

			// копируем файл
			System.IO.File.Copy(data.nameFileTemplate, data.nameFileExport);

			// перемещение файла в другое место + можно переименовать
			//System.IO.File.Move();

			// путь до нового файла
			string path = data.nameFileExport;

			Word.Application wordApp = new Word.Application();

			Word.Document document = wordApp.Documents.OpenNoRepairDialog(path);
			document.Activate();

			// выбираем таблицу в ворде - 2 таблицу, т.к. она представляет только строки
			// т.к. иначе ошибка - запрещено форматирование из-за объединенных клеток хедера
			Word.Table table = document.Tables[data.tableIndex];

			// Добавление строки в таблицу
			// добавляет почему-то строку перед существующей
			// поэтому проще сначала создать нужное количество строк
			// а потом пройтись по ним и заполнить каждую
			int numRows = data.valuesCustomValues.GetUpperBound(0);
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
					row.Cells[data.indicesCustomValues[k]].Range.Text = data.valuesCustomValues[numRow - 2, k];
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
