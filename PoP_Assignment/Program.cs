using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDone = false;
            int input = 0;
            Student student = new Student();
            bool validStudent = false;
            

            while (isDone == false)
            {
                Console.Clear();
                Console.WriteLine("Welcome to my PoP assignment. Please choose one of the functions below:\n" +
                "1. Fill the data of the student\n" +
                "2. View student and average score.\n" +
                "3. View student and city.\n" +
                "4. View student and full address.\n" +
                "5. View full information of student.\n" +
                "0. Exit program.\n\n");

                input = validateInput(input, "Please enter valid command input");

                switch (input)
                {
                    case 1:
                        int intInput = 0;
                        Console.Clear();
                        Console.WriteLine("Please enter students first name:");
                        student.FirstName=Console.ReadLine();
                        Console.WriteLine("Please enter students last name:");
                        student.LastName=Console.ReadLine();
                        Console.WriteLine("Please enter students number:");
                        student.StudentNumber=Console.ReadLine();
                        Console.WriteLine("Please enter the students age:");
                        student.Age = validateInput(input, "Please enter valid age");
                        Console.Clear();
                        Console.WriteLine("Now the student is created. Please enter the students Address information");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Please enter students street name:");
                        student.Address.Street=Console.ReadLine();
                        Console.WriteLine("Please enter students street number:");
                        student.Address.AddressNumber=validateInput(input,"Please enter valid street number");
                        Console.WriteLine("Please enter students city name:");
                        student.Address.City = Console.ReadLine();
                        Console.WriteLine("Please enter students Country name:");
                        student.Address.Country = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Student address updated. Now please enter the students school info");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Please enter how many grades does the student have: (please enter an integer number)");
                        student.ScoreInput(validateInput(input, "Please enter valid number of grades"));
                        student.CalculateProperties();
                        break;

                        case 2:
                        if (checkValidStudent(student)==true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Student {student.FullName} has average score of {student.AverageScore}.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The student data is not filled completely. Please fill again.");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        if (checkValidStudent(student) == true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Student {student.FullName} is living in {student.Address.City}.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The student data is not filled completely. Please fill again.");
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        if (checkValidStudent(student) == true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Student {student.FullName} full address is: {student.FullAddress}.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The student data is not filled completely. Please fill again.");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
                        if (checkValidStudent(student) == true)
                        {
                            Console.WriteLine(student.ToString());
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The student data is not filled completely. Please fill again.");
                            Console.ReadLine();
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Thank you for testing the program.");
                        isDone= true;
                        break;
                    default:
                        break;
                }
            }



            
        }

        private static bool checkValidStudent(Student tested)
        {  
            if ((tested.FirstName != null && tested.FirstName!="")&&
                (tested.LastName != null && tested.LastName!="")&& 
                (tested.StudentNumber != null && tested.StudentNumber!="")&&
                 tested.Scores != null &&
                (tested.Address.Street!=null && tested.Address.Street!="")&&
                (tested.Address.City!=null && tested.Address.City!="")&&
                (tested.Address.Country!=null && tested.Address.Country!=""))
            {
                return true;
            }
            return false;
        }
        private static int validateInput(int input, string message)
        {
            bool inputValid = false;
            while (inputValid == false)
            {

                try
                {
                    input = int.Parse(Console.ReadLine());
                    inputValid = true;
                }
                catch
                {
                    Console.WriteLine(message);
                }

            }
            return input;
        }

    }
}
