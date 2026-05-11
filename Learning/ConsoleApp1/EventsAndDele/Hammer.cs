using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //event publisher
            Hammer hammer = new Hammer();

            //event subscribers
            Nails nails = new Nails();
            Edges edges = new Edges();

            //registering event handlers to the event
            hammer.HammeringEvent += nails.OnHammering;
            hammer.HammeringEvent += edges.OnHammering;

            //starting the event
            hammer.Hammering();
        }
    }

    public class Hammer
    {
        public delegate void HammeringEventHandler(Object obj, EventArgs args);

        public event HammeringEventHandler HammeringEvent;

        public void Hammering() 
        {
            Console.WriteLine("Hammering...");
            Thread.Sleep(3000);
            Console.WriteLine("Hammerred...");

            //event is raised
            OnHammeringEvent();
        }

        public void OnHammeringEvent()
        {
            if (HammeringEvent != null)
            {
                HammeringEvent(this, new EventArgs());
            }
        }
    }
}
