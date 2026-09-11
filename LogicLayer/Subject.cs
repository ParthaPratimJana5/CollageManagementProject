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
    public class Subject : Photos
    {
        public string SubjectID {  get; set; }
        public string SubjectName { get; set; }
        public string SubjectStaffID { get; set; }

        public DataTable GetSubectsbyCourseId()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetSubjectsByCourseId", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CourseId", CourseId);


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


        

        public string AddSubject()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand("spAddSubject", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
                cmd.Parameters.AddWithValue("@CourseId", Convert.ToInt16 (CourseId));
                cmd.Parameters.AddWithValue("@StaffId", Convert.ToInt16 (SubjectStaffID) );

                conn.Open();
                object result = cmd.ExecuteScalar(); // returns the message string
                conn.Close();

                return result?.ToString();
            }
        }

        public DataTable GetSubject(string Data)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetSubject", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@SubjectId", Data);

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

        public string EditSubject(int subjectId, string subjectName, int courseId, int staffId)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spEditSubject", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                cmd.Parameters.AddWithValue("@StaffId", staffId);

                connection.Open();

                // return rows affected as string
                return (cmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                // you can log ex.Message if needed
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
