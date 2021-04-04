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

using OGM.Models;

namespace OGM {
	public partial class LeasingViewForm : Form {
		public LeasingViewForm(LeasingContract leasingContract = null) {
			InitializeComponent();

			OpenLeasingContract();
		}

		private void OpenLeasingContract() {

			try {
				Word.Application app = new Word.Application();
				Object fileName = Application.StartupPath + "\\..\\..\\resources\\docs\\dogovor-lizinga-oborudovaniya.doc";
				Console.WriteLine(fileName);
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

        private void ToolStripMenuItem_Export_File_Click(object sender, EventArgs e)
        {
			new ExportLeasingForm().ShowDialog();
        }
    }
}
