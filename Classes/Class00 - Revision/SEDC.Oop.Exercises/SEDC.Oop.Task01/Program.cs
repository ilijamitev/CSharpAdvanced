using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Oop.Task01
{
    //    1. Create a console application that detects provided names in a provided text 🔹

    //The application should ask for names to be entered until the user enters x

    //After that, the application should ask for a text

    //When that is done the application should show how many times that name was included in the text ignoring upper/lower case

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<string> validateInput = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            List<string> listOfNames = new List<string>() { };

            Console.WriteLine("Please enter names. To stop press 'x'.");
            while (true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    if (validateInput.Contains(userInput) || string.IsNullOrWhiteSpace(userInput))
                    {
                        throw new Exception("Enter valid name!");
                    }
                    else if (userInput == "x")
                    {
                        break;
                    }

                    listOfNames.Add(userInput);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine("NOW ENTER TEXT:");
            string inputText = Console.ReadLine();
            string[] searchText = inputText.Split(" ");

            int counter = 0;

            foreach (string name in listOfNames)
            {
                //searchText.Count(name);       dobro e ova...
                foreach (string word in searchText)
                {
                    if (word.ToLower() == name.ToLower())
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"Name: {name} is contained {counter} times");
                counter = 0;
            }





            Console.ReadLine();
        }
    }
}
