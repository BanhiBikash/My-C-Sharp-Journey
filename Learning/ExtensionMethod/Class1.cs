using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class ExtensionCLass
    {
        public static void mul(this Original x,int a, int b)
        {
            Console.WriteLine("\nThe product of {0} and {1} is {2}.",a,b,(a*b));
            x.say();
            Console.ReadLine();
        }
    }
}
