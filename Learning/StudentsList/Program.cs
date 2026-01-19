using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("\nEnter the number of student data you want to enter.");

            //entering user data
            if(int.TryParse(Console.ReadLine(), out int n) && n>0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nEnter the student name, std and roll no. respectively for student number {i}.");

                    //creating student object to inject data
                    Student s = new Student();

                    s.Name =Console.ReadLine();
                    s.std =(int.TryParse(Console.ReadLine(),out int k))?k:0;  //either enters the number or enters 0
                    s.roll = (int.TryParse(Console.ReadLine(), out int z)) ? z : 0;  //either enters the number or enters 0

                    if(k!=0 && z != 0)//checking if valid data are entered
                    {
                        //data added to list
                        students.Add(s);
                    }
                    else
                    {
                        Console.WriteLine("\nWrong Data entered");
                    }
                }

                Console.WriteLine("\nEntered data is as follows:\n");
                foreach(Student st in students)
                {
                    Console.WriteLine("\nStudent Name:"+st.Name+" ,Std: "+st.std+" ,Roll:"+st.roll);
                }
            }
            else
            {
                Console.WriteLine("\nPlease eneter a correct number");
            }
        }
    }
}
