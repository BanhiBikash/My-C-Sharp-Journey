using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyinjection
{
    public interface Tools
    {
         void useHammer(Hammer h);
         void useSaw(Saw s);
    }

    public class Hammer
    {
        public void use()
        {
            Console.WriteLine("\nHammering Nails! Bang........");
        }
    }

    public class Saw
    {
        public void use()
        {
            Console.WriteLine("\nSawing woods! Grrr........");
        }
    }

    public class Builder : Tools
    {
        Hammer h;
        Saw s;

         public void useHammer(Hammer h)
        {
            this.h = h;
        }

          public void useSaw(Saw s)
        {
            this.s = s;
        }

        public void BuildHouse()
        {
            h.use();
            s.use();
            Console.WriteLine("\nYay! Our house is built!..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder build = new Builder();
            Hammer h = new Hammer();
            Saw s = new Saw();


            build.useHammer(h);
            build.useSaw(s);
            build.BuildHouse();
        }
    }
}
