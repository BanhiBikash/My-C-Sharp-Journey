using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class ArrayManipulation
    {
        public void ArrayControl()
        {
            //sort and filter a number array
            int[] Arr = { 3, 4, 24, 6, 3, 7, 4, 6, 3, 8, 3, 7, 6, 9 };

            var NewArr = from x in Arr where x > 5 orderby x descending select x;

            foreach (int x in NewArr)
            {
                Console.WriteLine($"\n{x}");
            }

            //performing operations in a string array
            string[] names = { "Ankit", "Rahul", "Riyaz", "Prem", "Sid" };

            var filterNames = from name in names where name.Contains("i") orderby name ascending select name;

            foreach (string name in filterNames)
            {
                Console.WriteLine($"\n{name}");
            }

        }
    }
}
