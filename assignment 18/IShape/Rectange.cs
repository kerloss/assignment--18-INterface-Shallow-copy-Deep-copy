using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.IShape
{
    internal class Rectange : IRectangle
    {
        public double Length {  get; set; }

        public double Width {  get; set; }

        public Rectange(double length , double width)
        {
            Length = length;
            Width = width;
        }

        public double Area 
        {
            get
            {
                return Length * Width;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length = {Length} * Width = {Width} Area = {Area}");
        }
    }
}
