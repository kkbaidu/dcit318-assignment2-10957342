using System;

namespace ProgrmaTwo 
{
    abstract class Shape {
        public abstract double GetArea();
    }

    class Circle : Shape 
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }

    class Rectangle : Shape
    {
        private double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            double area = length * width;
            return area;
        }
    }

    class ShapeProgram
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);
            Rectangle rectangle= new Rectangle(7, 8);

            Console.WriteLine("Circle Area: {0:0.00}", circle.GetArea());
            Console.WriteLine("Rectangle Area: {0:0.00}", rectangle.GetArea());
        }
    }
}