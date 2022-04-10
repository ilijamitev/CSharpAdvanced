using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Polymorphism.M.Entities
{
    public class Dog : Pet
    {
        public string Breed { get; set; }

        // RUNTIME 
        public Dog()
        {

        }
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
        public Dog(string breed)
        {
            Breed = breed;
        }
        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating.");
        }

    }
}
