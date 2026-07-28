using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LogicLayer
{
    public class Student : Enrollment
    {
        public string TotalStudents { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth {  get; set; }
        //public string SGenderID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SAddressID { get; set; }
        public string SphotoID { get; set; }
        public string SGenderID { get; set; }

        public string StudentID { get; set; }
        
        

        //Student student=new Student();
   

        public void GetTotalStudent()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spTotalStudents", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

                TotalStudents = Convert.ToString(cmd.ExecuteScalar());
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

        public void GetStudentID()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spGetMaxStudentId", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                int Id = Convert.ToInt32(cmd.ExecuteScalar());
                Id++;
                StudentID= Id.ToString();
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

        public void SetStudent()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@StudentName", this.StudentName);
                cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                cmd.Parameters.AddWithValue("@GenderId ", Convert.ToInt16(SGenderID));
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Phone", this.Phone);
                cmd.Parameters.AddWithValue("@AddressId", Convert.ToInt16(SAddressID));
                cmd.Parameters.AddWithValue("@PhotoId", Convert.ToInt16(SphotoID));
               


                connection.Open();
                StudentID = Convert.ToString(cmd.ExecuteScalar());



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
        public DataSet SearchStudent()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            DataSet ds = null;
            

            try
            {
                connection = new SqlConnection(CS);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStudentFullInfo", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentName", this.StudentName);
                ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                

                return ds;

            }
            catch (Exception ex)
            {
                return ds;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
