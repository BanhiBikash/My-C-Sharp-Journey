using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2
{

    class Inputs
    {
        public static int[] GetArray()
        {
            Console.WriteLine("Enter the number of numbers you wish to input.");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Please enter a number.");
                return null;
            }
            else
            {
                int[] num = new int[k];
                Console.WriteLine($"Start entering {k} numbers one by one.");
                for (int i = 0; i < num.Length; i++)
                {
                    if (!int.TryParse(Console.ReadLine(), out int j))
                    {
                        Console.WriteLine("Please enter a number.");
                        break;
                    }
                    else
                    {
                        num[i] = j;
                    }
                }

                return num;
            }
        }
    }

    class Calculations
    {
        public static int SumOfArray(int[] array)
        {
            int sum = 0;

            foreach(int x in array)
            {
                sum += x;
            }

            return sum;
        }
    }

    class Excercise
    {
        public static void ConvertToString()
        {
                
            int x=0;
            bool k = true;

            while (k)
            {

            try
            { 
                    Console.WriteLine("Enter a number");
                    x = Convert.ToInt32(Console.ReadLine());
                    k = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Only Enter numbers.");
            }
            catch (OverflowException)

            {
                Console.WriteLine("Please enter a number smaller than 2 billion!.");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);            
            }

            Console.WriteLine("The number entered is "+x+" or invalid.");

            }
                string f;
                try
                {
                    f = Convert.ToString(x);
                    Console.WriteLine($"Integer-{x} has successfully been converted to string-{f}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            //int[] arr = Inputs.GetArray();

            //Console.WriteLine("Sum of Entered numbers is "+Calculations.SumOfArray(arr));

            // // convert to string

            Excercise.ConvertToString();
        }
    }
}
