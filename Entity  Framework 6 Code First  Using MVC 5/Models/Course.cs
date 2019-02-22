using System.ComponentModel.DataAnnotations.Schema;

namespace COMP3618_Midterm.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}