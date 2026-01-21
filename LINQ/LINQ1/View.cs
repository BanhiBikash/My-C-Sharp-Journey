using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class View
    {
        enum Choices
        {
            ViewAll = 1,
            ViewByStandard,
            ViewByGender,
            ViewByDOB,
            Exit
        }

        public void Control()
        {
            Console.WriteLine("\nWelcome to the student database.");

            bool looping = true;

            while (looping)
            {

                Console.WriteLine("\nEnter 1 to view all\n2 to view by Standard\n3 to view by Gender\n4 toview by Date of Birth\n5 to exit");
                //taking user input is integer
                if (int.TryParse(Console.ReadLine(), out int choice))
                {

                    bool ShowData = false;

                    //creating a connection instance
                    DataClasses1DataContext dc = new DataClasses1DataContext();

                    switch (choice)
                    {
                        case (int)Choices.ViewAll:

                            try
                            {
                                foreach (Student st in dc.Students)
                                {
                                    Console.WriteLine($"\nName:{st.name}  Gender:{st.gender}  DOB:{st.dob.ToString("dd-MMM-yyyy")}  Standard:{st.standard}  Section:{st.section}  Roll:{st.roll}");
                                    ShowData = true;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\n" + e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("\nExecution Completed");
                            }

                            break;

                        case (int)Choices.ViewByStandard:

                            Console.WriteLine("\n\nPlease enter the standard you wish to view");

                            if (int.TryParse(Console.ReadLine(), out int std))
                            {
                                try
                                {
                                    //getting data from the table based on standard
                                    var data = from Student in dc.Students where (Student.standard == std) select Student;

                                    foreach (Student st in data)
                                    {
                                        Console.WriteLine($"\nName:{st.name}  Gender:{st.gender}  DOB:{st.dob.ToString("dd-MMM-yyyy")}  Section:{st.section}  Roll:{st.roll}");
                                        ShowData = true;
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("\n" + e.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("\nExecution Completed");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Standard Input");

                            }
                            break;

                        case (int)Choices.ViewByGender:

                            Console.WriteLine("\n\nPlease enter the gender you wish to view");
                            string gender = Console.ReadLine().ToLower();

                            if (gender.Trim().ToLower().Equals("male") || gender.Trim().ToLower().Equals("female"))
                            {
                                try
                                {
                                    //getting data from the table based on standard
                                    var data = from Student in dc.Students where (Student.gender == gender) select Student;

                                    foreach (Student st in data)
                                    {
                                        Console.WriteLine($"\nName:{st.name}  DOB:{st.dob.ToString("dd-MMM-yyyy")}  Standard:{st.standard}  Section:{st.section}  Roll:{st.roll}");
                                        ShowData = true;
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("\n" + e.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("\nExecution Completed");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter either male or female.");

                            }
                            break;

                        case (int)Choices.ViewByDOB:

                            Console.WriteLine("\n\nPlease enter the Date of reference you wish to view, younger students will be shown.");

                            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                            {
                                try
                                {
                                    //getting data from the table based on standard
                                    var data = from Student in dc.Students where (Student.dob >= date) select Student;

                                    foreach (Student st in data)
                                    {
                                        Console.WriteLine($"\nName:{st.name}  Gender:{st.gender}  DOB:{st.dob.ToString("dd-MMM-yyyy")}  Standard:{st.standard}  Section:{st.section}  Roll:{st.roll}");
                                    }
                                    ShowData = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("\n" + e.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("\nExecution Completed");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Date");

                            }
                            break;

                        case (int)Choices.Exit:
                            looping = false;
                            break;

                        default:
                            Console.WriteLine("\nInvalid Choice");
                            return;
                    }

                    //show this message if no data found only if the choice is not exit
                    if (!ShowData && choice != (int)Choices.Exit)
                    {
                        Console.WriteLine("\n\n...No data found....\n\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input");
                }
            }
        }
    }
}
