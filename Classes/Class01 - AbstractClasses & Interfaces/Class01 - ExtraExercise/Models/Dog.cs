using Models.BaseModel;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Animal
    {
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} is a Dog and it is {Age} years.");
        }

        public override void Bark()
        {
            Console.WriteLine($"{Name} is saying WOF WOF WOF!");
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
