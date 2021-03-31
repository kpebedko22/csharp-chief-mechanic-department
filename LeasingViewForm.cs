using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OGM {
	public partial class LeasingViewForm : Form {
		public LeasingViewForm() {
			InitializeComponent();

			OpenLeasingContract();
		}

		private void OpenLeasingContract() {

			try {
				Word.Application app = new Word.Application();
				Object fileName = Application.StartupPath + "\\..\\..\\dogovor-lizinga-oborudovaniya.doc";
				Object missing = Type.Missing;
				app.Documents.Open(ref fileName);

				Word.Document doc = app.ActiveDocument;

				for (int i = 1; i < doc.Paragraphs.Count; i++) {
					string parText = doc.Paragraphs[i].Range.Text;
					richTextBox_LeasingContract.Text += parText;
				}

				app.ActiveDocument.Close();
				app.Quit();
			}
			catch (Exception e) {
				// сообщение об ошибке
				MessageBox.Show(e.Message);
			}
			

			
		}
	}
}
