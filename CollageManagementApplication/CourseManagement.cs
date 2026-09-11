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
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent();
        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {
            LoadCourse(null);
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
        }

        private void LoadCourse(string DATA)
        {
            Course course = new Course();
            DataTable dt= course.GetCourseInfoBySearch(DATA);
            dgvCourse.DataSource = dt;

        }

        

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AddCourseForm ());
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new EditCourseForm());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCourse(txtSearch.Text);
        }
    }
}
