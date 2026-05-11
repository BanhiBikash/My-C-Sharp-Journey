using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_DelegatesBasic
{
    public class Subscriber
    {
            public void OnMyEvent(string message)
            {
                Console.WriteLine($"Subscriber received message: {message}");
        }
    }
}
