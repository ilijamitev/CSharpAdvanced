// See https://aka.ms/new-console-template for more information
using Class05.Exercise.ModelsDB;

Console.WriteLine("Hello, World!");

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
Console.WriteLine("\nPersons with R with age Desc");
var personsWithR = ModelsDatabase.people.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
personsWithR.ForEach(x => Console.WriteLine(x.FirstName));

//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
Console.WriteLine("\nAll brown dogs names and ages older than 3 years");
var brownDogsNames = ModelsDatabase.dogs.Where(x => x.Color == "Brown" && x.Age > 3).ToList();
brownDogsNames.OrderBy(x => x.Age).ToList();
brownDogsNames.ForEach(x => Console.WriteLine(x.Name));

//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
Console.WriteLine("\nPersons with more than 2 dogs, ordered by Name");
var personsWithMoreDogs = ModelsDatabase.people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
personsWithMoreDogs.ForEach(x => Console.WriteLine(x.FirstName));

//Find and print all Freddy`s dogs names older than 1 year
Console.WriteLine("\nFreddy`s dogs names");
var freddy = ModelsDatabase.people.FirstOrDefault(x => x.FirstName == "Freddy");
freddy.Dogs.Where(x => x.Age > 1).ToList().ForEach(x => Console.WriteLine(x.Name));

//Find and print Nathen`s first dog
Console.WriteLine("\nNathen`s first dog");
var nathen = ModelsDatabase.people.FirstOrDefault(x => x.FirstName == "Nathen");
Console.WriteLine(nathen.Dogs[0].Name);

//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
Console.WriteLine("\nWhite dogs names from Cristofer, Freddy, Erin and Amelia");
string[] names = { "Cristofer", "Freddy", "Erin", "Amelia" };
var peopleNames = ModelsDatabase.people.Where(x => names.Contains(x.FirstName)).ToList();
var dogsNames = peopleNames.SelectMany(x => x.Dogs.Where(x => x.Color == "White")).OrderBy(x => x.Name).ToList();
dogsNames.ForEach(x => Console.WriteLine(x.Name));


Console.ReadLine();
Console.Clear();


ModelsDatabase.people.OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x));





Console.ReadLine();
