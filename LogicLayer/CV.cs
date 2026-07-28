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
    public class CV : CommonFilds
    {
       
        public byte[] CVbyte { get; set; }
        public string CVID { get; set; }

        public string InsertCV()
        {


            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertCV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CV", Photobyte);

                conn.Open();
                CVID = Convert.ToString(cmd.ExecuteScalar());

                return CVID;

            }
            catch (Exception ex)
            {
                return CVID;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        public int UpdateCV()
        {


            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateCV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CVId", CVID);
                cmd.Parameters.AddWithValue("@CV", Photobyte);

                conn.Open();
                CVID = Convert.ToString(cmd.ExecuteScalar());

                return 1;

            }
            catch (Exception ex)
            {
                return 0;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}
