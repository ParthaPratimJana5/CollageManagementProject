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
    public partial class AttendanceManagement : Form
    {
        public AttendanceManagement()
        {
            InitializeComponent();
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void AttendanceManagement_Load(object sender, EventArgs e)
        {
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");

            LoadCourse();
            
        }

        //private void GetPopulate()
        //{
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    SqlConnection sqlConnection = null;
        //    try
        //    {
        //        sqlConnection = new SqlConnection(cs);
        //        SqlDataAdapter da = new SqlDataAdapter("spGetStudent", sqlConnection);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        DataTable dt = new DataTable();
              
        //        da.Fill(dt);             
        //        dgvAttandance.DataSource = dt;

        //        if (!dgvAttandance.Columns.Contains("Present"))
        //        {
        //            DataGridViewCheckBoxColumn chk =
        //                new DataGridViewCheckBoxColumn();

        //            chk.Name = "Present";
        //            chk.HeaderText = "Present";

        //            dgvAttandance.Columns.Add(chk);
        //        }

        //        if (!dgvAttandance.Columns.Contains("Absent"))
        //        {
        //            DataGridViewCheckBoxColumn chk =
        //                new DataGridViewCheckBoxColumn();

        //            chk.Name = "Absent";
        //            chk.HeaderText = "Absent";

        //            dgvAttandance.Columns.Add(chk);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        if (sqlConnection != null)
        //        {
        //            sqlConnection.Close();
        //        }

        //    }
        //}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadCourse()
        {
            Student student = new Student();
            DataTable dtCourse= student.GetCourse();
            cmbAttendanceCourse.DataSource = dtCourse;
            cmbAttendanceCourse.DisplayMember = "CourseName";
            cmbAttendanceCourse.ValueMember = "CourseId";
            cmbAttendanceCourse.SelectedIndex = -1;
            
            LoadBatch();

        }

        public void LoadBatch()
        {
            Student student= new Student();
            DataTable dt= student.GetBatch();
            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "AdmissionYear";
            cmbBatch.SelectedIndex = 0;
        }
        private void cmbAttendanceCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAttendanceCourse.SelectedIndex == -1 || cmbAttendanceCourse.SelectedValue == null)
                return;
            LoadSubject();

        }

        public void LoadSubject()
        {
            Student student = new Student();
            

            student.CourseId = cmbAttendanceCourse.SelectedValue.ToString();
            DataTable dt = student.GetSubectsbyCourseId();
            cmbAttendanceSubject.DataSource = dt;
            cmbAttendanceSubject.DisplayMember = "SubjectName";
            cmbAttendanceSubject.ValueMember = "SubjectId";
            cmbAttendanceSubject.SelectedIndex = -1;
        }

        private void cmbAttendanceSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAttendance.Rows.Clear();
            if (cmbAttendanceSubject.SelectedIndex==-1 || cmbAttendanceSubject.SelectedValue == null )
                return;
            Student student= new Student();
            DataTable dt= student.LoadStudents( cmbAttendanceCourse.SelectedValue.ToString(), cmbBatch.Text.ToString());
            dgvAttendance.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvAttendance.Rows.Add(
                    row["StudentId"],
                    row["StudentName"],
                    false
                );
            }
        }

        public void MarkAttandance()
        {
            string message;
            int AlreadyExist=0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.IsNewRow)
                    continue;

                Student student = new Student();
                student.AttandanceStudentID = row.Cells["colStudentID"].Value.ToString();
                student.AttandanceSubjectID = cmbAttendanceSubject.SelectedValue.ToString();
                student.AttandanceDate = dtpAttandanceDate.Value.Date;
                student.Present = Convert.ToBoolean(row.Cells["colPresent"].Value);

                message=student.AddAttendance();
                if (message== "Attendance already marked for this student, subject, and date.")
                {
                    AlreadyExist++;
                    break;
                }
            }

            if ( AlreadyExist == 0 )
            {
                MessageBox.Show("Attendance successfully added.");
            }
            else
            {
                MessageBox.Show("Attendance already marked ");
            }

        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            MarkAttandance();
        }

        private void btnAddanother_Click(object sender, EventArgs e)
        {
            cmbAttendanceCourse.SelectedIndex = -1;

            cmbAttendanceSubject.DataSource = null;

            

            dgvAttendance.Rows.Clear();

            dtpAttandanceDate.Value = DateTime.Today;

            cmbAttendanceCourse.Focus();
        }
    }
}
