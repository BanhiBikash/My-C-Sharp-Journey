using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I am Back");
            Console.ReadLine();

            long Large = 8000000L;
            Console.WriteLine(Large);

            string Text= "8000000";
            Console.WriteLine(Convert.ToInt64(Text));

            int age = 25;
            string sentence = "My age is ";

            Console.WriteLine(sentence+age+".");

            int x = 98, y = 23;

            var z = x % y;
            Console.WriteLine(z);

            float f = 69 / 8F;
            Console.WriteLine("Write anything.");
            var h = Console.ReadLine();
            Console.WriteLine(f+h);


            //string format
            Console.WriteLine(string.Format("{0:0.00} {1}", f, h));

            double money= -100D / 7;
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));


            Console.WriteLine(money < 0 ? string.Format("-${0:0.00}",-money): string.Format("${0.00}", money));

            //TryParse Function


            Console.ReadLine();

        }
    }
}
