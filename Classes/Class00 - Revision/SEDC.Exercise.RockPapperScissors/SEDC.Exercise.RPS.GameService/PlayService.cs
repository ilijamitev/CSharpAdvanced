using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.RPS.GameService
{
    public class PlayService
    {
        public static void PlayGame(string inputChoice)
        {
            string computerChoice = GenerateComputerMove();
            string result = Battle(inputChoice, computerChoice);

            computerChoice = computerChoice == "1" ? "Rock" : computerChoice == "2" ? "Paper" : computerChoice == "3" ? "Scissors" : computerChoice;
            inputChoice = inputChoice == "1" ? "Rock" : inputChoice == "2" ? "Paper" : inputChoice == "3" ? "Scissors" : inputChoice;

            HelperService.ShowApprovalMessage($"Player has {inputChoice}");
            HelperService.ShowErrorMessage($"Computer has {computerChoice}");
            if (result == "x")
            {
                HelperService.ShowInformation($"You both choosed {computerChoice} :D Nobody wins.");
                StatsService.IncrementDrawScore();
            }
            else if (result == "1")
            {
                HelperService.ShowApprovalMessage($"The {inputChoice} beats the {computerChoice}. Point to Player.");
                StatsService.IncrementPersonScore();
            }
            else if (result == "2")
            {
                HelperService.ShowErrorMessage($"The {computerChoice} beats the {inputChoice}. Point to Computer.");
                StatsService.IncrementComputerScore();
            }
            // e ako e x-2 neam kvota :D
        }

        public static string Battle(string player, string computer)
        {
            if (player == computer) return "x";
            if (player == "1" && computer == "3" || player == "2" && computer == "1" || player == "3" && computer == "2")
            {
                return "1";
            }
            return "2";
        }

        public static string GenerateComputerMove()
        {
            Random randomChoice = new Random();
            return randomChoice.Next(1, 4).ToString();
        }

        // WOOOW KOLKU VISHOK KOD :D

        //else if (inputChoice == "1" && computerChoice == "3")
        //{
        //    HelperService.ShowApprovalMessage("Player has Rock");
        //    HelperService.ShowErrorMessage("Computer has Scissors");
        //    HelperService.ShowApprovalMessage("The Rock beats the Scissors. Point to Player.");
        //    StatsService.IncrementPersonScore();
        //}
        //else if (inputChoice == "2" && computerChoice == "1")
        //{
        //    HelperService.ShowApprovalMessage("Player has Paper");
        //    HelperService.ShowErrorMessage("Computer has Rock");
        //    HelperService.ShowApprovalMessage("The Paper beats the Rock. Point to Player.");
        //    StatsService.IncrementPersonScore();
        //}
        //else if (inputChoice == "3" && computerChoice == "2")
        //{
        //    HelperService.ShowApprovalMessage("Player has Scissors");
        //    HelperService.ShowErrorMessage("Computer has Paper");
        //    HelperService.ShowApprovalMessage("The Scissors beats the Paper. Point to Player.");
        //    StatsService.IncrementPersonScore();
        //}
        //else if (computerChoice == "1" && inputChoice == "3")
        //{
        //    HelperService.ShowApprovalMessage("Player has Scissors");
        //    HelperService.ShowErrorMessage("Computer has Rock");
        //    HelperService.ShowErrorMessage("The Rock beats the Scissors. Point to Computer.");
        //    StatsService.IncrementComputerScore();
        //}
        //else if (computerChoice == "2" && inputChoice == "1")
        //{
        //    HelperService.ShowApprovalMessage("Player has Rock");
        //    HelperService.ShowErrorMessage("Computer has Paper");
        //    HelperService.ShowErrorMessage("The Paper beats the Rock. Point to Computer.");
        //    StatsService.IncrementComputerScore();
        //}
        //else if (computerChoice == "3" && inputChoice == "2")
        //{
        //    HelperService.ShowApprovalMessage("Player has Paper");
        //    HelperService.ShowErrorMessage("Computer has Scissors");
        //    HelperService.ShowErrorMessage("The Scissors beats the Paper. Point to Computer.");
        //    StatsService.IncrementComputerScore();
        //}
    }
}
