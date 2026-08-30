using LogicLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class FeeManagement : Form
    {
        public FeeManagement()
        {
            InitializeComponent();
        }

        private void FeeManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadStudent(null);
            ClearForm();
            txtTotalPaid.Clear();
            //txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private DataTable dt;

        //public void SelectStudentOperation()
        //{
        //    Payment payment = new Payment();
        //    ComboBox tempcombo = new ComboBox();
        //    tempcombo.DataSource = dt;
        //    tempcombo.DisplayMember= "StudentWithCareOf";
        //    tempcombo.ValueMember= "CourseId";
        //    tempcombo.SelectedIndex = Convert.ToInt32( cmbStudentName.SelectedIndex);
        //    cmbCourse.SelectedValue = Convert.ToInt32( tempcombo.SelectedValue);
        //    tempcombo.Hide();

        //}

        private void SelectStudentOperation()
        {
            if (cmbStudentName.SelectedItem is DataRowView selectedRow)
            {
                // Extract CourseId and StudentId directly from the selected row
                int courseId = Convert.ToInt32(selectedRow["CourseId"]);
                int studentId = Convert.ToInt32(selectedRow["StudentId"]);

                // Set the selected course in your course ComboBox automatically
                cmbCourse.SelectedValue = courseId;
            }


        }


        public void LoadData()
        {
            Payment payment  = new Payment();

            dt= payment.GetSubectsbyCourseId();
            cmbStudentName.DisplayMember= "StudentWithCareOf";
            cmbStudentName.ValueMember = "StudentId";
            cmbStudentName.DataSource = dt;

            cmbStudentName.SelectedIndex = -1;
            cmbStudentName.Text = "Select Student";
            
            
            

            DataTable dt2 = payment.GetCourse();
            cmbCourse.DataSource= dt2;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";
            cmbCourse.SelectedIndex = -1;
            

            cmbCourseFilter.DataSource = dt2;
            cmbCourseFilter.DisplayMember = "CourseName";
            cmbCourseFilter.ValueMember = "CourseId";
            cmbCourseFilter.SelectedIndex = -1;
            cmbCourseFilter.Text = "Select Course";

            DataTable dt3 = payment.getPaymentPourpose();
            
            cmbPayMode.DataSource = dt3;
            cmbPayMode.DisplayMember = "PaymentPurpose";
            cmbPayMode.ValueMember = "PaymentPurposeId";
            cmbPayMode.SelectedIndex = -1;
            cmbPayMode.Text = "Select Mode Of Payment";

            DataTable dt4 = payment.getPaymentMode();
            cmbPaymentPurpose.DataSource = dt4;
            cmbPaymentPurpose.DisplayMember = "PayType";
            cmbPaymentPurpose.ValueMember = "PayTypeId";
            cmbPaymentPurpose.SelectedIndex = -1;
            dtpPayment.Value = DateTime.Today;


        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentName.SelectedIndex == -1 || cmbStudentName.SelectedValue == null)
                return;
            else
            { 
            SelectStudentOperation();
            GetStudentInfo();
                Calculate();
                
            }
            
        }

        private void cmbCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourseFilter.SelectedIndex == -1 || cmbCourseFilter.SelectedValue == null  )
            {
                return;
            }
            else
            {

                LoadStudent(cmbCourseFilter.SelectedValue.ToString());
                ClearForm();
                txtTotalPaid.Clear();
            }
            
        }

        private void LoadStudent( string StudentID)
        {
            Student student = new Student();

            student.CourseId = StudentID;
            dt = student.GetStudentBesicsAndByCourseId();
            cmbStudentName.DataSource = dt;
            cmbStudentName.DisplayMember = "StudentWithCareOf";
            cmbStudentName.ValueMember = "StudentId";


            cmbStudentName.SelectedIndex = -1;
            cmbStudentName.Text = "Select Student";
        }
        private void MakePaymentDone()
        {
            Payment payment = new Payment();
            payment.PaymntStudentId = Convert.ToInt32(cmbStudentName.SelectedValue);
            payment.PaymentPourposeId = Convert.ToInt32(cmbPaymentPurpose.SelectedValue);
            payment.PaymentTypeId = Convert.ToInt32(cmbPayMode.SelectedValue);
            payment.PaymentDiscription = txtPaymentDiscription.Text;
            payment.PaymentDate = dtpPayment.Value;
            payment.PaymentAmount = Convert.ToDouble( txtPayAmount.Text);



            int chk = payment.MakePayment();
            if (chk == 0)
            {
                MessageBox.Show("Payument Enty Failed");
            }
            else
            {
                MessageBox.Show("Payment Done");
                txtPayAmount.Text = "";
                txtPaymentDiscription.Text = "";
                cmbPayMode.SelectedIndex = -1;
                cmbPaymentPurpose.SelectedIndex = -1;
                cmbPayMode.Text = "Select Payment Modde";
                cmbPaymentPurpose.Text = "Select Payment Purpose";
                dtpPayment.Value=DateTime.Now;
            }
        }
        

        private void GetStudentInfo()
        {
            Payment payment= new Payment();
            DataTable dataTable = payment.GetStudentBesicPaymentInfo(Convert.ToInt32( cmbStudentName.SelectedValue));
            DataTable dt = payment.GetStudentPaymentHistory(Convert.ToInt32(cmbStudentName.SelectedValue));

            //if (dgvPaymentHistory.DataSource != null)
            //{
            //    dgvPaymentHistory.DataSource = null;

            //}

            dgvPaymentHistory.DataSource = dt;
            DataRowCollection dataRowCollection = dataTable.Rows;
            

            foreach (DataRow row in dataRowCollection)
            {

                txtStudentId.Text = row["StudentId"].ToString();                
                txtStudentName.Text= row["StudentName"].ToString();
                txtGuardianName.Text = row["GuardianName"].ToString();
                txtCourse.Text= row["CourseName"].ToString();
                txtDepartment.Text= row["DepartmentName"].ToString();
                txtTotalPaid.Text = row["TotalPaidAmount"].ToString();
                int year= Convert.ToInt16( row["AdmissionYear"]);
                
                
                
                 
                string Lastyear= (year + Convert.ToInt16(row["CourseDuration"])).ToString();
                txtYear.Text = Convert.ToString(year + " - " + Lastyear);

                
                try
                {
                    using (MemoryStream memoryStream = new MemoryStream(row["Photo"] as byte[]))
                    {
                        pictureBoxStudentInfo.Image = Image.FromStream(memoryStream);
                    }
                }
                catch
                {
                    pictureBoxStudentInfo.Image = null;

                }
                finally
                {

                }

            }
        }

        private void Calculate()
        {
            try
            {
                int Payed = 0;
                int TotalFees = 0;
                int ThisPayment = 0;

                // Total Fees
                if (int.TryParse(txtTotalFees.Text, out TotalFees))
                {
                    // Successfully converted
                    lblWarning.Hide();
                }
                else
                {
                    //MessageBox.Show("Please Enter Total Fees to calculate " + "or"+
                    //    " Please enter a valid Total Fees.");

                    lblWarning.Show();
                    txtThisPayment.Clear();
                    txtRemainingBalance.Clear();
                    txtAfterPayemntDue.Clear();
                    return;
                }

                // Total Paid - blank means 0
                if (!int.TryParse(txtTotalPaid.Text, out Payed))
                {
                    Payed = 0;
                }

                // Payable Amount - optional, blank means 0
                if (!int.TryParse(txtPayAmount.Text, out ThisPayment))
                {
                    ThisPayment = 0;
                }

                // Remaining Balance
                int RemainingBalance = TotalFees - Payed;

                txtRemainingBalance.Text = RemainingBalance.ToString();

                // This Payment
                txtThisPayment.Text = ThisPayment.ToString();

                // After Payment Due
                int AfterPaymentDue = RemainingBalance - ThisPayment;

                txtAfterPayemntDue.Text = AfterPaymentDue.ToString();
            
            }
            catch (Exception ex)
            { 
            }
            
        }


        private void ClearForm()
        {
            txtCourse.Clear();
            txtDepartment.Clear();
            txtGuardianName.Clear();
            txtPayAmount.Clear();
            txtPaymentDiscription.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtThisPayment.Clear();
            txtYear.Clear();
            txtRemainingBalance.Clear();
            txtAfterPayemntDue.Clear();
            dgvPaymentHistory.DataSource = null;
        }

        private void btnCollectPayment_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Student: " + txtStudentName.Text.ToString() +
    "\nPayment Amount: ₹" + txtPayAmount.Text.ToString() +
    "\n\nDo you want to continue with this payment?" + "\n !!Payment can't be modefied once confirmed!!", 
    
    

    "Confirm Payment ",

    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                MakePaymentDone();
                GetStudentInfo();
                Calculate();
            }
            else
            {
                return;
            }
            
        }

        private void txtTotalFees_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtPayAmount_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        
    }
}
