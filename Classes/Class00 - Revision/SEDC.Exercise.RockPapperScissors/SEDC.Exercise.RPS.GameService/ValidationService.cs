using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.RPS.GameService
{
    public class ValidationService
    {
        public static bool ValidateUserChoice(string userInput, List<string> validOptions)
        {
            if (validOptions.Contains(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
