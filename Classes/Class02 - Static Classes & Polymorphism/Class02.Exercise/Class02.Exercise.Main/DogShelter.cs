using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Exercise.Main
{
    public static class DogShelter
    {
        public static List<Dog> DogsList = new List<Dog>();

        public static void PrintAll()
        {
            foreach (Dog dog in DogsList)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} is of color {dog.Color}.");
                dog.Bark();
            }
        }

        public static void AddDogToList(Dog dog)
        {
            if (Dog.ValidateDog(dog) == true)
            {
                DogsList.Add(dog);
            }
        }
    }
}
