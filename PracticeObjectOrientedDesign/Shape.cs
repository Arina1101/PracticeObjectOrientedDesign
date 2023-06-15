using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    interface IShape
    {
        double CalculateArea();
    }

    class Circle:IShape
    {
        double area = 0;

        public double Radius { get; set; }

        public Circle(double num)
        {
            Radius = num;
        }

        public double CalculateArea()
        {
            area = Math.PI * Radius * Radius;
            return area;
        }
    }

    class Square:IShape
    {
        double area = 0;
        public double SideLength { get; set; }

        public Square(double num)
        {
            SideLength = num;
        }

        public double CalculateArea()
        {
            area = SideLength * SideLength;
            return area;
        }
    }

    class Triangle : IShape
    {
        double area = 0;
        public double Bottom { get; set; }
        public double Height { get; set; }

        public Triangle(double num,double num2)
        {
            Bottom = num;
            Height = num2;
        }

        public double CalculateArea()
        {
            area = Bottom * Height / 2;
            return area;
        }
    }
}
