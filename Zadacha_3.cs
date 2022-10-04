using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Point
    {
        int x, y;
        string title;

        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return title;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Назва точки: ");
            this.title = Console.ReadLine();
            Console.WriteLine("Ведiть координату X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть координату Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Кiлькiсть вершин вашої фiгури: ");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()

        {
            double Perim = 0;
            for (int i = 1; i < points.Length; i++)
            {
                Perim += this.LengthSide(points[i - 1], points[i]);
            }
            Perim += this.LengthSide(points[0], points[points.Length - 1]);
            return Perim;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Figure("");
            Console.WriteLine("Периметр фiгури= " + fig.CalculatePerimeter());
        }
    }
}


