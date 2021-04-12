using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OGM.Additions {
	public class DateToString {



		public static string Translate(DateTime date, string yearSpec = null) {
			// yearSpec = "г."
			// yearSpec = "года"


			string res = "";

			res += "«" + date.Day + "» ";
			//DateTimeFormat.MonthGenitiveNames
			res += CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames[date.Month - 1].ToLower();

			res += " " + date.Year;
			
			if (yearSpec != null) res += " " + yearSpec;

			return res;
		}
	}
}
