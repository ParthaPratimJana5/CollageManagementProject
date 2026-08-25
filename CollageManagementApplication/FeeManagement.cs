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
    public partial class FeeManagement : Form
    {
        public FeeManagement()
        {
            InitializeComponent();
        }

        private void FeeManagement_Load(object sender, EventArgs e)
        {
            LoadData();
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

            DataTable dt4 = payment.getPaymentMode();
            cmbPaymentPurpose.DataSource = dt4;
            cmbPaymentPurpose.DisplayMember = "PayType";
            cmbPaymentPurpose.ValueMember = "PayTypeId";
            cmbPaymentPurpose.SelectedIndex = -1;
            dtpPayment.Value = DateTime.Today;


        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentName.SelectedIndex == -1 || cmbStudentName.SelectedIndex ==-1)
                return;
            SelectStudentOperation();
        }

        private void cmbCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourseFilter.SelectedIndex == -1 || cmbCourseFilter.SelectedValue == null  )
            {
                return;
            }
            else
            {

                Student student = new Student();

                student.CourseId = cmbCourseFilter.SelectedValue.ToString();
                dt = student.GetStudentBesicsAndByCourseId();
                cmbStudentName.DataSource = dt;
                cmbStudentName.DisplayMember = "StudentWithCareOf";
                cmbStudentName.ValueMember = "StudentId";


                cmbStudentName.SelectedIndex = -1;
            }
            
        }

        private void MakePaymentDone()
        {
            Payment payment = new Payment();
            payment.PaymntStudentId = Convert.ToInt32(cmbStudentName.SelectedValue);
            payment.PaymentPourposeId = Convert.ToInt32(cmbPaymentPurpose.SelectedValue);
            payment.PaymentTypeId = Convert.ToInt32(cmbPayMode.SelectedValue);
            payment.PaymentDiscription = txtPaymentDiscription.Text;
            payment.PaymentDate = dtpPayment.Value;

            int chk = payment.MakePayment();
            if (chk == 0)
            {
                MessageBox.Show("Payument Enty Failed");
            }
            else
            {
                MessageBox.Show("Payment Done");
            }
        }
        private void btnCollectPayment_Click(object sender, EventArgs e)
        {
            MakePaymentDone();

        }

        
    }
}
