using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Stuff: Designation
    {

        public string TotalStaff {  get; set; }
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public string StuffEmail { get; set; }
        public string DateOfJoinning { get; set; }
        public string

        public void InsertStuff()
        {

        }

       public void GetTotalFaculty()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spTotalStaff", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

               TotalStaff = Convert.ToString(cmd.ExecuteScalar());

               
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public void GetNextStuffID()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spGetMaxStaffId", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                int Id = Convert.ToInt32(cmd.ExecuteScalar());
                Id++;
                StaffID = Id.ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }


    }
}
