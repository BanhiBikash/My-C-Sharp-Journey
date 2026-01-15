using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a password.");
            //string pass= Console.ReadLine();
            //Console.WriteLine("Please confirm your password.");
            //string Cpass= Console.ReadLine();

            //if (pass.Length<6)
            //{
            //    Console.WriteLine("Password must be atleast 6 chars long.");
            //}
            //else
            //{
            //    if (pass.Equals(Cpass)) {
            //        Console.WriteLine("Passwords match");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Passwods don't match.");
            //    }
            //}
            //--------------------------------------

            //int[] arr = { 1, 2, 3 };

            //arr.Append(6);

            //Console.WriteLine($"Length of array is {arr.Length}.");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[] numbers = new int[7];

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter the value for member {i+1}.\nInput-");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("The entered array is...");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Member no. {i+1} is->{numbers[i]}");
            //}

            //int j = 0;

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine($"Member no. {++j} is->{num}");
            //}
            //-------------------------------------------------

            //char[] chars = new char[] { 'a', 'b', 'c', 'd', 'a'};
            //char[] nChar = new char[chars.Length] ;

            //nChar= Array.Sort(chars) ;

            //Console.WriteLine(chars.Sort());

            int[] dta = new int[] { 1, 4, 23, 7, 3, 6, 2};
            Array.Sort(dta);    //makes change in original array and returns void
            foreach (int i in dta)
            {
                Console.Write($" {i}");
            }
            String str = "She is Ram.";
            Console.WriteLine($"\n {str.Replace("She","He")}"); //returns a new string

            Console.WriteLine(String.Join("-",dta)); //Converting an arrray to a string "-" will be present between diffrent arrays

            Console.ReadLine(); 
        }
    }
}
