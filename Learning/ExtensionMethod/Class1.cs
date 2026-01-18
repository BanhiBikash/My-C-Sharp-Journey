using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //creating a Exception class of our own
    class NewException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "\nCannot convert empty string.";
            }
        }
    }
    static class ExtensionCLass
    {
        public static void mul(this Original x,int a, int b)
        {
            Console.WriteLine("\nThe product of {0} and {1} is {2}.",a,b,(a*b));
            x.say();
            Console.ReadLine();
        }

        public static int Factorial(this Int32 i)
        {
            int f = 1;
            if (i != 0)
            { 
                while (i > 0)
                {
                    f = f * i--;
                }
            }
            return f;
        }

        public static string ToProper(this string s)
        {
            string newStr = "";

            try
            {
                if (s.Trim().Length != 0)
                { //converting entire to string to lower case first
                    s = s.ToLower();
                    string[] oldArray = s.Split(' ');

                    //making the first letter capital
                    foreach (string x in oldArray)
                    {
                        char[] word = x.ToCharArray();
                        word[0] = Char.ToUpper(word[0]);

                        //we use a constructor in string class which coverts a char array into a string
                        newStr += " " + new string(word);
                    }
                }
                else
                {
                    throw new NewException();Console.ReadLine();
                }
            }
            catch(NewException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) 
            {
                    Console.WriteLine("h");
            }
            finally
            {
                Console.WriteLine("\nThe string operations are done.");
            }
            return newStr.Trim();
        }
    }


}
