using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.RPS.GameService
{
    public class StatsService
    {
        public static int PersonScore = 0;
        public static int ComputerScore = 0;
        public static int DrawScore = 0;

        public static void IncrementDrawScore()
        {
            DrawScore++;
        }

        public static void IncrementPersonScore()
        {
            PersonScore++;
        }

        public static void IncrementComputerScore()
        {
            ComputerScore++;
        }

        public static void ShowStats()
        {
            HelperService.ShowInformation($"Draw score: {DrawScore}");
            HelperService.ShowApprovalMessage($"The Player has {PersonScore} wins.");
            HelperService.ShowErrorMessage($"The Computer has {ComputerScore} wins.");

            if (PersonScore > ComputerScore)
            {
                HelperService.ShowApprovalMessage("PLAYER WINS !");
            }
            else if (PersonScore < ComputerScore)
            {
                HelperService.ShowErrorMessage("COMPUTER WINS !");
            }

            Console.ReadLine();
        }
    }
}
