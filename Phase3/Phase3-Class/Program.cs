using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUtility
{

    public class Inputs
    {
        public static int GetInt(string val)
        {
            int i=0;
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.WriteLine("Enter the " + val);
                    i = Convert.ToInt32(Console.ReadLine());
                    loop = false;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            return i;
        }

        public static string GetString(string val) {

            string name="";
            bool loop=true;

            while (loop)
            {
                try
                {
                    Console.WriteLine("Enter the "+val);
                    name = Convert.ToString(Console.ReadLine());
                    loop = false;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            return name; 
        }

        public static float GetFloat(string val) { 
            float f = 0F;
            bool loop = true;

            while (loop) {
                try
                {
                    Console.WriteLine("Enter the decimal number");
                    f = Convert.ToSingle(Console.ReadLine());
                    loop = false;

                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
            return f;
        }

        public static double GetDouble(string val) {
            double d = 0;
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.WriteLine("Enter the large decimal.");
                    d = Convert.ToDouble(Console.ReadLine());
                    loop = false;
                }
                catch (Exception e) { 
                    Console.WriteLine(e.Message);
                }
            }

            return d;
        }


    }
    internal class Program
    {
        struct Student
        {
            public string name;
            public int std,roll;
            public Student(string name,int std,int roll)
            {
                this.name = name;
                this.std = std;
                this.roll = roll;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(Inputs.GetString("name"), Inputs.GetInt("class"), Inputs.GetInt("roll"));

            Console.WriteLine($"name:-{student.name}\n class:-{student.std}\n roll:-{student.roll}");
        }
    }
}
