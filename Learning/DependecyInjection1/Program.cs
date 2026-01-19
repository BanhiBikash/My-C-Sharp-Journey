using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection1
{
    internal class Hammer
    {
        public void use()
        {
            Console.WriteLine("\nHammering Nails! Bang.....");
        }
    }

    internal class Saw
    {
        public void use()
        {
            Console.WriteLine("\nSawing wood! Gr.......");
        }
    }

    internal class BuildHouse
    {
        public BuildHouse(Hammer h, Saw s)
        {
            try
            {
                h.use();
                s.use();
                Console.WriteLine("\n Yay! Our new home is ready!");
            }
            catch (Exception e) {
                Console.WriteLine("\n House isn't built! :(");
            }
            finally
            {
                Console.ReadLine();
            }     
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer h =new Hammer();
            Saw s  = new Saw();
            BuildHouse build = new BuildHouse(h, s);
        }
    }
}
