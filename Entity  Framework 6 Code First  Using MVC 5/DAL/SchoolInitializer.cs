using System;
using System.Collections.Generic;
using COMP3618_Midterm.Models;

namespace COMP3618_Midterm.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",DOB=DateTime.Parse("2005-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Meredith",LastName="Alonso",DOB=DateTime.Parse("2002-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Arturo",LastName="Anand",DOB=DateTime.Parse("2003-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Gytis",LastName="Barzdukas",DOB=DateTime.Parse("2002-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Yan",LastName="Li",DOB=DateTime.Parse("2002-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Peggy",LastName="Justice",DOB=DateTime.Parse("2001-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Laura",LastName="Norman",DOB=DateTime.Parse("2003-09-01"), Active = true,RewardPoints=50},
            new Student{FirstName="Nino",LastName="Olivetto",DOB=DateTime.Parse("2005-09-01"), Active = true,RewardPoints=50}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,CourseName="Chemistry",},
            new Course{CourseID=4022,CourseName="Microeconomics"},
            new Course{CourseID=4041,CourseName="Macroeconomics",},
            new Course{CourseID=1045,CourseName="Calculus"},
            new Course{CourseID=3141,CourseName="Trigonometry"},
            new Course{CourseID=2021,CourseName="Composition"},
            new Course{CourseID=2042,CourseName="Literature"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var lecturers = new List<Lecturer>
            {
                new Lecturer {LecturerID = 1, LectureName = "Amir", CourseID = new Course()},
               new Lecturer {LecturerID = 2, LectureName = "Amir",CourseID = new Course()},
                new Lecturer {LecturerID = 3, LectureName = "Amir", CourseID = new Course()},
               new Lecturer {LecturerID = 4, LectureName = "Amir",CourseID = new Course()},
                new Lecturer {LecturerID = 5, LectureName = "Amir",CourseID = new Course()},
               new Lecturer {LecturerID = 6, LectureName = "Amir", CourseID = new Course()},
              new Lecturer {LecturerID = 7, LectureName = "Amir",CourseID = new Course()},
            };
            lecturers.ForEach(s => context.Lecturers.Add(s));
            context.SaveChanges();
            //var enrollments = new List<Enrollment>
            //{
            //new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            //new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            //new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            //new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            //new Enrollment{StudentID=3,CourseID=1050},
            //new Enrollment{StudentID=4,CourseID=1050,},
            //new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            //new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            //new Enrollment{StudentID=6,CourseID=1045},
            //new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            //};
            //enrollments.ForEach(s => context.Enrollments.Add(s));
            //context.SaveChanges();
        }
    }
}