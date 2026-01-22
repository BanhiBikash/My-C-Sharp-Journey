using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LINQ1
{
    internal class Update
    {
        //created connection instance
        DataClasses1DataContext dc = new DataClasses1DataContext();

        enum Choices
        {
            ById = 1,
            ByStandard,
            BySection,
            exit
        }

        enum UpdateCoice
        {
            Name=1,
            Gender,
            DOB,
            Standard,
            Section,
            Roll
        }

        private bool UpdateMethod(IEnumerable<Student> query)
        {
            bool update = false ;

            Console.WriteLine("\nRecords found:\n");
            foreach (Student student in query)
            {
                Console.WriteLine($"\nId:{student.Id}  Name:{student.name}  Gender:{student.gender}  DOB:{student.dob}  Standard:{student.standard}  Section:{student.section}  Roll:{student.roll}");
            }


            Console.WriteLine("\nEnter the following for changing\n1 for name\n2 for gender\n3 for dob\n4 for standard\n5 for section\nand 6 for roll\n\nEnter 0 for cancelling");
            if (int.TryParse(Console.ReadLine(), out int uc))
            {

                switch (uc)
                {
                    case (int)UpdateCoice.Name:
                        Console.WriteLine("\nEnter new name:");
                        string newName = Console.ReadLine();

                        if (!string.IsNullOrEmpty(newName))
                        {
                            try
                            {
                                query.ToList().ForEach(s => s.name = newName);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\n" + e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("\nExiting update.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nName cannot be empty.");
                        }
                        break;

                    case (int)UpdateCoice.DOB:
                        Console.WriteLine("\nEnter new dob in dd-MM-yyyy format:");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newDob))
                        {
                            foreach (Student s in query)
                            {
                                s.dob = newDob;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid date format.");
                        }
                        break;

                    case (int)UpdateCoice.Gender:

                        Console.WriteLine("\nPlease enter gender..Male or Female");
                        string gender = Console.ReadLine();

                        //gender is valid
                        if (gender.Trim().ToLower().Equals("male") || gender.Trim().ToLower().Equals("female"))
                        {
                            foreach (Student s in query)
                            {
                                s.gender = gender;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input for gender");
                        }

                        break;

                    case (int)UpdateCoice.Standard:

                        Console.WriteLine("\nPlease enter a standard");

                        //gender is valid
                        if (int.TryParse(Console.ReadLine(), out int std) && std > 0 && std < 13)
                        {
                            foreach (Student s in query)
                            {
                                try
                                {
                                    s.standard = std;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("\n" + e.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("\nExiting update.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input for standard");
                        }

                        break;

                    case (int)UpdateCoice.Roll:

                        Console.WriteLine("\nPlease enter a roll");

                        //gender is valid
                        if (int.TryParse(Console.ReadLine(), out int roll) && roll > 0 && roll < 41)
                        {
                            foreach (Student s in query)
                            {
                                s.roll = roll;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input for roll");
                        }

                        break;

                    case (int)UpdateCoice.Section:

                        Console.WriteLine("\nPlease enter a section");
                        string Section = Console.ReadLine();

                        //gender is valid
                        if (Section.Trim().ToLower().Equals("a1") || Section.Trim().ToLower().Equals("a2") || Section.Trim().ToLower().Equals("a3") || Section.Trim().ToLower().Equals("a4") || Section.Trim().ToLower().Equals("a5"))
                        {
                            foreach (Student s in query)
                            {
                                s.section = Section;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input for section");
                        }

                        break;


                }

                try
                {
                    //submit changes to database
                    dc.SubmitChanges();
                    update = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n"+e.Message);
                    update = false;
                }
                finally
                {
                    Console.WriteLine("Moved out of database");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid integer choice.");
            }
            return update;
        }

        //controlling method
        public void Control()
        {
            bool looping = true;

            while (looping)
            {
                Console.WriteLine("\nEnter 1 to update via id\n2 by standard\n3 by section\n4 by exit");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice>0 && choice<5)
                {
                    switch (choice)
                    {
                        
                        //id insertion
                        case (int)Choices.ById:
                            try
                            {
                                foreach (Student st in dc.Students)
                                {
                                    Console.WriteLine($"\nId:{st.Id}  Name:{st.name}  Gender:{st.gender}  DOB:{st.dob.ToString("dd-MMM-yyyy")}  Standard:{st.standard}  Section:{st.section}  Roll:{st.roll}");
                                    
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\n" + e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("\nData fetch action from database completed");
                            }

                            Console.WriteLine("\nEnter the id of the student to be updated:");

                            if (int.TryParse(Console.ReadLine(),out int id))
                            {
                                var query = from Student in dc.Students where Student.Id == id select Student;
                                
                                //student found
                                if (query != null)
                                {
                                    //sending to update method
                                    bool action = UpdateMethod(query);
                                    if (action) {
                                        Console.WriteLine("\nSuccessfully updated record.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n....Failed to update");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo student found with the given id.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid id input. Please enter a valid integer id.");
                            }

                                break;

                        case (int)Choices.ByStandard:

                            Console.WriteLine("\nPlease enter Standard:");

                            //standard is valid
                            if (int.TryParse(Console.ReadLine(), out int std) && std > 0 && std < 13)
                            {
                                var query = from Student in dc.Students where (Student.standard == std) select Student;

                                if (query != null)
                                {

                                    bool action = UpdateMethod(query);
                                    if (action)
                                    {
                                        Console.WriteLine("\nSuccessfully updated record(s).");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n....Failed to update");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nNo student found with the given standard.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter corrected standard");
                            }
                                break;

                        case (int)Choices.BySection:


                            Console.WriteLine("\nPlease enter Standard:");

                            //standard is valid
                            if (int.TryParse(Console.ReadLine(), out int stnd) && stnd > 0 && stnd < 13)
                            {
                                Console.WriteLine("\nPlease enter Section:");
                                string Section = Console.ReadLine();

                                if (Section.Trim().Equals("A1") || Section.Trim().Equals("A2") || Section.Trim().Equals("A3") || Section.Trim().Equals("A4") || Section.Trim().Equals("A5"))
                                {

                                    var query = from Student in dc.Students where (Student.standard == stnd && Student.section == Section) select Student;

                                    if (query != null)
                                    {

                                        bool action = UpdateMethod(query);
                                        if (action)
                                        {
                                            Console.WriteLine("\nSuccessfully updated record(s).");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n....Failed to update");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nNo student found with the given standard and section.");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter corrected standard");
                            }
                            break;

                        //exit case
                        case (int)Choices.exit: 
                            looping = false; 
                            break;

                            //no need of default because of input validation
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease enter an integer between 1 and 4.");
                }
            }
        }
    }
}