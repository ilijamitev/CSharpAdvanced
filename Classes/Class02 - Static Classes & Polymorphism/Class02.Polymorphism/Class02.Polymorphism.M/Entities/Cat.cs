using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Polymorphism.M.Entities
{
    public class Cat : Pet
    {
        public double NumberOfBalls { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating."); ;
        }
        public Cat(double balls, string name) : base(name)
        {
            NumberOfBalls = balls;
        }
    }
}
