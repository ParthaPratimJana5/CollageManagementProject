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
    public partial class MainDashboard : Form
    {

        public MainDashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }


        public void Loadfrom(Form form)
        {
            pnlMainpanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlMainpanel.Controls.Add(form);
            pnlMainpanel.Tag = form;

            form.Show();
        }


        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // Sidebar এর সব button এ automatic hover event add হবে
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.MouseEnter += Button_MouseEnter;
                    ctrl.MouseLeave += Button_MouseLeave;
                }
            }

            // Default Dashboard Load
            //Loadfrom(new Dashboard());
        }


        // =========================
        // Common Hover Events
        // =========================

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Hover Color
            btn.BackColor = Color.FromArgb(141, 151, 171);
            btn.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Default Sidebar Color
            btn.BackColor = Color.FromArgb(141, 151, 171);
            btn.ForeColor = Color.White;
        }


        // =========================
        // Buttons Click Events
        // =========================

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Loadfrom(new Dashboard());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Loadfrom(new StudentForm());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Loadfrom(new CourseManagement());
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            Loadfrom(new Faculty());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Loadfrom(new AttendanceManagement());
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            Loadfrom(new FeeManagement());
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            Loadfrom(new Dashboard());
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Loadfrom(new ResultManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnrollment_Click_1(object sender, EventArgs e)
        {

            Loadfrom(new EnrollForm());
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}