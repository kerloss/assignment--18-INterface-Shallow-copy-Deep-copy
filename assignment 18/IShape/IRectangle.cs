using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.IShape
{
    internal interface IRectangle : IShape
    {
        double Length { get; }
        double Width { get; }
    }
}
