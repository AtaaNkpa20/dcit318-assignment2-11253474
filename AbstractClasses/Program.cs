using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public abstract double GetArea();
        
        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {GetType().Name} with area: {GetArea():F2}");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetRadius()
        {
            return radius;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine("Circle Details:");
            Console.WriteLine($"Radius: {circle.GetRadius()}");
            Console.WriteLine($"Area: {circle.GetArea():F2}");
            
            Console.WriteLine();
            
            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Width: {rectangle.GetWidth()}, Height: {rectangle.GetHeight()}");
            Console.WriteLine($"Area: {rectangle.GetArea():F2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}