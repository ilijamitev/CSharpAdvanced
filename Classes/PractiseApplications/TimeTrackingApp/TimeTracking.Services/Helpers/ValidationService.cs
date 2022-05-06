using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracking.Services.Helpers
{
    public static class ValidationService
    {
        public static int ValidInputChoice(int min, int max)
        {
            while (true)
            {
                try
                {
                    string inputChoice = Console.ReadLine();
                    bool isValidInteger = int.TryParse(inputChoice, out int parsedInput);
                    if (string.IsNullOrWhiteSpace(inputChoice))
                    {
                        HelperService.ThrowException("ENTER A VALUE!");
                    }
                    if (!isValidInteger)
                    {
                        HelperService.ThrowException("ENTER VALID NUMBER!");
                    }
                    if (parsedInput < min || parsedInput > max)
                    {
                        HelperService.ThrowException("SELECT VALID OPTION!");
                    }
                    return parsedInput;
                }
                catch (Exception ex)
                {
                    HelperService.ErrorMessage(ex.Message);
                }
            }
        }









    }
}
