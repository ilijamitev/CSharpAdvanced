using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.StaticClasse
{
    public static class StringUtils
    {
        public static string CapitaliseFirstLetter(string text)
        {
            if (text == null) return "ERROR!";
            if (string.IsNullOrWhiteSpace(text)) return "ERROR";
            string firstLetter = text[0].ToString();
            return text.Replace(firstLetter, firstLetter.ToUpper());
        }

        public static int VerifyStringNumber(string input)
        {
            bool isNumber = int.TryParse(input, out int result);
            if (isNumber) return result;
            return 0;
        }



    }
}
