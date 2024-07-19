using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.Interface
{
    internal class SeriesByThree : ISeries
    {
        public int current { get; set; }
        public void GetNext()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
