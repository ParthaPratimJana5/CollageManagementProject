using LogicLayer;
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
            //btnEditFacuty.Hide();

            Stuff stuff = new Stuff();
            stuff.GetTotalFaculty();
            txtTotalRecords.Text = stuff.TotalStaff;
        }

        private void btnRefreshFaculty_Click(object sender, EventArgs e)
        {
            ShowStaffs();
            Stuff stuff = new Stuff();
            stuff.GetTotalFaculty();
            txtTotalRecords.Text = stuff.TotalStaff;

        }

        private void dgvFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFaculty.CurrentRow.Cells["StaffId"].Value.ToString();
        }

        private void btnEditStatus_Click(object sender, EventArgs e)
        {
           
            if (dgvFaculty.CurrentRow != null && dgvFaculty.CurrentRow.Index >= 0)
            {
               string selectedStaffId =dgvFaculty.CurrentRow.Cells["StaffId"].Value.ToString();

                using (EditStaffStatusForm form = new EditStaffStatusForm())
                {
                    form.StaffID = selectedStaffId;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a faculty member first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }

        private void txtTotalRecords_TextChanged(object sender, EventArgs e)
        {

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
