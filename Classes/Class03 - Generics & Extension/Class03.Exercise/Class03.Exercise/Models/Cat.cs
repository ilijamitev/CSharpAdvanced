using Class03.Exercise.Models.BaseModel;
using Class03.Exercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Exercise.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, PetType type, int age, bool isLazy, int livesLeft) : base(name, type, age)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            string isLazy = IsLazy ? "lazy" : "not lazy";
            Console.WriteLine($"{Name} is a {Type}. It has {Age} years. It's {isLazy} and has {LivesLeft}.");
        }
    }
}
