using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ExtraExercise.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(int id, double radius) : base(id)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        public override double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }

    }
}
