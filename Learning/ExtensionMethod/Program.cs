using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Original
    {
        protected void add(int a,int b)
        {
            Console.WriteLine("\nThe sum is " + (a + b));
            Console.ReadLine();
        }

        public void say()
        {
            Console.WriteLine("\nWe are in Original class.");
        }
    }
    internal class Program:Original
    {
        static void Main(string[] args)
        {
            Program o = new Program();
            Action<int, int> obj = o.add;
            obj += o.mul;
            obj(3, 5);
        }
    }
}
