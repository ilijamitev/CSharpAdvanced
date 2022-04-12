// See https://aka.ms/new-console-template for more information
using Class03.Extensionss;
// za da se namali using se koristi PIGGY EXTENSION t.e. da se stavi kaj klasata STringExtensions drug namespace t.e. namespace System
Console.WriteLine("Hello, EXTENSIONS!");

Console.WriteLine(StringExtensions.DeleteLastCharacter("Acko programer"));
Console.WriteLine(StringExtensions.DeleteLastChar("Acko programer"));

string textToShorten = "Some string value";

// mozeme da pristapime do extension metodata na ovoj nacin =>
Console.WriteLine(textToShorten.DeleteLastCharacter());

Console.WriteLine(textToShorten.AddQuotations());

List<string> stringList = new List<string>() { "First", "Second", "Third"};
stringList.PrintElements();




Console.ReadLine();