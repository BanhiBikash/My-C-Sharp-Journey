using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Delete
    {
        enum Choices
        {
            id=1,
            standard,
            section,
            exit
        }
         public void Control()
        {
            bool looping = true;

            while (looping)
            {
                Console.WriteLine("\nEnter the the method to delete record:\n1 for id\n2 for standard\n3 for section\n4 to exit to main menu");

                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    //creating a connection instance
                    DataClasses1DataContext dc = new DataClasses1DataContext();

                    switch (choice)
                    {
                        case (int)Choices.id:

                            var data = from Student in dc.Students select Student;

                            foreach(Student st in data)
                            {
                                Console.WriteLine($"\nId: {st.Id}, Name: {st.name}, Standard: {st.standard}, Section: {st.section}");
                            }

                            Console.WriteLine("\nEnter the id to delete record:");
                            if(int.TryParse(Console.ReadLine(), out int id))
                            {
                                //check if record exists
                                var recordToDelete = dc.Students.SingleOrDefault(st => st.Id == id);

                                //if record found, delete it
                                if (recordToDelete != null)
                                {
                                    try 
                                    { 
                                        // Confirm deletion
                                        Console.WriteLine($"\nAre you sure you want to delete the record with id {id}? (y/n)");
                                        string confirmation = Console.ReadLine();

                                        if (confirmation.ToLower() != "y")
                                        {
                                            Console.WriteLine("\nDeletion cancelled.");
                                            break;
                                        }
                                        else
                                        {
                                            dc.Students.DeleteOnSubmit(recordToDelete);
                                            dc.SubmitChanges();
                                            Console.WriteLine("\nRecord deleted successfully.");

                                        }
                                    }
                                    catch (Exception ex) 
                                    {
                                        Console.WriteLine($"\nAn error occurred: {ex.Message}");
                                        break;
                                    }finally
                                    {
                                        Console.WriteLine("\nExecution complete.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nRecord not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid id input.");
                            }
                            break;

                        //standard deletion
                        case (int)Choices.standard:

                            // Implement deletion by standard logic here
                            Console.WriteLine("\nEnter the standard which you want to delete.");

                            //checking if the input is valid
                            if (int.TryParse(Console.ReadLine(),out int std) && std>0 && std<13)
                            {
                                data = from Student in dc.Students where (Student.standard == std) select Student;

                                //data is found
                                if (data != null)
                                {
                                    foreach(Student st in data)
                                    {
                                        Console.WriteLine($"\nId: {st.Id}, Name: {st.name}, Standard: {st.standard}, Section: {st.section}");
                                    }
                                    Console.WriteLine("\nAre you sure you want to delete all these records? (y/n)");
                                    string confirmation = Console.ReadLine();

                                    if(confirmation.ToLower() == "y")
                                    {
                                        //deleting records
                                        try
                                        {
                                            dc.Students.DeleteAllOnSubmit(data);
                                            dc.SubmitChanges();
                                            Console.WriteLine("\nRecords deleted successfully.");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"\nAn error occurred: {ex.Message}");
                                            break;
                                        }
                                        finally
                                        {
                                            Console.WriteLine("\nExecution complete.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nDeletion cancelled.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo records found for the given standard.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nenter a correct class.");
                            }
                                break;


                        case (int)Choices.section:
                            // Implement deletion by section logic here
                            Console.WriteLine("\nEnter the standard and section.");

                            //checking if the standard is valid
                            if (int.TryParse(Console.ReadLine(), out int std2) && std2 > 0 && std2 < 13)
                            {
                                string section = Console.ReadLine();
                                data = from Student in dc.Students where (Student.standard == std2 && Student.section==section) select Student;

                                //data is found
                                if (data != null)
                                {
                                    foreach (Student st in data)
                                    {
                                        Console.WriteLine($"\nId: {st.Id}, Name: {st.name}, Standard: {st.standard}, Section: {st.section}");
                                    }
                                    Console.WriteLine("\nAre you sure you want to delete all these records? (y/n)");
                                    string confirmation = Console.ReadLine();

                                    if (confirmation.ToLower() == "y")
                                    {
                                        //deleting records
                                        try
                                        {
                                            dc.Students.DeleteAllOnSubmit(data);
                                            dc.SubmitChanges();
                                            Console.WriteLine("\nRecords deleted successfully.");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"\nAn error occurred: {ex.Message}");
                                            break;
                                        }
                                        finally
                                        {
                                            Console.WriteLine("\nExecution complete.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nDeletion cancelled.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo records found for the given standard.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nenter a correct class.");
                            }

                            break;

                        case (int)Choices.exit:
                            looping = false;
                            break;

                        default:
                            Console.WriteLine("\nInvalid Input. Please enter a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                }
            }
        }
    }
}
