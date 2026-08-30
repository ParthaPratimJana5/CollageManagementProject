using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Payment : CommonFilds
    {
      public string PaymentID { get; set; }
        public int PaymntStudentId { get; set; }
        public int PaymentTypeId { get; set; }
        public double PaymentAmount { get; set; }
        public int PaymentPourposeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentDiscription { get; set; }



        public DataTable getPaymentMode()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetPaymentType", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;



                return dataTable;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public DataTable getPaymentPourpose()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetPaymentPurpose", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;



                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;



                return dataTable;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        public int MakePayment()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spMakePayment", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@StudentId", PaymntStudentId);
                cmd.Parameters.AddWithValue("@PayTypeId",PaymentTypeId );
                cmd.Parameters.AddWithValue("@Amount ", PaymentAmount);
                cmd.Parameters.AddWithValue("@PaymentPurposeId", PaymentPourposeId);
                cmd.Parameters.AddWithValue("@DateOfPayment", PaymentDate);
                cmd.Parameters.AddWithValue("@Description", PaymentDiscription);

                connection.Open();
                return( Convert.ToInt16(cmd.ExecuteNonQuery()));

                

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



        public DataTable GetStudentBesicPaymentInfo(int studentID)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStudentDetailsWithPaymentById", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentId", studentID);



                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;



                return dataTable;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public DataTable GetStudentPaymentHistory(int studentID)
        { 
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            DataTable dt = new DataTable();

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spGetPaymentHistory", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", studentID);


                //if (studentID !=null)
                //{
                //    cmd.Parameters.AddWithValue("@StudentId", studentID);
                //}
                //else { cmd.Parameters.AddWithValue("@courseId", null); }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                sqlConnection.Open();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                return null;
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
