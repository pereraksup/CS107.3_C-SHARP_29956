using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q4
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void DisplayInfo();
    }

    // Rectangle class
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public double Length
        {
            get => length;
            set => length = value;
        }
        public double Width
        {
            get => width;
            set => width = value;
        }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {Length} and width {Width}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }





    }


}
