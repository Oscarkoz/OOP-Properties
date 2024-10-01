using System;

namespace Shapes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape triangle = new Triangle(6.5f, 3.2f);
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");

            Shape square = new Square(4.5f);
            Console.WriteLine($"Area of square: {square.CalculateArea()}");

            Shape anotherTriangle = new Triangle(2.3f, 4.5f);
            if (anotherTriangle is Triangle specificTriangle)
            {
                Console.WriteLine($"Specific triangle's area: {specificTriangle.CalculateArea()}");
            }

            Shape maybeSquare = anotherTriangle as Square;
            if (maybeSquare != null)
            {
                Console.WriteLine("This is a square!");
            }
            else
            {
                Console.WriteLine("This is not a square.");
            }
        }
    }

 
    abstract class Shape
    {
        public abstract float CalculateArea();
    }

 
    class Square : Shape
    {
        public float SideLength { get; }

        public Square(float sideLength)
        {
            SideLength = sideLength;
        }

        public override float CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

   
    class Triangle : Shape
    {
        public float BaseLength { get; }
        public float Height { get; }

        public Triangle(float baseLength, float height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override float CalculateArea()
        {
            return 0.5f * BaseLength * Height;
        }
    }
}
