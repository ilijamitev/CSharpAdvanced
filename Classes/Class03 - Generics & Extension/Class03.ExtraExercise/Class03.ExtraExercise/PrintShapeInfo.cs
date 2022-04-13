using Class03.ExtraExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ExtraExercise
{
    public static class PrintShapeInfo
    {
        public static void PrintRectangleInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"\nThe shape with id {rectangle.Id} is of type {rectangle.GetType().Name}.\nIt has sides of {rectangle.SideA} cm and {rectangle.SideB} cm.\nIts perimeter is {rectangle.GetPerimeter()} cm.\nIt's area is {rectangle.GetArea()} cm2.");
        }
        public static void PrintCircleInfo(this Circle circle)
        {
            Console.WriteLine($"\nThe shape with id {circle.Id} is of type {circle.GetType().Name}.\nIt has radius of {circle.Radius} cm.\nIts perimeter is {circle.GetPerimeter()} cm.\nIt's area is {circle.GetArea()} cm2.");
        }
    }
}
