using QuizModels.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    public class LoginService
    {

        public static int LoginTries = 0;

        public static void IncrementLoginTries()
        {
            LoginTries++;
        }

        public static void ResetLoginTries()
        {
            LoginTries = 0;
        }

        public static string LoginChoice()
        {
            while (true)
            {
                try
                {
                    string loginChoice = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(loginChoice))
                    {
                        HelpersService.ThrowException("PLEASE ENTER A VALUE!");
                    }
                    else if (!ValidationService.ValidateUserChoice(loginChoice, new string[] { "1", "2", "3" }))
                    {
                        HelpersService.ThrowException("SELECT VALID OPTION!");
                    }
                    return loginChoice;

                }
                catch (Exception ex)
                {
                    HelpersService.ShowErrorMessage(ex.Message);
                }
            }
        }

        public static User LoginUser(string loginChoice)
        {
            string fullName = string.Empty;
            int password;
            while (true)
            {
                try
                {
                    HelpersService.ShowApplicationMessages("Enter your Full Name:");
                    fullName = Console.ReadLine();
                    HelpersService.ShowApplicationMessages("Enter your Password:");
                    bool passwordInput = int.TryParse(Console.ReadLine(), out password);
                    if (LoginService.LoginTries == 2)
                    {
                        HelpersService.ShowErrorMessage("MISSED IT AGAIN ! BYE BYE !");
                        Console.Read();
                        MenuService.ShowEnd();
                        Environment.Exit(-1);
                        break;
                    }

                    else if (!ValidationService.CheckFullNameInDatabase(fullName, loginChoice))
                    {
                        LoginService.IncrementLoginTries();
                        HelpersService.ThrowException("NO USER WITH THAT NAME FOUND!");
                    }
                    else if (!ValidationService.CheckPasswordInDatabase(password, loginChoice))
                    {
                        LoginService.IncrementLoginTries();
                        HelpersService.ThrowException("INVALID PASSWORD!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    HelpersService.ShowErrorMessage(ex.Message);
                }
            }

            return new User(fullName, password);
        }















    }
}
