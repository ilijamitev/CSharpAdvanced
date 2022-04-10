using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.BaseModel
{
    public abstract class Animal : IAnimal, IDog, ICat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Bark();
        public abstract void Eat(string food);


        public abstract void PrintAnimal();

    }
}
