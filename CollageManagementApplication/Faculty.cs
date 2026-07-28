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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        
        public void ShowStaffs ()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllStaffInformation", conn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                dgvFaculty.DataSource = source;
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

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {

            //Redirect to From
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new AddFaculty());
            }
        }

        private void btnEditFacuty_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = (MainDashboard)this.ParentForm;

            if (dashboard != null)
            {
                dashboard.Loadfrom(new EditFaculty());
            }
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            ShowStaffs();
        }




        //private void Test()
        //{
        //    Student st = new Student();
        //    st.StudentName = txtFullNme.Text;
        //    int RowsEffected=st.InsertStudentDetails();
        //    if()
        //    {
        //    }
        //}
    }
}
