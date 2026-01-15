using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaInheritance
{
    public class Circle:Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Enter the radius.");
            if(double.TryParse(Console.ReadLine(), out double k))
            {
                r = k;
                return 3.14 * r * r;
            }
            else
            {
                Console.WriteLine("Please enter valid radius");
                Console.ReadLine();
                return 0;
            }
        }

     
    }
    
    public class Square : Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Please enter the length of side.");
            if(double.TryParse(Console.ReadLine(),out double k))
            {
                return k * k;
            }
            else
            {
                Console.WriteLine("Please enter valid side length");
                Console.ReadLine();
                return 0;
            }
        }
    }

    public class Rectangle : Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Please enter the length and breadth respectively.");

            if (double.TryParse(Console.ReadLine(), out double k))
            {
                l=k;

                if(double.TryParse(Console.ReadLine(),out double j))
                {
                    b = j;
                    return l * b;
                }
                else
                {
                    Console.WriteLine("Please enter valid side breadth");
                    Console.ReadLine();
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid side length");
                Console.ReadLine();
                return 0;
            }
        }
    }

    internal class Program
    {
        public enum Shape
        {
            Circle=1,Square,Rectangle
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter 1 to find area of Circle,\n2 for Square,\n3 for Rectangle");
            
            if(int.TryParse(Console.ReadLine(), out int k) && k<4 && k>0)
            {
                switch (k)
                {
                    case (int)Shape.Circle: Circle c = new Circle();
                       Console.WriteLine("Area of circle is "+c.GetArea()+".");
                        break;

                    case (int)Shape.Square: Square s = new Square();
                        Console.WriteLine("Area of square is "+s.GetArea()+".");
                        break;

                    case (int)Shape.Rectangle: Rectangle r = new Rectangle();
                        Console.WriteLine("Area of rectangle is " + r.GetArea() + ".");
                        break;

                    default: Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter correct input");
            }
        }
    }
}
