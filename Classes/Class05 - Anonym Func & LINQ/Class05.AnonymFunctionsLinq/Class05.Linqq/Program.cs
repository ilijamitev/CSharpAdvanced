// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 123, 23, 42 };

static bool isLargerThanTen(int x)
{
    return x > 10;
}

// where e isto so FILTER od js  ===> se zima originalnata lista t.e. ne se pravi kopija...
var largerThanTen = intList.Where(isLargerThanTen).ToList();     // MOZE I VAKA DA SE KORISTI
largerThanTen.ForEach(x => Console.WriteLine(x));

// select e isto so MAP od js
List<string> stringList = new List<string>() { "11", "22", "1", "5", "15", "33", "21" };
List<int> convertedFromString = stringList.Select(stringNum => int.Parse(stringNum)).ToList();
int sum = convertedFromString.Sum();
Console.WriteLine("The sum is " + sum);












Console.ReadLine();