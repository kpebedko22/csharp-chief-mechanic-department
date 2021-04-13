using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGM.Additions
{
    class ConvertYearsMonths
    {

        public static string Translate(string str)
        {
            string result = "";

            string[] splited = str.Split(',');


            int years = Convert.ToInt32(splited[0]);
            int months = Convert.ToInt32(splited[1]);

            // года
            if (years != 0)
            {
                result += splited[0] + " ";    // год
                if (years % 10 > 0 && years % 10 < 5 && (years < 11 || years > 14))
                {
                    if (years % 10 == 1)
                        result += "год ";
                    else
                        result += "года ";
                }
                else
                    result += "лет ";
            }


            // месяцы
            result += splited[1];
            if (months == 1)
                result += " месяц";
            else if (months > 1 && months < 5)
                result += " месяца";
            else
                result += " месяцев";


            return result;
        }

    }
}
