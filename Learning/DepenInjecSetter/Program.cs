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
            Console.WriteLine("\nSawing wood! Grrrr.....");
        }
    }

    internal class BuildHouse
    {

        //set:-this is setting value of Hammer type value H to the Hammer instance h created in main
        //get:-this get method allows to use the Use() method
        public Hammer H
        {
            get; set;
        }

        public Saw S
        {
            get; set;
        }

        public void StartBuilding()
        {
            H.use();
            S.use();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer h = new Hammer();
            Saw s = new Saw();
            BuildHouse build = new BuildHouse();

            build.H = h;
            build.S = s;

            build.StartBuilding();
        }
    }
}
