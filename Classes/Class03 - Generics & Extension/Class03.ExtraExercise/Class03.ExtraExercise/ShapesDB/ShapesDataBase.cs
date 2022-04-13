using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ExtraExercise.ShapesDB
{
    public class ShapesDataBase<T> where T : Shape
    {
        public List<T> ListOfShapes { get; set; }
        public ShapesDataBase(List<T> listOfShapes)
        {
            ListOfShapes = listOfShapes;
        }
        public void PrintArea()
        {
            foreach (T shape in ListOfShapes)
            {
                Console.WriteLine($"The {shape.GetType().Name} with id {shape.Id} has area of {shape.GetArea()} cm2.");
            }
        }
        public void PrintPerimeter()
        {
            foreach (T shape in ListOfShapes)
            {
                Console.WriteLine($"The {shape.GetType().Name} with id {shape.Id} has perimeter of {shape.GetPerimeter()} cm.");
            }
        }

    }
}
