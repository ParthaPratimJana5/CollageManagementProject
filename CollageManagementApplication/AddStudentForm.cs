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
using System.IO;
using LogicLayer;

namespace CollageManagementApplication
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            // InsertStudentDetails();
            // InsertImageintoStudentTable(txtUrl.Text);
            //MessageBox.Show("Are you sure close this from??");
            //this.Close();
            DataEntry();

            //Redirect to Parent Form
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new StudentForm());
            }


            
        }

        //InsertStudentDetails
        private void InsertStudentDetails()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spInsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentName", txtFullNme.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Text);
                cmd.Parameters.AddWithValue("@Gender", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", cmbBloodgroup.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Aadhaar", txtAadhaar.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@AccountNo", txtAccount.Text);
                cmd.Parameters.AddWithValue("@Ifsc", txtIFSCCode.Text);
                cmd.Parameters.AddWithValue("@PinCode", txtPinCode.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Student Information Saved Successfully!");
                }
                else
                {
                    MessageBox.Show("Save Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            LoadData();


        }
        public void LoadData()
        {
            Student student = new Student();
            student.GetGennder();
           
            if (student.GenderList != null)
            {
                
                foreach (string Name in student.GenderList)
                {
                    comboBoxGender.Items.Add(Name);
                }
            }

            student.GetStudentID();
            txtStudentId.Text = student.StudentID;

            student.GetCourse();

            if (student.CourseList != null)
            {

                foreach (string Namee in student.CourseList)
                {
                    combCourse.Items.Add(Namee);
                }
            }

            student.GetBloodGroup();
            if (student.BloodGroups != null)
            {

                foreach (string Namee in student.BloodGroups)
                {
                    cmbBloodgroup.Items.Add(Namee);
                }
            }


        }
       

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                {
                    openFileDialog.Filter = "Image Files|`*.jpg;*.jpeg;*.png;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string picture = openFileDialog.FileName;
                        txtUrl.Text = picture;
                        pictureBoxAddStudent.Image = Image.FromFile(picture);
                    }

                }

            }
        }

        //private void Test()
        //{
        //    Student st = new Student();
        //    st.StudentName = txtFullNme.Text;
        //    int RowsEffected=st.InsertStudentDetails();
        //    if()
        //    {
        //    }
        //}
        private int InsertImageintoStudentTable(string Path)
        {
            int Roweffected = 0;
            byte[] bytes = File.ReadAllBytes(Path);
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUploadStudentPhoto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Photo", bytes);

                conn.Open();
                Roweffected = Convert.ToInt32(cmd.ExecuteNonQuery());
                return Roweffected;
            }
            catch (Exception ex)
            {
                return Roweffected;
               
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

       
        public void DataEntry()
        {
            Student student = new Student();
            string Genderid= student.GetGenderID(comboBoxGender.Text);

            student.CareOf = txtGuardianName.Text;
            student.Village = txtAddress.Text;
            student.Post=txtPostOffice.Text;
            student.Pin = txtPinCode.Text;
            student.Aadhaar=txtAadhaar.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            student.GurdianPhone=txtGuardianPhone.Text;
            student.GurdianEmail=txtGuardianEmail.Text.ToLower();
            string AddressID= student.SetAddress();

            student.Photobyte= File.ReadAllBytes(txtUrl.Text);
           string photoID= student.InsertPhoto();


            student.StudentName = txtFullNme.Text;
            student.DateOfBirth = dtpDateOfBirth.Value;
            student.Email=txtEmailAddress.Text.ToLower();
            student.Phone = txtPhoneNumber.Text;
            student.SphotoID = photoID;
            student.SGenderID = Genderid;
            student.SAddressID = AddressID;
            

            student.SetStudent();

            student.DateOfAdmition= dtpAdmission.Value;

            



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
