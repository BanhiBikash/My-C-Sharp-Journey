using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] items = {1,2,3,4,5,6 };

            //Console.WriteLine("Real Arrray");

            //foreach (int item in items)
            //{
            //    Console.Write($"{item} ");
            //}

            //Array.Reverse(items);

            //Console.WriteLine("\nReversed Arrray");

            //foreach (int item in items) {
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine("\n Sorting an array then reversing");

            //This is a comment:- Array.Reverse(Array.Sort(items));   this is not correct cause Array gives back no value but makes changes to the og object 


            //int[] items2 = { 1, 2, 3, 4, 5, 6 };

            //Array.Clear(items2, 3, 2);

            //foreach (int item in items2) {
            //    Console.WriteLine(item);
            //}

            int[] sreach = { 1,4,2,5,3,44,7,5,2};

            Console.WriteLine("Enter the number you are looking for.");

            String s= Console.ReadLine();

            if (int.TryParse(s, out int k))
            {
                int f = Array.IndexOf(sreach, k, 0); //arguments sreach-array k-no. we are looking for 0-index from which we are starting the search

                if (f >= 0)
                {
                    Console.WriteLine($"The number is found at {f + 1} place.");
                }
                else
                {
                    Console.WriteLine("number not found.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a correct input.");
            }
        }
    }
}
