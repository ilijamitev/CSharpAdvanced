using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.RPS.GameService
{
    public class MenuService
    {
        public static void StartMenu()
        {
            HelperService.ShowApprovalMessage("\n       HELLOOO. IT'S YOUR FAVOURITE ROCK-PAPPER-SCISSORS GAME !\n                          GOOD LUCK :)");
            bool isTrue = true;
            while (isTrue)
            {
                HelperService.ShowApplicationMessages("\n   Please select one of the following options: \n1.Play \n2.Stats \n3.Exit \n*just enter the number :)");
                try
                {
                    string userChoice = Console.ReadLine();
                    if (ValidationService.ValidateUserChoice(userChoice, new List<string>() { "1", "2", "3" }))
                    {
                        switch (userChoice)
                        {
                            case "1":
                                PlayGameMenu();
                                break;
                            case "2":
                                StatsService.ShowStats();
                                break;
                            case "3":
                                isTrue = !isTrue;
                                break;
                        }
                    }
                    else
                    {
                        HelperService.ThrowException("SELECT VALID OPTION !");
                    }
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }

            Console.ReadLine();
            Console.Clear();
            HelperService.ShowApplicationMessages("\n\n\n\n\n\n             *** Thank you for using our App ***\n                     Come back soon :)");
            Console.ReadLine();
        }

        public static void PlayGameMenu()
        {
            HelperService.ShowApplicationMessages("\n   LET THE GAME BEGIN !\n");
            bool isTrue = true;
            while (isTrue)
            {
                HelperService.ShowApplicationMessages("\nChoose:\n1.Rock\n2.Paper\n3.Scissors");
                try
                {
                    string userChoice = Console.ReadLine();
                    if (ValidationService.ValidateUserChoice(userChoice, new List<string>() { "1", "2", "3" }))
                    {
                        PlayService.PlayGame(userChoice);
                        HelperService.ShowApplicationMessages("\nPress enter to continue to menu\n");
                        Console.ReadLine();
                        isTrue = !isTrue;
                    }
                    else
                    {
                        HelperService.ThrowException("SELECT VALID OPTION !");
                    }
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }
        }
    }
}
