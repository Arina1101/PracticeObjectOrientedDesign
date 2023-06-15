using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{

    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape square = new Square(3);
            IShape triangle = new Triangle(4,2);

            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();
            double triangleArea = triangle.CalculateArea();

            Console.WriteLine("円の面積: " + circleArea);
            Console.WriteLine("正方形の面積: " + squareArea);
            Console.WriteLine("三角形の面積:" + triangleArea);
        }
    }
}
