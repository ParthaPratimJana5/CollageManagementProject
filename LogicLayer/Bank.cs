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
    public class Bank : Address
    {
        public string BankID { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string IFSC { get; set; }
        public string AccountNumber { get; set; }


        public string InsertBank()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spInsertBank", sqlConnection);
               
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BankName", BankName);
                cmd.Parameters.AddWithValue("@BranchName", BranchName);
                cmd.Parameters.AddWithValue("@IFSC", IFSC);
                cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                sqlConnection.Open();

                BankID = Convert.ToString(cmd.ExecuteScalar());

                return BankID;
            }
            catch (Exception ex)
            {
                return BankID;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int UpdateBank()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spUpdateBank", sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BankID", BankName);
                cmd.Parameters.AddWithValue("@BankName", BankName);
                cmd.Parameters.AddWithValue("@BranchName", BranchName);
                cmd.Parameters.AddWithValue("@IFSC", IFSC);
                cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                sqlConnection.Open();

                cmd.ExecuteScalar();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
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
