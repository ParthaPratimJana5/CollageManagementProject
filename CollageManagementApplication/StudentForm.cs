using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudets();
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
        }

        public void LoadStudets()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllStudentInformation", conn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
                //dashboard.Loadfrom(new EditStudetForm());
            }
        }
    }
}
