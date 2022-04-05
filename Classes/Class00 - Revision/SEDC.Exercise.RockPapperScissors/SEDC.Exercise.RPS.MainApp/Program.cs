using SEDC.Exercise.RPS.GameService;
using System;

namespace SEDC.Exercise.RPS.MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "     ***Rock-Paper-Scissors***";
            MenuService.StartMenu();
        }
    }
}
