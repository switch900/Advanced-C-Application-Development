using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP3618_Midterm.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public String LectureName { get; set; }
        public Course CourseID { get; set; }
    }
}