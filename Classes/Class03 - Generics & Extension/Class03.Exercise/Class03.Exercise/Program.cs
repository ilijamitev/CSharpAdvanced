// See https://aka.ms/new-console-template for more information
using Class03.Exercise;
using Class03.Exercise.Models;
using Class03.Exercise.Models.Enum;

Console.WriteLine("Hello, World!");


PetStore<Cat> catStore = new PetStore<Cat>(new List<Cat>
{
    new Cat("Zuza", PetType.Cat,5,true,8),
    new Cat("Muza", PetType.Cat,3,false,2),
    new Cat("Duza", PetType.Cat,4,true,1),
    new Cat("Puza", PetType.Cat,2,false,3),
});

PetStore<Dog> dogStore = new PetStore<Dog>(new List<Dog>
{
    new Dog("Aks", PetType.Dog,5,true,"Chicken"),
    new Dog("Baks", PetType.Dog,3,false,"Pork"),
    new Dog("Maks", PetType.Dog,4,true,"Gyro"),
    new Dog("Taks", PetType.Dog,2,false,"Pita"),
});

PetStore<Fish> fishStore = new PetStore<Fish>(new List<Fish>
{
    new Fish("Mish", PetType.Fish,5,"orange",5),
    new Fish("Pish", PetType.Fish,3,"yellow",4),
    new Fish("Trish", PetType.Fish,4,"black",10),
    new Fish("Nish", PetType.Fish,2,"green",4),
});

Console.WriteLine("========== CAT STORE ==========");
catStore.PrintPet();
Console.WriteLine("========== DOG STORE ==========");
dogStore.PrintPet();
Console.WriteLine("========== FISH STORE ==========");
fishStore.PrintPet();
fishStore.BuyPet("Nish");
Console.WriteLine("========== BOUGHT FISH ==========");
fishStore.PrintPet();



Console.ReadLine();