using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace SecondPro
{
    internal class SecondPro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is the SecondPro project.");

            Console.WriteLine("Please enter a string.");
            string inp = Console.ReadLine();
            Console.WriteLine($"You entered:" + inp);

            Console.WriteLine("Plesae enter a number.");

            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you hav entered is " + k);

            bool success = int.TryParse(Console.ReadLine(), out k);

            success? Console.WriteLine("You have entered " + k): Console.WriteLine("You have entred a wrong input.");
        }
    }
}
