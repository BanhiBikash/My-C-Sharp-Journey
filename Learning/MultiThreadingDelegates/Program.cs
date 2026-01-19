using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingDelegates
{
    internal class Program
    {
        //non-parametrized
        public void test1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("\nTest 1: "+i);
            }
            Console.WriteLine("\nEnd of test1.");
        }

        //parametrized
        public void test2(object max)
        {
            for(int i=0;i<= Convert.ToInt32(max); i++)
            {
                Console.WriteLine("\nTest 2:" + i);
                if (Convert.ToInt32(max) == 2)
                {
                    Console.WriteLine("\nThread2 going to sleep.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nThread2 coming out of sleep.");
                }
            }
            Console.WriteLine("\nEnd of test2.");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            ThreadStart obj = p.test1;
            Thread t1 = new Thread(obj);

            ParameterizedThreadStart obj2 = p.test2;
            Thread t2 = new Thread(obj2);

            //starting both threads
            t1.Start();
            t2.Start(12);
            Console.WriteLine("\nEnd of main.");
        }
    }
}
