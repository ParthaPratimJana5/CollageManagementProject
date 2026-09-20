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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnAddPaymentPurpose_Click(object sender, EventArgs e)
        {
            //AddPaymentPurposeForm addPaymentPurposeForm = new AddPaymentPurposeForm();
            //addPaymentPurposeForm.Show();

            Loadfrom(new AddPaymentPurposeForm());
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new FeeManagement());
            }

            

        }

        private void btnAddPaymentMode_Click(object sender, EventArgs e)
        {
            Loadfrom(new AddPaymentModeForm());
        }

        public void Loadfrom(Form form)
        {
            pnlWorkingArea.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlWorkingArea.Controls.Add(form);
            pnlWorkingArea.Tag = form;

            form.Show();
        }

        private void btnAddDesignationForm_Click(object sender, EventArgs e)
        {
            Loadfrom(new AddDesignationForm());
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            //Redirect to From
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AddFaculty());
            }
        }

        private void btnEditFaculty_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new EditFaculty());
            }
        }

        private void EditStaffStatus_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new Faculty());
            }
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

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;
            if (dashboard != null)
            {
                dashboard.Loadfrom(new AttendanceManagement());
            }
        }
    }
}
