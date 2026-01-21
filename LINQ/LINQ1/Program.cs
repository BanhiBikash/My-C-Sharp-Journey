using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Program:Operations
    {
        static void Main(string[] args)
        {
            ArrayManipulation am = new ArrayManipulation();
            //am.ArrayControl();

            //sending control to ops
            Operations op = new Operations();
            op.Control();

        }
    }
}
