using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.IShape
{
    internal interface IShape
    {
        double Area { get; } //property to get the area of that shape

        void DisplayShapeInfo(); //method to Display Shape Info
    }
}
