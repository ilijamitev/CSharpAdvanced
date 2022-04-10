// See https://aka.ms/new-console-template for more information
using Class02.Polymorphism.M.Entities;

Console.WriteLine("Hello, POLYMORPHISM!");



List<Pet> pets = new List<Pet>()
{
    new Dog("Aks", "Mops"),
    new Cat(2, "Zuza"),
    new Dog("Baks", "Mops"),
    new Cat(2, "Jej"),
};


foreach (Pet pet in pets)
{
    pet.Eat();
}


Pet dog1 = new Dog();
Pet dog2 = new Dog("Sarplaninec");
Pet dog3 = new Dog("Lav", "Sarplaninec");

dog1.Eat();
dog2.Eat();
dog3.Eat();

MethodPolymorphism polym = new MethodPolymorphism();
polym.AddNumbers(1, 3);
polym.AddNumbers(2, 4, 5);
polym.AddNumbers(2.42342, 4);

Console.ReadLine();