using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter a number");
            //    bool x= int.TryParse(Console.ReadLine(), out int k);

            //    if (x)
            //    {
            //        Console.WriteLine($"You entered number {k}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //}

            //    Console.WriteLine("Enter any decimal");
            //    bool y= double.TryParse(Console.ReadLine(), out double m);

            //   if (y)
            //    {
            //        Console.WriteLine($"You entered decimal {string.Format("{0:0.00}", m)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //}

            //Let's Print tables
            //Console.WriteLine("Enter the number whose table you wish to see.");
            //if(int.TryParse(Console.ReadLine(), out int n)){

            //    for(int i = 1; i < 11; i++)
            //    {
            //        Console.WriteLine($"{n} x {i} = {n * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a number only.");
            //}

            string str = "Mohan said \"crack\"";

            Console.WriteLine(str);

            str = "Mohan said \"crack\"";

            Console.Write(str);

            string str2= "C:\\Users\\Mohan\\Documents\\file.txt";
            Console.WriteLine(str2);

            str2= @"C:\Users\Mohan\Documents\file.txt";             //best
            Console.WriteLine(str2);

            int sum = 65;

            string result = $"The sum of 32 and 33 is {sum}";       //best

            Console.WriteLine(result);

            Console.WriteLine("The sum of 32 and 33 is {0}", sum);      //not reqired

            string a="Hello", b=", I am", c=" banhi.";

            Console.WriteLine(string.Concat(a,b,c));

            string ak = "";

            if (ak == "")
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Console.WriteLine("String is not empty.");
            }


            if (ak== string.Empty)
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Console.WriteLine("String is not empty.");
            }

            string ar = "This is a string";
            string ar2 = "This is a string2";

            if (ar.Equals(ar2))
            {
                Console.WriteLine("The strings are equal");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");              
            }

                ///length is a very important function
            for (int i=0;i<ar.Length;i++)
            {
                Console.Write(ar[i]);
                Thread.Sleep(200);
            }
        }
    }
}
