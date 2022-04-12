using Class03.Exercise.Models.BaseModel;
using Class03.Exercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Exercise.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public string FavouriteFood { get; set; }
        public Dog(string name, PetType type, int age, bool isGoodBoi, string favouriteFood) : base(name, type, age)
        {
            IsGoodBoi = isGoodBoi;
            FavouriteFood = favouriteFood;
        }

        public override void PrintInfo()
        {
            string dogIsGood = IsGoodBoi ? "good boy" : "not good boy";
            Console.WriteLine($"{Name} is {Type}. It is {Age} years and it's {dogIsGood}. Its favourite food is {FavouriteFood}.");
        }
    }
}
