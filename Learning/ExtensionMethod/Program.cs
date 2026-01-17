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
            //using delegate predefined Action
            Program o = new Program();
            Action<int, int> obj = o.add;

            //adding extension to class
            obj += o.mul;
            obj(3, 5);

            //adding extension to struct Int32
            int i = 5;
            Console.WriteLine("\n Factorial of {0} is {1}.",i,i.Factorial());

            //adding extension to string sealed class
            string str = "hI, I aM bAnHi.";
            Console.WriteLine("\nOriginal sentence is: {0}\nCorrected sentence is: {1}",str,str.ToProper());
        }
    }
}
