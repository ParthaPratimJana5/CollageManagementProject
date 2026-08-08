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
    public class Enrollment : Attandance
    {
        public string EnrollmentID { get; set; }
        public DateTime DateOfAdmition {  get; set; }
        public string EnrollmentStudentID { get; set; }
        //public string EnrollmentCourseID { get; set; }

        
        public void InsertEnrollment ()
        {
            
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertEnrollment", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32( EnrollmentStudentID));
                cmd.Parameters.AddWithValue("@CourseId", Convert.ToInt32( CourseId));
                cmd.Parameters.AddWithValue("@AdmissionDate", DateOfAdmition );
                


                connection.Open();
                EnrollmentID = Convert.ToString(cmd.ExecuteScalar());



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


        public void UpdateEnrollment()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateEnrollment", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@EnrollmentId", Convert.ToInt32(EnrollmentID));
                cmd.Parameters.AddWithValue("@CourseId", Convert.ToInt32(CourseId));
                cmd.Parameters.AddWithValue("@AdmissionDate", DateOfAdmition);



                connection.Open();
                EnrollmentID = Convert.ToString(cmd.ExecuteScalar());



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

        public DataTable GetBatch()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAdmissionYears", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                


                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                //DataRowCollection dataRowCollection = dataTable.Rows;




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

    }
}
