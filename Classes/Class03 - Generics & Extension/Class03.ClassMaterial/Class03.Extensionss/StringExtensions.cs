using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Extensionss
{
    public static class StringExtensions
    {
        public static string DeleteLastCharacter(this string text) // keyword THIS => extension
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string DeleteLastChar(string text)
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string AddQuotations(this string textToQuote)
        {
            return $@"""{textToQuote}""";
        }

    }
}
