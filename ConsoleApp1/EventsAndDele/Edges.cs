using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Edges
    {
        public void OnHammering(Object obj, EventArgs args)
        {
            Console.WriteLine("Edges are flattened..");
        }
    }
}
