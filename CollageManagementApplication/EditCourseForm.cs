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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new CourseManagement());
            }
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            Course course = new Course();
            DataTable Ct =  course.GetCourse(null);

            cmbCourse.DataSource = Ct;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Text = "Select Course to Edit";

            DataTable Cos = course.GetCourse(null);
            cmbCourseOfSubject.DataSource = Cos;
            cmbCourseOfSubject.DisplayMember = "CourseName";
            cmbCourseOfSubject.ValueMember = "CourseId";
            cmbCourseOfSubject.SelectedIndex = -1;
            cmbCourseOfSubject.Text = "Select Course to Edit";

            Subject subject = new Subject();
            DataTable sub = subject.GetSubject(null);
            cmbSubject.DataSource = sub;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
            cmbSubject.SelectedIndex = -1;
            cmbSubject.Text = "Select Subject to Edit";

            Stuff Staff = new Stuff();
            DataTable dtStaff = Staff.GetStaff();
            cmbStaff.DataSource = dtStaff;
            cmbStaff.DisplayMember = "StaffName";
            cmbStaff.ValueMember = "StaffId";
            cmbStaff.SelectedIndex = -1;
            cmbStaff.Text = "Select Stuff to Be Assigned";

            DataTable dep = Staff.GetDepartmemt();
            cmbDepartment.DataSource = dep;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "Select Department";


            DataTable depE = Staff.GetDepartmemt();
            cmbDepartmentEdit.DataSource = depE;
            cmbDepartmentEdit.DisplayMember = "DepartmentName";
            cmbDepartmentEdit.ValueMember = "DepartmentId";
            cmbDepartmentEdit.SelectedIndex = -1;
            cmbDepartmentEdit.Text = "Select Department";


        }

        private void ClearData()
        {
            LoadData();
            txtCourseDuration.Clear();
            txtCourseName.Clear();
            txtDepartment.Clear();
            txtEditCourseId.Clear();
            txtSubjectId.Clear();
            txtsubjectName.Clear();
            
        }
        

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        { 
                                                                                                                                                          {
            if (cmbSubject.SelectedIndex == -1 || cmbSubject.SelectedValue == null)
            {  return; }
                
            else
            { 
            Subject subject = new Subject();
            DataTable sub = subject.GetSubject(cmbSubject.SelectedValue.ToString());

                if (sub.Rows.Count > 0)
                {
                    DataRow row = sub.Rows[0];
                    txtSubjectId.Text = row["SubjectId"].ToString();
                    txtsubjectName.Text = row["SubjectName"].ToString();
                    cmbCourseOfSubject.SelectedValue = row["CourseId"].ToString();
                    cmbStaff.SelectedValue = row["StaffId"].ToString();
                }

            }


        }
    }

        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {


            DialogResult confirm = MessageBox.Show
                (
                    "Are you sure you want to save changes?",
                     "Confirm Save",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                );

            if (confirm == DialogResult.Yes)
            {
                Department dal = new Department();


                if (cmbDepartmentEdit.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Department First.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string deptName = txtDepartment.Text;
                if (string.IsNullOrEmpty(deptName))
                {
                    MessageBox.Show("Please enter a department name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = dal.EditDepartment(cmbDepartmentEdit.SelectedValue.ToString(), deptName);

                if (result == "1")
                    MessageBox.Show("Department updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result == "0")
                    MessageBox.Show("No department found with the given Course.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("An error occurred while updating department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearData();
            }
            else
            {
                return;
            }

            

                
            }

        private void cmbDepartmentEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartmentEdit.SelectedIndex == -1 || cmbDepartmentEdit.SelectedValue == null)
            {
                txtDepartment.Clear();
                return;
            }
            else
            {
                txtDepartment.Text= cmbDepartmentEdit.Text;
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex == -1 || cmbCourse.SelectedValue == null)
            { return; }

            else
            {
                Subject subject = new Subject();
                DataTable sub = subject.GetCourse(cmbCourse.SelectedValue.ToString());

                if (sub.Rows.Count > 0)
                {
                    DataRow row = sub.Rows[0];
                    txtEditCourseId.Text = row["CourseId"].ToString();
                    txtCourseName.Text = row["CourseName"].ToString();
                    txtCourseDuration.Text = row["Duration"].ToString();
                    
                    //cmbStaff.SelectedValue = row["StaffId"].ToString();
                }

            }
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show
                (
                    "Are you sure you want to save changes?",
                     "Confirm Save",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                );

            if (confirm == DialogResult.Yes)
            {
                Course course = new Course();
                course.CourseId = cmbCourse.SelectedValue.ToString();
                string departmentId = cmbDepartment.SelectedValue.ToString();

                course.CourseName = txtCourseName.Text;
                course.CourseDuration = txtCourseDuration.Text.Trim();

                string result = course.EditCourse(departmentId);

                if (result == "1")
                    MessageBox.Show("Course updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result == "0")
                    MessageBox.Show("No course found with the given Course.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("An error occurred while updating course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }
            else
            {
                return;
            }
            
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show
                (
                    "Are you sure you want to save changes?",
                     "Confirm Save",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                // Get values directly from controls

                Subject subject = new Subject();
                int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
                string subjectName = txtsubjectName.Text;
                int courseId = Convert.ToInt32(cmbCourseOfSubject.SelectedValue);
                int staffId = Convert.ToInt32(cmbStaff.SelectedValue);

                // Call method
                string result = subject.EditSubject(subjectId, subjectName, courseId, staffId);

                // Show feedback
                if (result == "1")
                    MessageBox.Show("Subject updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result == "0")
                    MessageBox.Show("No subject found with the given ID.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("An error occurred while updating subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearData();
            }
                else
                {
                return;
                }



            
        }

    }
}
    
