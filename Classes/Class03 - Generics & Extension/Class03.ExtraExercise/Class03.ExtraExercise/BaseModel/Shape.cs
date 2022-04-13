using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ExtraExercise
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public Shape(int id)
        {
            Id = id;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
