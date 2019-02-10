//Project: Course Enrollment App
//Author: Andrew Hewitson
//Date: Jan 22, 2019
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrollmentApp2.UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        }

        public static void Run() { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnrollmentForm());
        }
    }
}
