using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace paymentProgram
{
    internal class Program
    {
        enum Cards
        {
            Debit=1,Credit,LoopBreak
        }
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nEnter 1 for debit card,\n 2 for credit card,\n3 for exiting");
                if (int.TryParse(Console.ReadLine(), out int k))
                {

                    switch (k)
                    {
                        case (int)Cards.Debit:
                            DebitCard dc = new DebitCard();
                            dc.Control();
                            break;

                        case (int)Cards.Credit:
                            CreditCard cc = new CreditCard();
                            cc.Control();
                            break;

                        case (int)Cards.LoopBreak: loop = false;
                            break;

                        default: Console.WriteLine("\nPlease enter a valid input");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer input.");
                }
                }
            }
        }
    }

