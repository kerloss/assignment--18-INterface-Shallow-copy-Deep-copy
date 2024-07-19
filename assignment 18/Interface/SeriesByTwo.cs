using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.Interface
{
    internal class SeriesByTwo : ISeries
    {
        public int current { get; set; } //first time current will be 0 due to premeter less ctor

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
