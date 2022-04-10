using Models.BaseModel;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Animal
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} is a Cat and it is {Age} years.");
        }
        public override void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }


        public override void Bark()
        {
            throw new NotImplementedException();
        }

    }
}
