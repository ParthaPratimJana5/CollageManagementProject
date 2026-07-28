using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LogicLayer;

namespace CollageManagementApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainDashboard());
            Application.Run(new Login());
            //Application.Run(new Dashboard());
            //Application.Run(new StudentForm());
            //Application.Run(new CourseManagement());
            //Application.Run(new AttendanceManagement());
            //Application.Run(new ResultManagement());
            //Application.Run(new FeeManagement());
            //Application.Run(new Faculty());
            //Application.Run(new MarkAttendanceForm());
            //Application.Run(new EnrollForm());




        }
    }
}
