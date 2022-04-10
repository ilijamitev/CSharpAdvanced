// See https://aka.ms/new-console-template for more information
using Class02.Exercise.Main;

Console.WriteLine("Hello, World!");


Dog doggy1 = new Dog(1, "Aks", "Apricot fawn");
Dog doggy2 = new Dog(-91, "Baks", "White");
Dog doggy3 = new Dog(2, "Maks", "Grey");
Dog doggy4 = new Dog(3, "Taks", "Black");
Dog doggy5 = new Dog(4, "B", "White");

DogShelter.AddDogToList(doggy1);
DogShelter.AddDogToList(doggy2);
DogShelter.AddDogToList(doggy3);
DogShelter.AddDogToList(doggy4);
DogShelter.AddDogToList(doggy5);

DogShelter.PrintAll();





Console.ReadLine();