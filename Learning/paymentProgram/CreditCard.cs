using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentProgram
{
    public class CreditCard:IPayment
    {
        float limit;
        public void ProcessPayment(float pay, float limit=0)
        {
            if(limit!=0)
            this.limit = limit;

            if (pay <= this.limit)
            {
                this.limit = this.limit - pay;
                Console.WriteLine("\nAmount is Paid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYou don't have sufficient credit limit left.");
            }
        }

        public void Refund(float refund)
        {
            limit = limit + refund;
            Console.WriteLine("\nAmount is refunded");
            Console.ReadLine();
        }

        public void ShowLimit()
        {
            Console.WriteLine("\nYour limit left is "+this.limit+".");
            Console.ReadLine();
        }

        public void Control()
        {
            bool loop = true;
            bool Cset = false;

            while (loop)
            {
                Console.WriteLine("\nEnter 1 for payment, 2 for refund, 3 to check balance\n...4 to exit....");
                int.TryParse(Console.ReadLine(), out int k);

                switch (k)
                {
                    case 1:

                        if (Cset)
                        {
                            Console.WriteLine("\nEnter the amount to be paid");
                            float.TryParse(Console.ReadLine(), out float pay);

                            ProcessPayment(pay);
                        }

                        if (!Cset)
                        {
                            Console.WriteLine("\nEnter your limit and amount to be paid.");
                            float.TryParse(Console.ReadLine(), out float limit);
                            float.TryParse(Console.ReadLine(), out float pay);

                            ProcessPayment(pay,limit);

                            //setting to true
                            Cset = true;
                        }

                        ShowLimit();
                        break;

                    case 2:
                        Console.WriteLine("\nPlease enter amount to be refunded.");
                        float.TryParse(Console.ReadLine(), out float refund);
                        Refund(refund);

                        ShowLimit();
                        break;

                    case 3: 
                        ShowLimit();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default: Console.WriteLine("\nPlease enter a valid input.");
                        break;
                }
            }
        }
    }
}
