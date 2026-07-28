using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CollageManagementApplication
{
    public partial class AttendanceManagement : Form
    {
        public AttendanceManagement()
        {
            InitializeComponent();
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void AttendanceManagement_Load(object sender, EventArgs e)
        {
            txtbDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy hh:mm tt");
            GetPopulate();
        }

        private void GetPopulate()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlDataAdapter da = new SqlDataAdapter("spGetStudent", sqlConnection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
              
                da.Fill(dt);             
                dgvAttandance.DataSource = dt;

                if (!dgvAttandance.Columns.Contains("Present"))
                {
                    DataGridViewCheckBoxColumn chk =
                        new DataGridViewCheckBoxColumn();

                    chk.Name = "Present";
                    chk.HeaderText = "Present";

                    dgvAttandance.Columns.Add(chk);
                }

                if (!dgvAttandance.Columns.Contains("Absent"))
                {
                    DataGridViewCheckBoxColumn chk =
                        new DataGridViewCheckBoxColumn();

                    chk.Name = "Absent";
                    chk.HeaderText = "Absent";

                    dgvAttandance.Columns.Add(chk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
