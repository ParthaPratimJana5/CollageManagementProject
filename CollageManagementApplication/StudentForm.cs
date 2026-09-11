using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudets(null);
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
        }

        public void LoadStudets(string Data)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection conn = null;

            try
            {
                //    conn = new SqlConnection(cs);
                //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllStudentInformation", conn);
                //    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                //    DataSet ds = new DataSet();
                //    sqlDataAdapter.Fill(ds);
                //    DataTable dt = ds.Tables[0];
                //    BindingSource source = new BindingSource();
                //    source.DataSource = dt;
                //    dataGridView1.DataSource = source;
                
                Student student = new Student();
                DataTable dt= student.GetStudentInfoBySearch(Data);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);



            }
            finally
            {
                
            }
        }

        //private void SearchStudents()
        //{
        //    Student student = new Student();
        //    student.StudentID=cmbSearch.ValueMember;
        //    //DataTable dt=student.GetFullStudentInfo();
        //   // dataGridView1.DataSource= dt;

        //}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentAddnew_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AddStudentForm());
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new EditStudent());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student= new Student();

            student.StudentID= dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            student.GetFullStudentInfo();
            lblName.Text = student.StudentName;
            lblCourse.Text = student.CourseName;
            lblDob.Text = student.DateOfBirth.Date.ToString();
            lblAddress.Text = student.Village + ", " + student.Post + ", " + student.Pin;
            lblEmail.Text = student.Email;
            lblPhone.Text = student.Phone;
            lblGuardian.Text = student.CareOf;
            // pictureBoxStudent.Image = Convert.ToByte(student.Photobyte);
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(student.Photobyte))
                {
                    pictureBoxStudent.Image = Image.FromStream(memoryStream);
                }
            }
            catch
            {
                pictureBoxStudent.Image = null;

            }

            var result = student.CalculateSemesterAndStatus(student.DateOfAdmition, Convert.ToInt16(student.CourseDuration));

            lblSem.Text = result.Semester.ToString();
            lblStatus.Text = result.Status;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        

        

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadStudets(txtSearchBox.Text);
        }
    }
}
