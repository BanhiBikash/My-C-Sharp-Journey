using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentProgram
{
    public class DebitCard:IPayment
    {
        float balance;
        public void ProcessPayment(float pay, float balance=0)
        {
            if(balance!=0)
            this.balance = balance;

            try
            {
                if (pay <= this.balance)
                {
                    this.balance = this.balance - pay;
                    Console.WriteLine("Payment successfull");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nYou don't have sufficient balance.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }

        }

        public void Refund(float refund)
        {
            balance = balance+refund;
            Console.WriteLine("Refund received");
        }

        public void ShowBalance()
        {
            Console.WriteLine("\nYour account balance is "+this.balance+".");
            Console.ReadLine();
        }

        public void Control()
        {
            bool loop = true;
            bool Dset = false;

            while(loop)
            {
                Console.WriteLine("\nEnter 1 for payment, 2 for refund, 3 to check balance\n...4 to exit....");
                int.TryParse(Console.ReadLine(), out int k);

                switch (k)
                {
                    case 1:

                        if (Dset)
                        {
                            Console.WriteLine("\nPlease enter amount to be paid.");
                            float.TryParse(Console.ReadLine(), out float payment);
                            ProcessPayment(payment);

                        }

                        if (!Dset)
                        {
                            Console.WriteLine("\nPlease enter your balance and amount to be paid respectively.");
                            float.TryParse(Console.ReadLine(), out float balance);
                            float.TryParse(Console.ReadLine(), out float payment);
                            ProcessPayment(payment, balance);

                            //SettingAttribute to true for future
                            Dset = true;

                        }

                        ShowBalance();
                        break;

                    case 2:
                        Console.WriteLine("\nPlease enter amount to be refunded.");
                        float.TryParse(Console.ReadLine(), out float refund);
                        Refund(refund);
                        break;

                    case 3:
                        ShowBalance();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default: Console.WriteLine("\nInvalid Input");
                        break;

                }

            }
        }
    }
}
