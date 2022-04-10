// See https://aka.ms/new-console-template for more information
using Enteties;

//Person ilija = new Person();     // NEMOZE DA KREIRAME INSTANCA OD ABSTRAKTNA KLASA

//Employee employee = new Employee(1, "Bob", "Bobsky", 40);

Person employee = new Employee(1, "Bob", "Bobsky", 40);   // mozeme i vaka so person
Console.WriteLine(employee.GetInfo());

Person admin = new Admin(2, "John", "Johnsky", "HR");
Console.WriteLine(admin.GetInfo());

// ova se koristi samo vo situacii koga ni treba grupni presmetki, informacii itn.

Console.WriteLine("==================================");

Figuress circle = new Circle(5);
Figuress square = new Squaree(10);

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(square.CalculateArea());











Console.ReadLine();