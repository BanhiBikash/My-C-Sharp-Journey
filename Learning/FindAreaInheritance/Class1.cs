using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaInheritance
{
    public abstract class Shape
    {
        protected double l, b, r;

        public abstract double GetArea();
    }
}
