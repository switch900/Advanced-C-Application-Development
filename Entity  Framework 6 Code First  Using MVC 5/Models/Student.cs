using System;

namespace COMP3618_Midterm.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Course CourseID { get; set; }
        public bool Active { get; set; }
        public int RewardPoints { get; set; }

        public bool RewardPointsActive()
        {
            if (Active)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}