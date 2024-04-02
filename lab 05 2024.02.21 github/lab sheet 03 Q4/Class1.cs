using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q4

{
    // Circle class
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            // The perimeter of a circle is its circumference
            return 2 * Math.PI * Radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {Radius}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Circumference: {Perimeter()}");
        }
    }

    class Program
    {
        static void Main()
        {
            // a) Create an instance of the Rectangle class
            Rectangle rectangle = new Rectangle(5, 3);
            // b) Display the shape information for the rectangle
            rectangle.DisplayInfo();

            // c) Create an instance of the Circle class
            Circle circle = new Circle(4);
            // d) Display the shape information for the circle
            circle.DisplayInfo();
        }
    }

}
