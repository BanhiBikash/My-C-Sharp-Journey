using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentProgram
{
    interface IPayment
    {
        void ProcessPayment(float pay,float balance);
        void Refund(float refund);
    }
}
