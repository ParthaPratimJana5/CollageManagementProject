using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Address : Gender
    {
        public string AddressID { get; set; }
        public string CareOf {  get; set; }
        public string Post {  get; set; }
        public string Pin { get; set; }
        public string Aadhaar { get; set; }
        public string PhoneNumber { get; set; }
        public string Village { get; set; }
        public string GurdianEmail { get; set; }
        public string GurdianPhone { get; set; }


        public String SetAddress()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertAddress", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@CareOf", CareOf);
                cmd.Parameters.AddWithValue("@Village", Village);
                cmd.Parameters.AddWithValue("@Post", Post);
                cmd.Parameters.AddWithValue("@Pin", Pin);
                cmd.Parameters.AddWithValue("@Aadhaar", Aadhaar);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@GuardianPhone", GurdianPhone);
                cmd.Parameters.AddWithValue("@GuardianEmail", GurdianEmail);
                

                connection.Open();
                AddressID = Convert.ToString(cmd.ExecuteScalar());

                return AddressID;
            }
            catch (Exception ex)
            {
                return AddressID;

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public int UpdateAddress()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateAddress", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AddressId", AddressID);
                cmd.Parameters.AddWithValue("@CareOf", CareOf);
                cmd.Parameters.AddWithValue("@Village", Village);
                cmd.Parameters.AddWithValue("@Post", Post);
                cmd.Parameters.AddWithValue("@Pin", Pin);
                cmd.Parameters.AddWithValue("@Aadhaar", Aadhaar);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@GuardianPhone", GurdianPhone);
                cmd.Parameters.AddWithValue("@GuardianEmail", GurdianEmail);


                connection.Open();
                cmd.ExecuteScalar();

                return 1;
            }
            catch (Exception ex)
            {
               return 0;

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
