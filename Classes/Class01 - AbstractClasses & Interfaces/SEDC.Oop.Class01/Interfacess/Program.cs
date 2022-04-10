// See https://aka.ms/new-console-template for more information
using Enteties;
using Enteties.Interfacees;

Console.WriteLine("============= INTERFACES =============");

// da se napravi nezavisnost pomegu komponenti
// 


IUsers user = new User(4);
Console.WriteLine(user.GetId());

ITakingNotes pen = new Pen();   // isto moze i klasa Computer, Phone ....
pen.WriteNote();

void LoginUser(ITakingNotes noteWriter)
{
    Console.WriteLine("Enter Username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter Password");
    string password = Console.ReadLine();

    noteWriter.WriteNote();
}

LoginUser(pen);
//LoginUser(computer);






Console.WriteLine("===============================================");
IDeveloper developer = new Developer();
ITester tester = new Tester();

developer.Code();
tester.TestCode();
tester.Code();










Console.ReadLine();