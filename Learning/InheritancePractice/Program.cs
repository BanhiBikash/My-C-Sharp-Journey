using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Brand="", ModelName="";
            int Speed=0;
            bool loop = true;

            //speed
            while (loop)
            {
                Console.WriteLine("Please enter the speed of the vehicle.");

                if (int.TryParse(Console.ReadLine(), out int s))
                {
                    Speed = s;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter the correct speed.");
                }
            }

            //brand
            loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter the brand of the vehicle.");
                Brand = Console.ReadLine();

                if (!(Brand.Length==0))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a brand name.");
                }
            }

            //ModelName
            loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter the Model of the car.");
                ModelName = Console.ReadLine();

                if (!string.IsNullOrEmpty(ModelName))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter the model name.");
                }
            }


            try
            {
                Car c = new Car(ModelName, Brand, Speed);
                c.DisplayInfo();
                Console.ReadLine();
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
