//Project: Course Enrollment App
//Author: Andrew Hewitson
//Date: Jan 22, 2019
//
using System;

namespace CourseEnrollmentApp2.Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}

