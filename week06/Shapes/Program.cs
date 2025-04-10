using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Shape Area Calculator!");
            List<Shape> shapes = new List<Shape>
            {
                new Square("Red", 4.5),
                new Rectangle("Blue", 6, 2.5),
                new Circle("Green", 3.2)
            };

            Console.WriteLine("\nCalculating areas of different shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape Color: {shape.GetColor()}, Computed Area: {shape.GetArea():F2} square units");
            }

            Console.WriteLine("\nThank you for using the Shape Area Calculator! Have a great day!");
        }
    }
}