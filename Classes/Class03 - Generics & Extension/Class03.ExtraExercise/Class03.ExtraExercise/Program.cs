// See https://aka.ms/new-console-template for more information
using Class03.ExtraExercise;
using Class03.ExtraExercise.Models;
using Class03.ExtraExercise.ShapesDB;

Console.WriteLine("============= SHAPES EXERCISE =============");
//Create a class Shape that has Id and methods GetArea and GetPerimeter
//Create a class Circle, with property radius that inherits from Shape.
//Create a class Rectangle, with properties sideA and sideB that inherits from Shape.
//Create a generic Db that holds a list of generic objects, that have a type that inherits from Shape.
//Create methods in the generic db that print the areas and perimeters of all shapes in the list.
//Create generic db for both types and call the methods of the db.
//Add extension methods for Circle and Rectangle, that print info for these types.

ShapesDataBase<Circle> circleDatabase = new ShapesDataBase<Circle>(new List<Circle>
{
    new Circle(1, 2.5),
    new Circle(2, 1.5),
    new Circle(3, 2),
    new Circle(4,3),
    new Circle(5, 5),
});

ShapesDataBase<Rectangle> rectangleDatabase = new ShapesDataBase<Rectangle>(new List<Rectangle>
{
    new Rectangle(1, 2,3),
    new Rectangle(2, 1.5,2.5),
    new Rectangle(3, 2,4),
    new Rectangle(4,3,5),
    new Rectangle(5, 5,5),
});

Console.WriteLine("\nCIRCLES AREA");
circleDatabase.PrintArea();
Console.WriteLine("CIRCLES PERIMETER");
circleDatabase.PrintPerimeter();
Console.WriteLine("\nRECTANGLES AREA");
rectangleDatabase.PrintArea();
Console.WriteLine("RECTANGLES PERIMETER");
rectangleDatabase.PrintPerimeter();

Console.WriteLine("\n===============================USING EXTENSION METHOD=================================");

foreach (Circle circle in circleDatabase.ListOfShapes)
{
    circle.PrintCircleInfo();
}

Console.WriteLine("\n===============================USING EXTENSION METHOD=================================");

foreach (Rectangle rectangle in rectangleDatabase.ListOfShapes)
{
    rectangle.PrintRectangleInfo();
}



Console.ReadLine();