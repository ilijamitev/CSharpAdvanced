// See https://aka.ms/new-console-template for more information
using Class02.StaticClasse;

Console.WriteLine("Hello, STATIC CLASSES!");

int counter = FirstStaticClass.Counter;
Console.WriteLine(counter);

FirstStaticClass.Counter++;
Console.WriteLine(FirstStaticClass.Counter++);

Console.WriteLine(FirstStaticClass.AddTwoNumbers(5, 10));
Console.Clear();

User ilija = new User(1, "Ilija", "Mitev");
Console.WriteLine(User.UserCount);
User maja = new User(2, "Maja", "Nikolikj");
Console.WriteLine(User.UserCount);


Console.WriteLine(StringUtils.CapitaliseFirstLetter("asfdasasfasfas"));
Console.WriteLine(StringUtils.CapitaliseFirstLetter(" "));
Console.WriteLine(StringUtils.VerifyStringNumber("1321321321"));

string defaultValue = default(string);
DateTime dateTime = default(DateTime);
Console.WriteLine(dateTime);

foreach (User user in OrdersFakeDB.Users)
{
    Console.WriteLine(user.FirstName);
}



Console.ReadLine();