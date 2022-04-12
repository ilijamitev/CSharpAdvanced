using Class03.Exercise.Models.BaseModel;
using Class03.Exercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Exercise.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish(string name, PetType type, int age, string color, int size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a {Type}. It has {Age} years. It's of color {Color} and {Size} cm long.");
        }
    }
}
