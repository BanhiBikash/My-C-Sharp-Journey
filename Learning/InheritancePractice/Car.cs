using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class Car: Vehicle
    {
        public string ModelName;

        public Car(string ModelName,string brand, int speed): base(brand,speed)
        {
            this.ModelName = ModelName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand is {brand}, Speed is {speed}Km/h and Model Name is {ModelName}.");
        }
    }
}
