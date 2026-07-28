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
    public class HOD : CV
    {
        public string HODID {  get; set; }
        public string HStaffID { get; set; }
        public string HDepartmentId { get; set; }
        public void AssignHOD(int stuffID)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateHOD", connection);
                cmd.CommandType = CommandType.StoredProcedure;


              
                cmd.Parameters.AddWithValue("@DepartmentId", Convert.ToInt16(HDepartmentId));
                cmd.Parameters.AddWithValue("@StaffId", stuffID);



                connection.Open();
                HODID = Convert.ToString(cmd.ExecuteScalar());



            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
    
}
