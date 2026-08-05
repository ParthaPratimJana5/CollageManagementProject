using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Course : BloodGrouP
    {
        public List<String> CourseList {  get; set; }
        public string CourseName { get; set; }
        public string TotalCource { get; set; }
        public string CourseId { get; set; }
         //Total Course
        public void GetTotalCourse()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spTotalCourses", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

                TotalCource = Convert.ToString(cmd.ExecuteScalar());
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

        public void GetCourse()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetCourse", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;

                CourseList = new List<string>();
                foreach (DataRow row in dataRowCollection)
                {
                    string data = row["CourseName"].ToString();
                    CourseList.Add(data);
                }



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

        public void GetCourseIdByName()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetCourseIdByName", connection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CourseName", CourseName);

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    
                        DataRow row = dataSet.Tables[0].Rows[0];

                          CourseId = row["CourseId"].ToString();
                        
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
