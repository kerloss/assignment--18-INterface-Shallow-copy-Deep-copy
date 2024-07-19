using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.IShape
{
    internal class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius of circle = {Radius}");
            Console.WriteLine($"Area of circle = {Area}");
        }
    }
}
