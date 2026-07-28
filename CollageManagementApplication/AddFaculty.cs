using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CollageManagementApplication
{
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

       
        private void AddFaculty_Load(object sender, EventArgs e)
        {
           LoadData();
            
            // txtDateOfJoinnng.Text = DateTime.Now.ToString("dd-MMMM-yyyy");
        }



        public void LoadData()
        {
            Stuff stuff = new Stuff();

            stuff.GetNextStuffID();
            txtStuffID.Text = stuff.StaffID.ToString();

            stuff.GetGennder();
            if (stuff.GenderList != null)
            {

                foreach (string Name in stuff.GenderList)
                {
                     comboBoxGender.Items.Add(Name);
                }
            }

            stuff.GetDesignation();

            if (stuff.DesignationList != null)
            {

                foreach (string Name in stuff.DesignationList)
                {
                   ComboBoxDesignation.Items.Add(Name);
                }
            }

            stuff.GetDepartmemt();

            if (stuff.DepartmemtList != null)
            {

                foreach (string Name in stuff.DepartmemtList)
                {
                    comboBoxDepartment.Items.Add(Name);
                }
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            
            if (DataInsert() != null)
            {
                //Redirect to Parent Form
                MainDashboard dashboard = (MainDashboard)this.ParentForm;

                if (dashboard != null)
                {
                    dashboard.Loadfrom(new Faculty());
                }

            }
            else
            {
                MessageBox.Show("Unable to Insert");
            }
            
            
        }

        public string DataInsert()
        {

            Stuff stuff1 = new Stuff();
            string GenderID= stuff1.GetGenderID(comboBoxGender.Text);
            string DesignationId=stuff1.GetDesignationID(ComboBoxDesignation.Text);
            string DepartmentId=stuff1.GetDepartmemtID(comboBoxDepartment.Text);

            stuff1.CareOf=txtCareOf.Text;
            stuff1.Village = txtAddress.Text;
            stuff1.Post= txtPostOffice.Text;
            stuff1.Pin= txtPinCode.Text;
            stuff1.Aadhaar=txtAadhaar.Text;
            stuff1.PhoneNumber= txtPhoneNumber.Text;
            
           string AddressID= stuff1.SetAddress();

            stuff1.BankName= txtBankName.Text;
            stuff1.BranchName= txtBranchName.Text;
            stuff1.IFSC= txtIFSCCode.Text;
            stuff1.AccountNumber=txtAddress.Text;
            string BankID=stuff1.InsertBank();

            stuff1.Photobyte = File.ReadAllBytes(txtUrlPhoto.Text);
            string PhotoID=stuff1.InsertPhoto();

            stuff1.CVbyte = File.ReadAllBytes(txtUrlCv.Text);
            string CVID=stuff1.InsertCV();

            stuff1.StaffName = txtName.Text;
            stuff1.StuffEmail = txtStaffEmail.Text;
            stuff1.DateOfJoinning=dtpDateOfJoinning.Value;
            stuff1.Salary=txtSalary.Text;
            stuff1.BloodGroup=comboBoxBloodGroup.Text;
            stuff1.StDesignationID=DesignationId;
            stuff1.StDepartmentID=DepartmentId;
            stuff1.StBankID=BankID;
            stuff1.StAddressId=AddressID;
            stuff1.StPhotoID=PhotoID;
            stuff1.StCvId=CVID;
            stuff1.StGendrId = GenderID;

            int stufffId= stuff1.InsertStuff();

            if (checkBoxHOD.Checked)
            {
                stuff1.HDepartmentId=DepartmentId;
                stuff1.AssignHOD(stufffId);
            }
            return stufffId.ToString();

        }
        
        //private void GetFacultyDetails()
        //{
        //    AddFacultyClass addFaculty = new AddFacultyClass();

        //    addFaculty.Name = txtName.Text;



        //    int rowsAffected = addFaculty.InsertStudentDetails(addFaculty);

        //    if (rowsAffected > 0)
        //    {
        //        MessageBox.Show("Faculty details inserted successfully.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed to insert faculty details.");
        //    }
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

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
                        txtUrlPhoto.Text = picture;
                        pictureBoxAddFaculty .Image = Image.FromFile(picture);
                    }

                }

            }
        }

     

        private void btnBrowseCV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                {
                    openFileDialog.Filter = "Image Files|`*.jpg;*.jpeg;*.png;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string picture = openFileDialog.FileName;
                        txtUrlCv.Text = picture;
                        pictureBoxCV.Image = Image.FromFile(picture);
                    }

                }

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
