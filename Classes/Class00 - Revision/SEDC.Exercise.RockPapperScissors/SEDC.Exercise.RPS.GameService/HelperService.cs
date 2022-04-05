using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.RPS.GameService
{
    public class HelperService
    {
        public static void ShowErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowApprovalMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowApplicationMessages(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowInformation(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void ThrowException(string text)
        {
            throw new Exception(text);
        }
    }
}
