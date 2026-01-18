using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MultiThreading1
{
    internal class Program
    {
        public void Count1()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nThread 1: "+i);
            }
        }
        public void Count2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nThread 2: " + i);

                if (i == 3)
                {
                    Console.WriteLine("\nThread2 going to sleep.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nThread2 is awakening.");
                }
            }
        }
        public void Count3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nThread 3: " + i);
            }
        }
        static void Main(string[] args)
        {
            Program p=new Program();

            Thread t1 = new Thread(p.Count1);
            Thread t2 =new Thread(p.Count2);
            Thread t3=  new Thread(p.Count3);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
