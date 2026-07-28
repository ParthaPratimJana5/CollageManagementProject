using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using LogicLayer;

namespace CollageManagementApplication
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
            //GetTotalStudent();
            //GetTotalFaculty();
            //GetTotalCourse(); 
            LoadData();
            






        }

        //Total Student

        private void LoadData()
        {
            Student student = new Student();
            student.GetTotalStudent();
            txtTotalStudent.Text= student.TotalStudents;

            Stuff stuff = new Stuff();
           stuff.GetTotalFaculty();
            txtTotalFaculty.Text=stuff.TotalStaff;

            Course course = new Course();
            course.GetTotalCourse();
            txtTotalCourse.Text = course.TotalCource;

        }
        
        

        //Total Faculty
        


        

        ////Get Notice
        //private void LoadNotice()
        //{
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //    using (SqlConnection con = new SqlConnection(cs))
        //    {
        //        SqlCommand cmd = new SqlCommand(
        //            "SELECT TOP 1 NoticeDescription FROM tblNotice ORDER BY NoticeID DESC",
        //            con);

        //        con.Open();

        //        object result = cmd.ExecuteScalar();

        //        if (result != null)
        //        {
        //            lblNotice.Text = result.ToString();
        //        }
        //    }
        //}




        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //AddStudentForm std = new AddStudentForm();
            //std.Show();

            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AddStudentForm());
            }

        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AttendanceManagement());
            }
        }

        private void txtTotalStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
