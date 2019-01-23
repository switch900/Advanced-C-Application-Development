//Project: Course Enrollment App
//Author: Andrew Hewitson
//Date: Jan 22, 2019
//
using System;
using System.Windows.Forms;

namespace CourseEnrollmentApp2.UI
{
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseEnrollmentDB10DataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.courseEnrollmentDB10DataSet.Courses);
            // TODO: This line of code loads data into the 'courseEnrollmentDB10DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.courseEnrollmentDB10DataSet.Students);
            // TODO: This line of code loads data into the 'courseEnrollmentDB10DataSet.Enrollments' table. You can move, or remove it, as needed.
            this.enrollmentsTableAdapter.Fill(this.courseEnrollmentDB10DataSet.Enrollments);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
