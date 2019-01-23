//Project: Course Enrollment App
//Author: Andrew Hewitson
//Date: Jan 22, 2019
//
//Main Class.  Starts program.  Displays menu.  Basic CRUD functions.

using System;
using System.Linq;
using System.Threading;

namespace CourseEnrollmentApp2.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch
            {
                Console.WriteLine("\nPlease try again.\n");
                Run();
            }
        }

        //Main menu
        public static void Run()
        {
            Console.WriteLine("Please select a number");
            Console.WriteLine("----------------------");
            Console.WriteLine("1: Create New Student");
            Console.WriteLine("2: Return a Student");
            Console.WriteLine("3: Display Enrollment List");
            Console.WriteLine("4: Update Database");
            Console.WriteLine("5: Delete Student");
            Console.WriteLine("6: Exit");
            Console.Write(">");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            try
            {
                switch (userChoice)
                {

                    case 1: CreateNew(); break;
                    case 2: ReadEnrollment(); break;
                    case 3: DisplayGrid(); break;
                    case 4: UpdateDatabase(); break;
                    case 5: Delete(); break;
                    case 6: Environment.Exit(1); break;
                    default: Console.WriteLine("Please enter a number between 1 and 4"); break;
                }
                Console.WriteLine();
                Run();
            }
            catch
            {
                Console.WriteLine("\nPlease try again\n");
                Run();
            }
        }

        //Opens Window form to display enrollment list
        private static void DisplayGrid()
        {  
            UI.Program.Run();
            Environment.Exit(0);
            Run();         
          
        }

        //Adds new entry into database
        private static void CreateNew()
        {
            try
            {
                using (var context = new CourseEnrollmentAppContext())
                {
                    Console.Write("Enter Student Last Name:");
                    string newLastName = Console.ReadLine();
                    Console.Write("Enter Student First Name:");
                    string newFirstName = Console.ReadLine();
                    var student1 = new Student()
                    {
                        LastName = newLastName,
                        FirstMidName = newFirstName,
                        EnrollmentDate = DateTime.UtcNow
                    };

                    Console.Write("Enter Course Title:");
                    string newTitle = Console.ReadLine();
                    Console.Write("Enter Course Credits:");
                    int newCredits = Int32.Parse(Console.ReadLine());
                    var course1 = new Course()
                    {
                        Title = newTitle,
                        Credits = newCredits
                    };

                    Console.Write("Enter Grade:");
                    int newGrade = Int32.Parse(Console.ReadLine());
                    var enrollment1 = new Enrollment()
                    {
                        Course = course1,
                        Grade = newGrade,
                        Student = student1
                    };

                    context.Students.Add(student1);
                    context.Courses.Add(course1);
                    context.Enrollments.Add(enrollment1);
                    context.SaveChanges();
                    Console.WriteLine("\nA new student has been added to the database.");
                }
            }
            catch
            {
                Console.WriteLine("\nPlease try again\n");
                Run();
            }
        }

        //Takes input of student id number and returns last name of student
        private static void ReadEnrollment()
        {
            // NOT USED but kept for future knowledge
            //private static IList<Enrollment> ReadEnrollment()
            //{
            //IList<Enrollment> enrollmentList;
            //using (var context = new CourseEnrollmentAppContext())
            //{
            //    enrollmentList = context.Enrollments
            //           .Include(b => b.Student)
            //           .Include(b => b.Course)
            //           .ToList();
            //}
            //return enrollmentList;
            try
            {
                Console.Write("Enter Student Id Number to Return:");
                int id = Convert.ToInt32(Console.ReadLine());

                var query = new Student();

                using (var context = new CourseEnrollmentAppContext())
                {
                    query = context.Students
                                        .Where(s => s.StudentId == id)
                                        .FirstOrDefault<Student>();
                }
                Console.WriteLine("\nStudent number " + id + " last name is " + query.LastName);
            }

            catch
            {
                Console.WriteLine("\nPlease try again\n");
                Run();
            }
        }

        //takes input of student id number and allows user to change last name of student
        private static void UpdateDatabase()
        {
            try
            {
                Console.Write("Enter Student Id Number to Update:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter New Last Name: ");
                string newLastName = Console.ReadLine();

                using (var context = new CourseEnrollmentAppContext())
                {
                    var student1 = context.Students.Where(s => s.StudentId == id).First();
                    student1.LastName = newLastName;
                    context.SaveChanges();
                    Console.WriteLine("\nStudent number " + id + " has had their last name changed");
                }
            }
            catch
            {
                Console.WriteLine("\nPlease try again\n");
                Run();
            }
        }

        //takes entry of student id and deletes that students records from database
        private static void Delete()
        {
            try
            {
                Console.Write("Select Student number to delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                using (var context = new CourseEnrollmentAppContext())
                {
                    var student1 = context.Students.Where(s => s.StudentId == id).First();
                    var enrollment1 = context.Enrollments.Where(s => s.Student == student1).First();

                    context.Enrollments.Remove(enrollment1);
                    context.Students.Remove(student1);
                    context.SaveChanges();
                    Console.WriteLine("\nStudent number " + id + " has been deleted from the database.");
                }
            }
            catch
            {
                Console.WriteLine("\nInput does not match an existing student ID in database. Please try again\n");
                Run();
            }
        }
    }
}
