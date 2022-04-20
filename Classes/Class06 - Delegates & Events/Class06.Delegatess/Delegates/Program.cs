// See https://aka.ms/new-console-template for more information


static void WriteToConsole(string text)
{
    Console.WriteLine(text);
}

static void ShowTextInColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

static void SaySomething(SayDelegate sayMechanism, int counter)
{
    sayMechanism($"Text from method. Counter: {counter}");
}

// so delegate moze da se stavi METOD (sto gi ispolnuva uslovite na delegatot!) kako ARGUMENT na nekoj drug metod.
SaySomething(WriteToConsole, 5);
SaySomething(ShowTextInColor, 15);

Console.WriteLine("\n================================");

SayDelegate writeToConsole = new SayDelegate(WriteToConsole);
SayDelegate writeInRed = new SayDelegate(ShowTextInColor);
writeToConsole("HELLO FROM DELEGATES!");
writeInRed("HELLO FEOM RED DELEGATES!");

Console.WriteLine("\n================================");

CalculateDelegate addTwoNumbers = SumOfTwo;
static int SumOfTwo(int num1, int num2) => num1 + num2;
CalculateDelegate subtractTwoNumbers = SubtractNumbers;
static int SubtractNumbers(int num1, int num2) => num1 - num2;
Console.WriteLine(addTwoNumbers(20, 5));
Console.WriteLine(subtractTwoNumbers(20, 5));

Console.WriteLine("\n================================");

static void PerformCalculations(CalculateDelegate addNumbers, CalculateDelegate subtractNumbers, int num1, int num2)
{
    Console.WriteLine($"Sum of num1 {num1} and num2 {num2} is {addNumbers(num1, num2)}");
    Console.WriteLine($"Subtraction of num1 {num1} and num2 {num2} is {subtractNumbers(num1, num2)}");
}
PerformCalculations(addTwoNumbers, subtractTwoNumbers, 30, 5);

Console.WriteLine("\n================================");








Console.ReadLine();
delegate void SayDelegate(string text);
delegate int CalculateDelegate(int num1, int num2);