using Class03.Exercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Exercise.Models.BaseModel
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Age { get; set; }
        public Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public abstract void PrintInfo();

    }
}
