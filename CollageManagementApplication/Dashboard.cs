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
            // TODO: This line of code loads data into the 'dbCollageManagementSyatemDataSet.tblCourse' table. You can move, or remove it, as needed.
            this.tblCourseTableAdapter.Fill(this.dbCollageManagementSyatemDataSet.tblCourse);
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
            //GetTotalStudent();
            //GetTotalFaculty();
            //GetTotalCourse(); 
            LoadData();
            dtpEndDate.Hide();
            dtpStartDate.Hide();
            cmbCourse.Hide();
            lblFrom.Hide();
            lblTo.Hide();









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

            DataTable dt= course.GetCourse();
            
            cmbCourse.DataSource = dt;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Text = "Select Course";


        }

        public class ComboItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            // This ensures the ComboBox shows the Text property
            public override string ToString()
            {
                return Text;
            }
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
           // LoadData();
            LoadReport();


        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse.Show();
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Text = "Select Course";
            if (cmbFilterType.Text=="Today" || cmbFilterType.Text == "This Month")
            {
                LoadReport();
                dtpEndDate.Hide();
                dtpStartDate.Hide();
                lblFrom.Hide();
                lblTo.Hide();
            }            
            else
            {
                dtpEndDate.Show();
                dtpStartDate.Show();
                lblFrom.Show(); lblTo.Show();
            }
            

        }

        private void LoadReport()
        {
            Attandance attandance = new Attandance();
            if (cmbCourse.SelectedIndex == -1)
                dgvAttendanceReport.DataSource = attandance.GetAttendanceReport(cmbFilterType.Text.ToLower(), dtpStartDate.Value, dtpEndDate.Value, null);

            else
                dgvAttendanceReport.DataSource = attandance.GetAttendanceReport(cmbFilterType.Text, dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt16(cmbCourse.SelectedValue));

        }
    }
}
