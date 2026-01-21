using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Operations
    {
        enum Choices
        {
            ViewAll = 1,
            Add,
            Update,
            Delete,
            Exit
        }

        bool looping = true;

        public void Control()
        {
            while (looping)
            {
                Console.WriteLine("\nEnter 1 to view\n2 to add\n3 to update\n4 to delete\n5 to exit");

                //taking user input is integer
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    
                    switch(choice)
                    {
                        case (int)Choices.ViewAll:
                            View v = new View();
                            v.Control();
                            break;

                        case (int)Choices.Add:
                            Add a = new Add();

                            a.Control();
                            break;

                        case (int)Choices.Update:
                            Update u = new Update();
                            u.Control();
                            break;

                        case (int)Choices.Delete:
                            Delete d = new Delete();
                            d.Control();
                            break;

                        case (int)Choices.Exit:
                            looping = false;
                            break;

                        default:
                            Console.WriteLine("\nInvalid Input. Please enter a number between 1 and 5.");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nInvalid Input. Please enter a number between 1 and 5.");
                }
            }
        }
        
    }
}
