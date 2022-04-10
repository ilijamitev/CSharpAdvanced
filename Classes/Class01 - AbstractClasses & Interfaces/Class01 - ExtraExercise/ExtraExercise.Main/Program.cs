// See https://aka.ms/new-console-template for more information
using Models;
using Models.BaseModel;

Console.WriteLine("=========== EXTRA EXERCISE ===========");
/*
         Homework

    => Create interfaces called IAnimal, IDog, ICat
    => IAnimal : Contains method PrintAnimal
    => IDog - Contains method Bark
    => ICat - Contains method Eat that gets parameter food of type string

    => Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
    => Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
    => Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
    => Create several objects and test the method calls

    ** Bonus
    => Create a list of Animal and add members that are of type Cat and Dog.
    => Iterate the list, use GetType for each member to see the type of animal. If it is a dog call its bark method, if it is a cat call the Eat method.
*/


List<Animal> AnimalLists = new List<Animal>()
{
    new Cat("Katy", 3),
    new Dog("Doggy", 2),
    new Cat("Smiggle", 5),
    new Dog("Aks", 7),
    new Cat("Zuza", 1),
    new Dog("Cesar", 8),
    new Cat("Kiti", 3),
    new Dog("Lav", 10),
};


foreach (var animal in AnimalLists)
{
    var typeOfAnimal = animal.GetType().ToString().Replace("Models.", "");
    if (typeOfAnimal.ToString() == "Dog")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        animal.PrintAnimal();
        animal.Bark();
        Console.ResetColor();
    }
    else if (typeOfAnimal.ToString() == "Cat")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        animal.PrintAnimal();
        animal.Eat("Fish, catfood");
        Console.ResetColor();
    }

}





Console.ReadLine();