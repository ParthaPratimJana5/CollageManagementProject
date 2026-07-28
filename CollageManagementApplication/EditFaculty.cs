using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class EditFaculty : Form
    {
        public EditFaculty()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditFaculty_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            Stuff stuff = new Stuff();

            //stuff.GetNextStuffID();
            //txtStuffID.Text = stuff.StaffID.ToString();

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
            int CheckPoint = UpdateStuff();
            if ( CheckPoint != 5|| CheckPoint==3)
            {
                MessageBox.Show("Updated Successful");
                //Return to Parent Form
                MainDashboard dashboard = (MainDashboard)this.ParentForm;

                if (dashboard != null)
                {
                    dashboard.Loadfrom(new Faculty());
                }
            }
            else 
            {
                MessageBox.Show("Update Not Successfull");
            }
        
        }

        public int UpdateStuff()
        {
            int CheckPoint=0;
            Stuff staff1 = new Stuff();
            staff1.StaffID = Convert.ToInt32(txtStuffID.Text);
            string GenderID = staff1.GetGenderID(comboBoxGender.Text);
            string DesignationId = staff1.GetDesignationID(ComboBoxDesignation.Text);
            string DepartmentId = staff1.GetDepartmemtID(comboBoxDepartment.Text);
            staff1.getStaffRelatedIds();
            staff1.CareOf = txtCareOf.Text;
            staff1.Village = txtAddress.Text;
            staff1.Post = txtPostOffice.Text;
            staff1.Pin = txtPinCode.Text;
            staff1.Aadhaar = txtAadhaar.Text;
            staff1.PhoneNumber = txtPhoneNumber.Text;

            CheckPoint += staff1.UpdateAddress();

            staff1.BankName = txtBankName.Text;
            staff1.BranchName = txtBranchName.Text;
            staff1.IFSC = txtIFSCCode.Text;
            staff1.AccountNumber = txtAddress.Text;
            CheckPoint += staff1.UpdateBank();

            if (txtUrlPhoto.Text!="")
            { 
            staff1.Photobyte = File.ReadAllBytes(txtUrlPhoto.Text);
            CheckPoint += staff1.UpdatePhoto();
            }
            if (txtUrlCv.Text != "")
            {
                staff1.CVbyte = File.ReadAllBytes(txtUrlCv.Text);
                CheckPoint += staff1.UpdateCV();
            }
            staff1.StaffName = txtName.Text;
            staff1.StuffEmail = txtStaffEmail.Text;
            staff1.DateOfJoinning = dtpDateOfJoinning.Value;
            staff1.Salary = txtSalary.Text;
            staff1.BloodGroup = comboBoxBloodGroup.Text;
            staff1.StDesignationID = DesignationId;
            staff1.StDepartmentID = DepartmentId;
            //staff1.StBankID = BankID;
            //staff1.StAddressId = AddressID;
            //staff1.StPhotoID = PhotoID;
            //staff1.StCvId =CVID;
            staff1.StGendrId = GenderID;

            CheckPoint += staff1.UpdateStaff();

            if (checkBoxHOD.Checked)
            {
                staff1.HDepartmentId = DepartmentId;
                staff1.AssignHOD(staff1.StaffID);
            }
            return CheckPoint;

        }

       

        

        public void LoadFormData()
        {
            Stuff stuff=new Stuff();
              stuff.StaffID = Convert.ToInt32(cmbSearchName.Text.Split(' ') [0]);
            txtStuffID.Text=stuff.StaffID.ToString();
            stuff.GetFullStaffInfo();
            txtName.Text = stuff.StaffName;
            comboBoxGender.Text = stuff.StGenderName;
            ComboBoxDesignation.Text = stuff.StDesignationName;
            txtPhoneNumber.Text= stuff.PhoneNumber;
            txtStaffEmail.Text = stuff.StuffEmail;
            comboBoxDepartment.Text = stuff.StDepartmentName;
            dtpDateOfJoinning.Value = stuff.DateOfJoinning;
            comboBoxBloodGroup.Text = stuff.BloodGroup;
            txtSalary.Text = stuff.Salary;
            txtAadhaar.Text = stuff.Aadhaar;
            txtBankName.Text = stuff.BankName;
            txtBranchName.Text = stuff.BranchName;
           txtConfirmAccount.Text= txtAccountNumber.Text = stuff.AccountNumber;
            txtIFSCCode.Text = stuff.IFSC;
            txtCareOf.Text = stuff.CareOf;
            txtPostOffice.Text = stuff.Post;
            txtPinCode.Text = stuff.Pin;
            txtAddress.Text = stuff.StAddress;
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(stuff.Photobyte))
                {
                    pictureBoxEditFaculty.Image = Image.FromStream(memoryStream);
                }
            }
            catch
            {
                pictureBoxEditFaculty.Image = null;

            }
            finally
            {

            }
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(stuff.CVbyte))
                {
                    pictureBoxCV.Image = Image.FromStream(memoryStream);
                }
            }
            catch { pictureBoxCV.Image= null; }

        }
        
        public void Search()
        {
            Stuff stuff = new Stuff();
            List<string> li = stuff.SearchStuff(txtSearchBox.Text);
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

        
        private void cmbSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormData();
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
                        pictureBoxEditFaculty.Image = Image.FromFile(picture);
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

        private void txtCareOf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
