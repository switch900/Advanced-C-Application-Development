//Project: Course Enrollment App
//Author: Andrew Hewitson
//Date: Jan 22, 2019
//
namespace CourseEnrollmentApp2.Domain
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public decimal Grade { get; set; }
    }
}
