using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Rectangle
    {
        double Side1, Side2;

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
       
        public double AreaCalculator() {
            return Side1 * Side2;
        }
        public double PerimeterCalculator()
        {
            return (Side1+Side2)*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть 1 сторону");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть 2 сторону");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle Rect = new Rectangle(side1,side2);
            Console.WriteLine("Площа = "+Rect.AreaCalculator());
            Console.WriteLine("Периметр = "+Rect.PerimeterCalculator());
        }
    }
}
