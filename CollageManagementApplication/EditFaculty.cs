using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            stuff.GetBloodGroup();
            if (stuff.BloodGroups != null)
            {

                foreach (string Namee in stuff.BloodGroups)
                {
                    comboBoxBloodGroup.Items.Add(Namee);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation()) 
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
            
        }



        public int UpdateStuff()
        {
            int CheckPoint=0;
            try
            {
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

                if (txtUrlPhoto.Text != "")
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
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                
            }

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




        private bool Validation()
        {
            // Clear existing error indications
            errorProvider.Clear();

            bool isValid = true;
            Control firstInvalidControl = null;

            // Helper method to flag errors and remember the first failing control
            void SetValidationError(Control control, string message)
            {
                errorProvider.SetError(control, message);
                isValid = false;
                if (firstInvalidControl == null)
                {
                    firstInvalidControl = control;
                }
            }

            // --- Regex Patterns ---
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^[0-9]{10}$";
            string pinPattern = @"^[0-9]{6}$";
            string aadhaarPattern = @"^[0-9]{12}$";
            string ifscPattern = @"^[A-Z]{4}0[A-Z0-9]{6}$";

            // 1. Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetValidationError(txtName, "Staff name is required.");
            }

            // 2. Care Of / Guardian
            if (string.IsNullOrWhiteSpace(txtCareOf.Text))
            {
                SetValidationError(txtCareOf, "Care Of field is required.");
            }

            // 3. Gender Dropdown
            if (comboBoxGender.SelectedIndex <= -1 || comboBoxGender.Text.ToLower().Contains("select"))
            {
                SetValidationError(comboBoxGender, "Please select a valid gender.");
            }

            //// 4. Blood Group Dropdown
            //if (comboBoxBloodGroup.SelectedIndex <= 0 || comboBoxBloodGroup.Text.ToLower().Contains("select"))
            //{
            //    SetValidationError(comboBoxBloodGroup, "Please select a valid blood group.");
            //}

            // 5. Designation Dropdown
            if (ComboBoxDesignation.SelectedIndex <= 0 || ComboBoxDesignation.Text.ToLower().Contains("select"))
            {
                SetValidationError(ComboBoxDesignation, "Please select a designation.");
            }

            // 6. Department Dropdown
            if (comboBoxDepartment.SelectedIndex <= 0 || comboBoxDepartment.Text.ToLower().Contains("select"))
            {
                SetValidationError(comboBoxDepartment, "Please select a department.");
            }

            // 7. Phone Number (10 digits)
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                SetValidationError(txtPhoneNumber, "Phone number is required.");
            }
            else if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), phonePattern))
            {
                SetValidationError(txtPhoneNumber, "Enter a Valid Phone number.");
            }

            // 8. Aadhaar Number (12 digits)
            if (string.IsNullOrWhiteSpace(txtAadhaar.Text))
            {
                SetValidationError(txtAadhaar, "Aadhaar number is required.");
            }
            else if (!Regex.IsMatch(txtAadhaar.Text.Trim(), aadhaarPattern))
            {
                SetValidationError(txtAadhaar, "Enter a Valid Aadhaar number.");
            }

            // 9. Staff Email
            if (string.IsNullOrWhiteSpace(txtStaffEmail.Text))
            {
                SetValidationError(txtStaffEmail, "Staff email is required.");
            }
            else if (!Regex.IsMatch(txtStaffEmail.Text.Trim(), emailPattern))
            {
                SetValidationError(txtStaffEmail, "Please enter a valid email address.");
            }

            // 10. Salary (Must be positive numeric / decimal value)
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                SetValidationError(txtSalary, "Salary amount is required.");
            }
            else if (!decimal.TryParse(txtSalary.Text.Trim(), out decimal salary) || salary <= 0)
            {
                SetValidationError(txtSalary, "Please enter a valid positive salary amount.");
            }

            // 11. Pin Code (6 digits)
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                SetValidationError(txtPinCode, "PIN code is required.");
            }
            else if (!Regex.IsMatch(txtPinCode.Text.Trim(), pinPattern))
            {
                SetValidationError(txtPinCode, "PIN code must be exactly 6 digits.");
            }

            //// 12. Post Office
            //if (string.IsNullOrWhiteSpace(txtPostOffice.Text))
            //{
            //    SetValidationError(txtPostOffice, "Post office is required.");
            //}

            //// 13. Address
            //if (string.IsNullOrWhiteSpace(txtAddress.Text))
            //{
            //    SetValidationError(txtAddress, "Address is required.");
            //}

            //// 14. Bank Name
            //if (string.IsNullOrWhiteSpace(txtBankName.Text))
            //{
            //    SetValidationError(txtBankName, "Bank name is required.");
            //}

            //// 15. Branch Name
            //if (string.IsNullOrWhiteSpace(txtBranchName.Text))
            //{
            //    SetValidationError(txtBranchName, "Branch name is required.");
            //}

            // 16. IFSC Code (4 alphabets + 0 + 6 alphanumeric characters)
            //if (string.IsNullOrWhiteSpace(txtIFSCCode.Text))
            //{
            //    SetValidationError(txtIFSCCode, "IFSC code is required.");
            //}
            //else if (!Regex.IsMatch(txtIFSCCode.Text.Trim().ToUpper(), ifscPattern))
            //{
            //    SetValidationError(txtIFSCCode, "Invalid IFSC code (Format: 4 letters, '0', then 6 numbers/letters).");
            //}

            // 17. Photo URL / Path
            //if (string.IsNullOrWhiteSpace(txtUrlPhoto.Text))
            //{
            //    SetValidationError(txtUrlPhoto, "Photo path or URL is required.");
            //}

            //// 18. CV URL / Path
            //if (string.IsNullOrWhiteSpace(txtUrlCv.Text))
            //{
            //    SetValidationError(txtUrlCv, "CV path or URL is required.");
            //}

            // 19. Date of Joining (Cannot be past 2015, cannot be far in future)
            DateTime minJoiningDate = new DateTime(2015, 1, 1);
            if (dtpDateOfJoinning.Value.Date < minJoiningDate)
            {
                SetValidationError(dtpDateOfJoinning, "Joining date cannot be earlier than 2015.");
            }
            else if (dtpDateOfJoinning.Value.Date > DateTime.Today.AddDays(30))
            {
                SetValidationError(dtpDateOfJoinning, "Joining date cannot be set more than 30 days in advance.");
            }

            string accNum = txtAccountNumber.Text.Trim();
            string confirmAccNum = txtConfirmAccount.Text.Trim();

            // 1. If both are empty, it's valid (optional field).
            // 2. If either one is filled, both must be filled, numeric, and identical.
            if (!string.IsNullOrEmpty(accNum) || !string.IsNullOrEmpty(confirmAccNum))
            {
                if (string.IsNullOrEmpty(accNum))
                {
                    SetValidationError(txtAccountNumber, "Account number is required if confirming.");
                }
                else if (!Regex.IsMatch(accNum, @"^[0-9]{9,18}$"))
                {
                    SetValidationError(txtAccountNumber, "Please enter a valid numeric account number (9–18 digits).");
                }

                if (string.IsNullOrEmpty(confirmAccNum))
                {
                    SetValidationError(txtConfirmAccount, "Please confirm the account number.");
                }
                else if (accNum != confirmAccNum)
                {
                    SetValidationError(txtConfirmAccount, "Account numbers do not match.");
                }
            }

            // Automatically focus the first invalid control
            if (firstInvalidControl != null)
            {
                firstInvalidControl.Focus();
            }

            return isValid;
        }
    }
}
