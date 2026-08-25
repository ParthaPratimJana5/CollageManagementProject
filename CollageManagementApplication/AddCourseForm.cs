using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


          
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            Stuff Staff = new Stuff();
            txtAddCourseId.Text =  Staff.GetMaxCourseID();

           DataTable st = Staff.GetDepartmemt();
            cmbDepartment.DataSource = st;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.SelectedIndex = -1;

            DataTable dt = Staff.GetCourse();
            cmbAddSubjectCourse.DataSource = dt;
            cmbAddSubjectCourse.DisplayMember = "CourseName";
            cmbAddSubjectCourse.ValueMember = "CourseId";
            cmbAddSubjectCourse.SelectedIndex = -1;

            DataTable dtStaff = Staff.GetStaff();
            cmbAddSubjectStaff.DataSource = dtStaff;
            cmbAddSubjectStaff.DisplayMember = "StaffName";
            cmbAddSubjectStaff.ValueMember = "StaffId";
            cmbAddSubjectStaff.SelectedIndex = -1;
        }

        public string AddCourses()
        {
            Stuff staff = new Stuff();
            staff.CourseName = txtCourseName.Text;
            staff.CourseDuration = txtCourseDuration.Text;
            String a= staff.AddCourse(cmbDepartment.SelectedValue.ToString());
            return a;
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            if (AddCourses() != null)
            {
                MessageBox.Show("Course added Successfully");
            }
            else
            {
                MessageBox.Show("Course Add Failed");
            }
            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "Select Department";
            txtCourseName.Text = "";
            txtCourseDuration.Text = "";

        }


        public void AddSubject()
        {
            Subject subject = new Subject();
            subject.SubjectName = txtSubjectName.Text;
            subject.CourseId= cmbAddSubjectCourse.SelectedValue.ToString();
            subject.SubjectStaffID = cmbAddSubjectStaff.SelectedValue.ToString();
            string message = subject.AddSubject();
            MessageBox.Show(message);
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject();

            txtSubjectName.Text = "";
            cmbAddSubjectCourse.SelectedIndex = -1;
            cmbAddSubjectStaff.SelectedIndex = -1;
            cmbAddSubjectCourse.Text = "Select Course";
            cmbAddSubjectStaff.Text = "Select Stuff to Be Assigned";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new CourseManagement());
            }
        }
    }
}
