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
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

            if(Validation())
            { 
            DataEntry();

            //Redirect to Parent Form
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new StudentForm());
            }

            }

        }

        //InsertStudentDetails
        //private void InsertStudentDetails()
        //{
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    SqlConnection con = null;

        //    try
        //    {
        //        con = new SqlConnection(cs);

        //        SqlCommand cmd = new SqlCommand("spInsertStudent", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@StudentName", txtFullNme.Text);
        //        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Text);
        //        cmd.Parameters.AddWithValue("@Gender", txtPhoneNumber.Text);
        //        cmd.Parameters.AddWithValue("@BloodGroup", cmbBloodgroup.Text);
        //        cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
        //        cmd.Parameters.AddWithValue("@Aadhaar", txtAadhaar.Text);
        //        cmd.Parameters.AddWithValue("@Email", txtGuardianEmail.Text);
        //        //cmd.Parameters.AddWithValue("@AccountNo", txtAccount.Text);
        //        //cmd.Parameters.AddWithValue("@Ifsc", txtIFSCCode.Text);
        //        cmd.Parameters.AddWithValue("@PinCode", txtPinCode.Text);
        //        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

        //        con.Open();

        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows > 0)
        //        {
        //            MessageBox.Show("Student Information Saved Successfully!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Save Failed!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //}

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

            student.GetCourse(null);

            if (student.CourseList != null)
            {

                foreach (string Namee in student.CourseList)
                {
                    cmbCourse.Items.Add(Namee);
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
        //private int InsertImageintoStudentTable(string Path)
        //{
        //    int Roweffected = 0;
        //    byte[] bytes = File.ReadAllBytes(Path);
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    SqlConnection conn = null;

        //    try
        //    {
        //        conn = new SqlConnection(cs);
        //        SqlCommand cmd = new SqlCommand("spUploadStudentPhoto", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@Photo", bytes);

        //        conn.Open();
        //        Roweffected = Convert.ToInt32(cmd.ExecuteNonQuery());
        //        return Roweffected;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Roweffected;
               
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

       
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

            if (!string.IsNullOrWhiteSpace(txtUrl.Text) && File.Exists(txtUrl.Text))
            {
                student.Photobyte = File.ReadAllBytes(txtUrl.Text);
            }
            else
            {
                student.Photobyte = null; // safely set null if no file path
            }

            string photoID = student.InsertPhoto();



            student.StudentName = txtFullNme.Text;
            student.DateOfBirth = dtpDateOfBirth.Value;
            student.Email=txtEmailAddress.Text.ToLower();
            student.Phone = txtPhoneNumber.Text;
            student.SphotoID = photoID;
            student.SGenderID = Genderid;
            student.SAddressID = AddressID;
            student.BloodGroup = cmbBloodgroup.Text;
            

            student.SetStudent();
            student.EnrollmentStudentID =student.StudentID;
            student.CourseName= cmbCourse.Text;
            student.GetCourseIdByName();
            
            student.DateOfAdmition= dtpAdmission.Value;
            student.InsertEnrollment();

            

            



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAadhaar.Text = "";
            
            txtAddress.Text = "";
            txtEmailAddress.Text = "";
            txtFullNme.Text = "";
            txtGuardianEmail.Text = "";
            txtGuardianName.Text = "";
            txtGuardianPhone.Text = "";
            txtPhoneNumber.Text = "";
            txtPinCode.Text = "";
            txtPostOffice.Text = "";
            txtUrl.Text = "";
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private bool Validation()
        {
            // Clear any previous error messages
            errorProvider.Clear();

            bool isValid = true;
            Control firstInvalidControl = null;

            // Helper action to flag an error and record the first invalid control
            void SetValidationError(Control control, string message)
            {
                errorProvider.SetError(control, message);
                isValid = false;
                if (firstInvalidControl == null)
                {
                    firstInvalidControl = control;
                }
            }

            // --- Regular Expression Patterns ---
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^[0-9]{10}$";
            string pinPattern = @"^[0-9]{6}$";
            string aadhaarPattern = @"^[0-9]{12}$";

            // 1. Full Name
            if (string.IsNullOrWhiteSpace(txtFullNme.Text))
            {
                SetValidationError(txtFullNme, "Full Name is required.");
            }

            // 2. Date of Birth (Minimum age 14 years)
            if (dtpDateOfBirth.Value > DateTime.Today.AddYears(-14))
            {
                SetValidationError(dtpDateOfBirth, "Student must be at least 14 years old.");
            }

            // 3. Gender Dropdown
            if (comboBoxGender.SelectedIndex <= -1 || comboBoxGender.Text == "Select Gender")
            {
                SetValidationError(comboBoxGender, "Please select a valid gender.");
            }

            // 4. Blood Group Dropdown
            if (cmbBloodgroup.SelectedIndex <= -1 || cmbBloodgroup.Text == "Select Blood Group")
            {
                SetValidationError(cmbBloodgroup, "Please select a valid blood group.");
            }

            // 5. Phone Number (10 digits)
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                SetValidationError(txtPhoneNumber, "Phone Number is required.");
            }
            else if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), phonePattern))
            {
                SetValidationError(txtPhoneNumber, "Enter a Valid Phone Number.");
            }

            // 6. Aadhaar Number (12 digits)
            if (string.IsNullOrWhiteSpace(txtAadhaar.Text))
            {
                SetValidationError(txtAadhaar, "Aadhaar number is required.");
            }
            else if (!Regex.IsMatch(txtAadhaar.Text.Trim(), aadhaarPattern))
            {
                SetValidationError(txtAadhaar, "Enter a Valid Aadhaar number.");
            }

            // 7. Email Address
            if (string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                SetValidationError(txtEmailAddress, "Email address is required.");
            }
            else if (!Regex.IsMatch(txtEmailAddress.Text.Trim(), emailPattern))
            {
                SetValidationError(txtEmailAddress, "Invalid email address.");
            }

            // 8. Pin Code (6 digits)
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                SetValidationError(txtPinCode, "Pin Code is required.");
            }
            else if (!Regex.IsMatch(txtPinCode.Text.Trim(), pinPattern))
            {
                SetValidationError(txtPinCode, "Enter a Valid Pin Code");
            }

            //// 9. Post Office
            //if (string.IsNullOrWhiteSpace(txtPostOffice.Text))
            //{
            //    SetValidationError(txtPostOffice, "Post Office is required.");
            //}

            // 10. Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                SetValidationError(txtAddress, "Address is required.");
            }

            // 11. Guardian Name
            if (string.IsNullOrWhiteSpace(txtGuardianName.Text))
            {
                SetValidationError(txtGuardianName, "Guardian Name is required.");
            }

            //// 12. Guardian Phone (10 digits)
            //if (string.IsNullOrWhiteSpace(txtGuardianPhone.Text))
            //{
            //    SetValidationError(txtGuardianPhone, "Guardian Phone is required.");
            //}
            //else if (!Regex.IsMatch(txtGuardianPhone.Text.Trim(), phonePattern))
            //{
            //    SetValidationError(txtGuardianPhone, "Guardian Phone must be exactly 10 digits.");
            //}


            //// 14. Student Image
            //if (pictureBoxAddStudent.Image == null)
            //{
            //    // Focus the browse button instead if pictureBox cannot receive focus cleanly
            //    SetValidationError(pictureBoxAddStudent, "Please upload a student photo.");
            //}

            // 15. Course Dropdown
            if (cmbCourse.SelectedIndex <= 0 || cmbCourse.Text == "SelectCourse")
            {
                SetValidationError(cmbCourse, "Please select a course.");
            }

            // 16. Admission Date (Cannot be future, cannot be earlier than 2015)
            DateTime minAdmissionDate = new DateTime(2015, 1, 1);
            if (dtpAdmission.Value.Date > DateTime.Today)
            {
                SetValidationError(dtpAdmission, "Admission date cannot be in the future.");
            }
            else if (dtpAdmission.Value.Date < minAdmissionDate)
            {
                SetValidationError(dtpAdmission, "Admission date cannot be earlier than 2015.");
            }

            // Shift focus to the very first erroneous field
            if (firstInvalidControl != null)
            {
                firstInvalidControl.Focus();
            }

            return isValid;
        }
    }
}
