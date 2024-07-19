using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.Interface_Ex3
{
    internal class Airplane : Vichle, IFlyable, IMoveable
    {
        public void Backward()
        {
            Console.WriteLine("Backword implicitly");
        }

        public void Forward()
        {
            Console.WriteLine("Forward implicitly");
        }

        public void Left()
        {
            Console.WriteLine("Left implicitly");
        }

        public void Right()
        {
            Console.WriteLine("Right implicitly");
        }

        //void IMoveable.Backward()
        //{
        //    Console.WriteLine("Backword Explicitly");
        //}

        //void IMoveable.Forward()
        //{
        //    Console.WriteLine("Forward Explicitly");
        //}

        //void IMoveable.Left()
        //{
        //    Console.WriteLine("Left Explicitly");
        //}

        //void IMoveable.Right()
        //{
        //    Console.WriteLine("Right Explicitly");
        //}
    }
}
