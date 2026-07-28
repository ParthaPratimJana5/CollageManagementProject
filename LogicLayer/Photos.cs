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
    public class Photos : Bank

    {
        public byte[] Photobyte { get; set; }
        public string PhotoID { get; set; }

        public string InsertPhoto()
        {
            
            
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertPhoto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Photo", Photobyte);

                conn.Open();
                PhotoID= Convert.ToString(cmd.ExecuteScalar());

                return PhotoID;
                
            }
            catch (Exception ex)
            {

                return PhotoID;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int UpdatePhoto()
        {


            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdatePhoto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhotoId",PhotoID);
                cmd.Parameters.AddWithValue("@Photo", Photobyte);

                conn.Open();
                cmd.ExecuteScalar();

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
