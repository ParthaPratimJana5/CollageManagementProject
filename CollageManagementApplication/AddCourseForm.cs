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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new CourseManagement());
            }
        }
    }
}
