using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Add
    {

        public void Control()
        {
            Console.WriteLine("\nWelcome to the student database.Enter the details as told.");

            bool looping = true;

            while (looping)
            {
                Console.WriteLine("\nEnter Name:");
                string name = Console.ReadLine();

                //name is valid
                if(!string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("\nPlease enter gender..Male or Female");
                    string gender = Console.ReadLine();

                    //gender is valid
                    if (gender.Trim().ToLower().Equals("male") || gender.Trim().ToLower().Equals("female"))
                    {
                        Console.WriteLine("\nPlease enter Date of Birth in dd-MM-yyyy format:");

                        //dob is valid
                        if (DateTime.TryParse(Console.ReadLine(),out DateTime date)){

                            Console.WriteLine("\nPlease enter Standard:");

                            //standard is valid
                            if(int.TryParse(Console.ReadLine(),out int std) && std>0 && std<13)
                            {

                                Console.WriteLine("\nPlease enter Section:");
                                string Section = Console.ReadLine();
                                //section is valid
                                if (Section.Trim().ToLower().Equals("a1") || Section.Trim().ToLower().Equals("a2") || Section.Trim().ToLower().Equals("a3") || Section.Trim().ToLower().Equals("a4") || Section.Trim().ToLower().Equals("a5"))
                                {

                                    Console.WriteLine("\nPlease enter Roll no. :");

                                    //roll is valid
                                    if (int.TryParse(Console.ReadLine(), out int roll) && roll > 0 && roll < 41)
                                    {
                                        //creating Student object
                                        Student st = new Student();

                                        //assigning properties
                                        st.name= name;
                                        st.gender=gender;
                                        st.dob=date;
                                        st.standard=std;
                                        st.section=Section;
                                        st.roll=roll;

                                        DataClasses1DataContext dc = new DataClasses1DataContext();

                                        //attempting to add student to database
                                        try
                                        {
                                            dc.Students.InsertOnSubmit(st);
                                            dc.SubmitChanges();
                                            Console.WriteLine("\nStudent added successfully.");
                                        }
                                        catch(Exception e)
                                        {
                                            Console.WriteLine("\nAn error occurred while adding the student: " + e.Message);
                                        }
                                        finally
                                        {
                                            Console.WriteLine("\nExecution done,Enter 1 to add more or anything else to exit");
                                            string input = Console.ReadLine();

                                            //deciding to loop or not
                                            if (input.Trim().Equals("1"))
                                            {
                                                looping = true;
                                            }
                                            else
                                            {
                                                looping = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nInvalid Roll no., Please enter a number between 1 and 40.");
                                        return;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid Section. Please enter a section between A1 and A5.");
                                    return;
                                }

                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Standard. Please enter a number between 1 and 12.");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Date format. Please try again.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter Male or Female");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("\nName cannot be empty. Please try again.");
                    return;
                }
            }
        }
    }
}
