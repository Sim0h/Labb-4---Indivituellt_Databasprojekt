using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Indivituellt_Databasprojekt.Models
{
    internal class Menu
    {

        public static void MenuStart()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t~~|| School Menu ||~~");
                Console.WriteLine("\t1. Show Personel");
                Console.WriteLine("\t2. Show Courses");
                Console.WriteLine("\t3. Show all Students");
                Console.WriteLine("\t4. Add Personel");
                Console.WriteLine("\t5. Show Specific Class");
                Console.WriteLine("\t6. Exit");

                Console.Write("\tEnter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\tYou selected Option 1");
                        Menu.Departments();
                        break;

                    case "2":
                        Console.WriteLine("\tYou selected Option 2");
                        Menu.Courses();
                        break;

                    case "3":
                        Console.WriteLine("\tYou selected Option 3");
                        Menu.ShowAllStudents();
                        break;
                    case "4":
                        Console.WriteLine("\tYou selected Option 4");
                        Menu.AddPersonel();
                        break;
                    case "5":
                        Console.WriteLine("\tYou selected Option 5");
                        Menu.ShowSpecificClass();
                        break;

                    case "6":
                        Console.WriteLine("\tExiting...");
                        return;

                    default:
                        Console.WriteLine("\tInvalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\tPress Enter to continue...");
                Console.ReadLine();
            }
        }
        

        public static void Departments()
        {
            using DBSchoolDbContext context = new DBSchoolDbContext();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tChoose which Department to show employees");
                Console.WriteLine("\t1. Teachers");
                Console.WriteLine("\t2. Principal");
                Console.WriteLine("\t3. Maintenance");
                Console.WriteLine("\t4. Kitchen staff");
                Console.WriteLine("\t5. Exit");

                Console.Write("\tEnter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var teacher = context.TblPersonals.Where(t => t.Occupation == "Teacher");
                            Console.WriteLine("\tList of Teachers:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblPersonal t in teacher)
                            {
                                Console.WriteLine($"\tPersonel ID: {t.PersonalId}");
                                Console.WriteLine($"\tFirst Name: {t.Fname}");
                                Console.WriteLine($"\tLast Name: {t.Lname}");
                                Console.WriteLine($"\tStarting Date: {t.StartWork}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        var principal = context.TblPersonals.Where(t => t.Occupation == "Principal");
                        Console.WriteLine("\tList of Principals:");
                        Console.WriteLine(new string('*', 30));
                        foreach (TblPersonal t in principal)
                        {
                            Console.WriteLine($"\tPersonel ID: {t.PersonalId}");
                            Console.WriteLine($"\tFirst Name: {t.Fname}");
                            Console.WriteLine($"\tLast Name: {t.Lname}");
                            Console.WriteLine($"\tStarting Date: {t.StartWork}");
                            Console.WriteLine(new string('-', 30));
                        }
                        break;

                    case "3":
                        Console.Clear();
                        var janitor = context.TblPersonals.Where(t => t.Occupation == "Janitor");
                        Console.WriteLine("\tList of Maintenance Personel:");
                        Console.WriteLine(new string('*', 30));
                        foreach (TblPersonal t in janitor)
                        {
                            Console.WriteLine($"\tPersonel ID: {t.PersonalId}");
                            Console.WriteLine($"\tFirst Name: {t.Fname}");
                            Console.WriteLine($"\tLast Name: {t.Lname}");
                            Console.WriteLine($"\tStarting Date: {t.StartWork}");
                            Console.WriteLine(new string('-', 30));
                        }
                        break;

                    case "4":
                        Console.Clear();
                        var lunch = context.TblPersonals.Where(t => t.Occupation == "Lunch Lady");
                        Console.WriteLine("\tList of Kitchen Staff:");
                        Console.WriteLine(new string('*', 30));
                        foreach (TblPersonal t in lunch)
                        {
                            Console.WriteLine($"\tPersonel ID: {t.PersonalId}");
                            Console.WriteLine($"\tFirst Name: {t.Fname}");
                            Console.WriteLine($"\tLast Name: {t.Lname}");
                            Console.WriteLine($"\tStarting Date: {t.StartWork}");
                            Console.WriteLine(new string('-', 30));
                        }
                        break;

                    case "5":
                        Console.WriteLine("\tExiting...");
                        return;



                }
                Console.WriteLine("\tPress Enter to continue...");
                Console.ReadLine();

            }

        }

        public static void Courses()
        {
            using DBSchoolDbContext context = new DBSchoolDbContext();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t1. Show Courses");
                Console.WriteLine("\t2. Exit");
                Console.Write("\tEnter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var courses = context.TblCourses.OrderBy(k => k.CourseName).ToList();
                            Console.WriteLine("\tList of Courses:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblCourse k in courses)
                            {
                                Console.WriteLine($"\tID: {k.CourseId}");
                                Console.WriteLine($"\tCourse Name: {k.CourseName}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("\tExiting...");
                        return;
                }
                Console.WriteLine("\tPress Enter to continue...");
                Console.ReadLine();
            }
        }

        public static void ShowAllStudents()
        {
            // saves first print out of a student into next sequence.. 

            using DBSchoolDbContext context = new DBSchoolDbContext();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tChoose how to order the Students");
                Console.WriteLine("\t1. First name decending");
                Console.WriteLine("\t2. First name acending");
                Console.WriteLine("\t3. Last name decending");
                Console.WriteLine("\t4. Last name acending");
                Console.WriteLine("\t5. Exit");

                Console.Write("\tEnter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var student = context.TblStudents.OrderByDescending(s => s.Fname).ToList();
                            Console.WriteLine("\tFirst name Decending:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblStudent s in student)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine($"\tClass: {s.Class}");
                                Console.WriteLine(new string('-', 30));
                            }
                            
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            var students2 = context.TblStudents.OrderBy(s => s.Fname);
                            Console.WriteLine("\tFirst name Acending:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblStudent s in students2)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine($"\tClass: {s.Class}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            var Students3 = context.TblStudents.OrderByDescending(s => s.Lname);
                            Console.WriteLine("\tLast name Decending:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblStudent s in Students3)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine($"\tClass: {s.Class}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }

                        break;

                    case "4":
                        {
                            Console.Clear();
                            var Students4 = context.TblStudents.OrderBy(s => s.Lname);
                            Console.WriteLine("\tLast name Acending:");
                            Console.WriteLine(new string('*', 30));
                            foreach (TblStudent s in Students4)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine($"\tClass: {s.Class}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("\tExiting...");
                        return;

                    default:
                        Console.WriteLine("\tInvalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\tPress Enter to continue...");
                Console.ReadLine();

            }



        }

        public static void ShowSpecificClass()
        {
            Console.Clear();
            using DBSchoolDbContext context = new DBSchoolDbContext();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tClass List:");
                var classes = context.TblStudents.Select(s => s.Class).Distinct().ToList();
                foreach (string className in classes)
                {
                    Console.WriteLine($"\tClass: {className}");
                }
                Console.WriteLine(new string('*', 30));
                Console.WriteLine("\tChoose Students in a Class");
                Console.WriteLine("\t1. ITP22");
                Console.WriteLine("\t2. MEDS17");
                Console.WriteLine("\t3. SUT23");
                Console.WriteLine("\t4. Exit");

                Console.Write("\tEnter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "ITP22");
                            Console.WriteLine("\tStudents in ITP22: ");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "MEDS17");
                            Console.WriteLine("\tStudents in MEDS17: ");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "SUT23");
                            Console.WriteLine("\tStudents in SUT23: ");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"\tStudent ID: {s.StudentId}");
                                Console.WriteLine($"\tFirst Name: {s.Fname}");
                                Console.WriteLine($"\tLast Name: {s.Lname}");
                                Console.WriteLine(new string('-', 30));
                            }
                        }

                        break;

                    case "4":
                        Console.WriteLine("\tExiting...");
                        return;

                    default:
                        Console.WriteLine("\tInvalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\tPress Enter to continue...");
                Console.ReadLine();

            }
        }

        public static void AddPersonel()
        {
            Console.Clear();
            using (DBSchoolDbContext context = new DBSchoolDbContext())
            {
                Console.WriteLine("\tTo add new Personnel, Please insert:");
                Console.WriteLine("\tFirst Name:");
                string FnamePersonel = Console.ReadLine();
                Console.WriteLine("\tLast Name:");
                string LnamePersonel = Console.ReadLine();
                Console.WriteLine("\tOccupation:");
                string OccupationPersonel = Console.ReadLine();
                Console.WriteLine("\tStart Date: ");
                DateOnly startdate = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("\tSalary: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                TblPersonal personnel = new TblPersonal()
                {
                    Fname = FnamePersonel,
                    Lname = LnamePersonel,
                    Occupation = OccupationPersonel,
                    StartWork = startdate,
                    Salary = salary

                };

                context.TblPersonals.Add(personnel);
                context.SaveChanges();
            }
        }
    }
}
