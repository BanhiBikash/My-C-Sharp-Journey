using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_DelegatesBasic
{
    public class Program
    {
        //public delegate void MyDelegate(string str);

        public event Action<string> MyEvent;

        static void Main(string[] args)
        {
            //publisher
            Program program = new Program();

            //subscriber
            Subscriber subscriber = new Subscriber();

            program.MyEvent += subscriber.OnMyEvent;
            program.Publisher();
        }

        public void Publisher()
        {
            Console.WriteLine("Enter a message to publish:");
            string message = Console.ReadLine();

            //raise the event
            OnMyEvent(message);
        }

        public void OnMyEvent(string message)
        {
            MyEvent?.Invoke(message);
        }
    }
}
