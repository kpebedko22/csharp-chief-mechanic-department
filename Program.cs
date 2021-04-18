using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

using OGM.Models;

namespace OGM {
	static class Program {

		public static OGMContext db;
		public static string config;

		static bool GetConfig()
        {
			try
			{
				StreamReader fstream = new StreamReader($"config.txt");
				config = fstream.ReadLine();
			}
			catch
            {
				MessageBox.Show("Не удалось открыть файл конфигурации. Обратитесь к системному администратору!","Ошибка конфигурации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
            }
			return true;
		}

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			if (GetConfig() == false) return;
			db = new OGMContext();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LogInForm());
		}
	}
}
