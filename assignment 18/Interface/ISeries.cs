using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.Interface
{
    internal interface ISeries
    {
        //1.signature for property
        public int current { get; set; }

        //2.signature for method
        public void GetNext();
        public void Reset()
        {
            current = 0;
        }
    }
}
