using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class Vehicle
    {
        public string brand;
        public int speed;
        public Vehicle(string brand, int speed) {
            this.brand= brand;
            this.speed= speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand} and Speed: {speed}");
        }
    }
}
