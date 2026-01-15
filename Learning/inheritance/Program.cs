using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance


{
    internal class Program: Calculations
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Program c = new Program();
            bool loop = true;

            while (loop) {
                Console.WriteLine("Enter 1 to add\n2 to subtract");
                
                if(int.TryParse(Console.ReadLine(), out int k)){
                    loop = false;
                    switch (k)
                    {

                        case 1:Console.WriteLine("Please enter both numbers");
                                int.TryParse(Console.ReadLine(), out int a);
                                int.TryParse(Console.ReadLine(), out int b);
                                Console.WriteLine("The sum is "+c.sum(a,b));
                            Console.ReadLine();
                                break;

                        case 2:
                            Console.WriteLine("Please enter both numbers");
                            int.TryParse(Console.ReadLine(), out int e);
                            int.TryParse(Console.ReadLine(), out int d);
                            Console.WriteLine("The difference is "+c.diff(e,d));
                            Console.ReadLine();

                            break;

                        default: Console.WriteLine("Please enter from the choices given.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter numbers only");
                }
            }
        }
    }
}
