// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ANONYMOUS FUNCTIONS");


// ========> FUNC <=========
Console.WriteLine("========> FUNC <=========");

Func<int> getRandomNumber = () =>
  {
      Random random = new Random();
      return random.Next(1, 100);
  };

Func<int, int, int> sumOfTwo = (num1, num2) =>
  {
      return num1 + num2;
  };

Console.WriteLine(getRandomNumber());
Console.WriteLine(sumOfTwo(11, 22));

Func<string, bool> isValidNumber = (text) => int.TryParse(text, out int _);


int first = 0;
int second = 0;
Console.WriteLine("Enter first num");
string firstString = Console.ReadLine();
if (isValidNumber(firstString))
{
    first = int.Parse(firstString);
}
Console.WriteLine("Enter second num");
string secondString = Console.ReadLine();
if (isValidNumber(secondString))
{
    second = int.Parse(secondString);
}

Console.WriteLine($"The sum of numbers {first} and {second} is {sumOfTwo(first, second)}");



// ========> ACTION <=========
Console.WriteLine("========> ACTION <=========");

Action<string> showTextInRed = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};

showTextInRed("THIS IS AN ERROR MESSAGE!");

Action<string, ConsoleColor> printWithColor = (text, color) =>
 {
     Console.ForegroundColor = color;
     Console.WriteLine(text);
     Console.ResetColor();
 };

printWithColor("BLUE TEXT", ConsoleColor.Blue);

Action printHelloWorld = () => Console.WriteLine("HELLO WORLD FROM ACTION METHOD");
printHelloWorld();

Console.ReadLine();