namespace COMP3618_Midterm.Migrations
{
    using COMP3618_Midterm.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<COMP3618_Midterm.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(COMP3618_Midterm.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName = "Carson",   LastName = "Alexander",
                   DOB = DateTime.Parse("2010-09-01"), Active = true,RewardPoints=50 },
                new Student { FirstName = "Meredith", LastName = "Alonso",
                   DOB = DateTime.Parse("2012-09-01") , Active = true,RewardPoints=50},
                new Student { FirstName = "Arturo",   LastName = "Anand",
                   DOB = DateTime.Parse("2013-09-01"), Active = true,RewardPoints=50 },
                new Student { FirstName = "Gytis",    LastName = "Barzdukas",
                    DOB = DateTime.Parse("2012-09-01"), Active = true,RewardPoints=50 },
                new Student { FirstName = "Yan",      LastName = "Li",
                    DOB = DateTime.Parse("2012-09-01"), Active = true,RewardPoints=50 },
                new Student { FirstName = "Peggy",    LastName = "Justice",
                    DOB = DateTime.Parse("2011-09-01"), Active = true,RewardPoints=50 },
                new Student { FirstName = "Laura",    LastName = "Norman",
                    DOB = DateTime.Parse("2013-09-01") , Active = true,RewardPoints=50},
                new Student { FirstName = "Nino",     LastName = "Olivetto",
                    DOB = DateTime.Parse("2005-08-11"), Active = true,RewardPoints=50 }
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {CourseID = 1050, CourseName = "Chemistry"},
                new Course {CourseID = 4022, CourseName = "Microeconomics"},
                new Course {CourseID = 4041, CourseName = "Macroeconomics"},
                new Course {CourseID = 1045, CourseName = "Calculus"},
                new Course {CourseID = 3141, CourseName = "Trigonometry"},
                new Course {CourseID = 2021, CourseName = "Composition"},
                new Course {CourseID = 2042, CourseName = "Literature"}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.CourseName, s));
            context.SaveChanges();

            var lecturers = new List<Lecturer>
            {
                new Lecturer {LecturerID = 1, LectureName = "Amir"},
               new Lecturer {LecturerID = 2, LectureName = "Amir"},
                new Lecturer {LecturerID = 3, LectureName = "Amir"},
               new Lecturer {LecturerID = 4, LectureName = "Amir"},
                new Lecturer {LecturerID = 5, LectureName = "Amir"},
               new Lecturer {LecturerID = 6, LectureName = "Amir"},
              new Lecturer {LecturerID = 7, LectureName = "Amir"},
            };
            lecturers.ForEach(s => context.Lecturers.AddOrUpdate(p => p.LectureName, s));
            context.SaveChanges();

            //var enrollments = new List<Enrollment>
            //{
            //    new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alexander").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Chemistry" ).CourseID,
            //        Grade = Grade.A
            //    },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alexander").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Microeconomics" ).CourseID,
            //        Grade = Grade.C
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alexander").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Macroeconomics" ).CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //         StudentID = students.Single(s => s.LastName == "Alonso").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Calculus" ).CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //         StudentID = students.Single(s => s.LastName == "Alonso").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Trigonometry" ).CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alonso").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Composition" ).CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Anand").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Chemistry" ).CourseID
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Anand").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Microeconomics").CourseID,
            //        Grade = Grade.B
            //     },
            //    new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Chemistry").CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Li").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Composition").CourseID,
            //        Grade = Grade.B
            //     },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Justice").ID,
            //        CourseID = courses.Single(c => c.CourseName == "Literature").CourseID,
            //        Grade = Grade.B
            //     }
            //};

            //foreach (Enrollment e in enrollments)
            //{
            //    var enrollmentInDataBase = context.Enrollments.Where(
            //        s =>
            //             s.Student.ID == e.StudentID &&
            //             s.Course.CourseID == e.CourseID).SingleOrDefault();
            //    if (enrollmentInDataBase == null)
            //    {
            //        context.Enrollments.Add(e);
            //    }
            //}
            //context.SaveChanges();
        }
    }
}
