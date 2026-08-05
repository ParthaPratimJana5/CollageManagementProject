using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CollageManagementApplication
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
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

        private void EditStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public void DataEntry()
        {
            Student student = new Student();
            string Genderid = student.GetGenderID(comboBoxGender.Text);

            student.CareOf = txtGuardianName.Text;
            student.Village = txtAddress.Text;
            student.Post = txtPostOffice.Text;
            student.Pin = txtPinCode.Text;
            student.Aadhaar = txtAadhaar.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            student.GurdianPhone = txtGuardianPhone.Text;
            student.GurdianEmail = txtGuardianEmail.Text.ToLower();
            string AddressID = student.UpdateAddress().ToString();

            if (txtUrl.Text != "")
            {
                student.Photobyte = File.ReadAllBytes(txtUrl.Text);
                string photoID = student.UpdatePhoto().ToString();
            }

            student.StudentName = txtFullNme.Text;
            student.DateOfBirth = dtpDateOfBirth.Value;
            student.Email = txtEmailAddress.Text.ToLower();
            student.Phone = txtPhoneNumber.Text;
            student.SGenderID = Genderid;


            student.UpdateStudent();
            if (chkUpdateAcadamyicInfo.Checked) 
            { 
            student.EnrollmentStudentID = student.StudentID;
            student.CourseName = cmbCourse.Text;
            student.GetCourseIdByName();
            student.EnrollmentID = txtStudentId.Text;
            student.DateOfAdmition = dtpAdmission.Value;
            student.UpdateEnrollment();
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
                        pictureBox.Image = Image.FromFile(picture);
                    }

                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataEntry();

            //Redirect to Parent Form
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new StudentForm());
            }



        }

        public void LoadFormData()
        {
            Student student = new Student();
            student.StudentID = cmbSearchName.Text.Split(' ')[0].ToString();
            txtStudentId.Text = student.StudentID.ToString();
            student.GetFullStudentInfo();
            txtFullNme.Text = student.StudentName;
            comboBoxGender.Text = student.GenderName;
            //ComboBoxDesignation.Text = stuff.StDesignationName;
            txtPhoneNumber.Text = student.Phone;
            txtEmailAddress.Text = student.Email;
            //comboBoxDepartment.Text = stuff.StDepartmentName;
            dtpDateOfBirth.Value = student.DateOfBirth;
            cmbBloodgroup.Text = student.BloodGroup;
            //txtSalary.Text = stuff.Salary;
            txtAadhaar.Text = student.Aadhaar;
            txtGuardianName.Text = student.CareOf;
            txtPostOffice.Text = student.Post;
            txtPinCode.Text = student.Pin;
            txtAddress.Text = student.Village;
            txtGuardianPhone.Text = student.GurdianPhone;
            txtGuardianEmail.Text = student.GurdianEmail;
            cmbCourse.Text=student.CourseName;
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(student.Photobyte))
                {
                    pictureBox.Image = Image.FromStream(memoryStream);
                }
            }
            catch
            {
                pictureBox.Image = null;

            }
            finally
            {

            }
            

        }
        public void Search()
        {
            Student student = new Student();
            List<string> li = student.SearchStudentBesicInfo(txtSearchBox.Text);
            cmbSearchName.Items.Clear();
            if (li != null)
            {
                cmbSearchName.Items.Clear();


                foreach (string Name in li)
                {
                    cmbSearchName.Items.Add(Name);
                }
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }
    }
}
