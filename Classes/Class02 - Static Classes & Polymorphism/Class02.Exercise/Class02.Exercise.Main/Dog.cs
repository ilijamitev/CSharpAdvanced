using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Exercise.Main
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog()
        {

        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} says Bark Bark");
        }

        public static bool ValidateDog(Dog dog)
        {
            return dog.Id > 0 && dog.Name.Length >= 2;
        }


    }
}
