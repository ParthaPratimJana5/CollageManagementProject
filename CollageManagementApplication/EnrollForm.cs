using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class EnrollForm : Form
    {
        public EnrollForm()
        {
            InitializeComponent();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

         public void Search()
        {
            Student student = new Student();
            DataSet ds = new DataSet();
            student.StudentID = txtSearchById.Text;
            student.StudentName= txtSearchByName.Text;
            ds=student.SearchStudent();
            DataTable dataTable = ds.Tables[0];
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = dataTable;
        }
    }
}
