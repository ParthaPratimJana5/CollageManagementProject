using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
               


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

        public List<string> SearchStudentBesicInfo(string Name)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            List<string> list = null;



            try
            {
                connection = new SqlConnection(CS);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spSearchStudentBesicInfoByName", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentName", Name);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;
                list = new List<string>();

                foreach (DataRow row in dataRowCollection)
                {

                    string data = row["StudentId"].ToString();
                    data += " , ";
                    data += row["StudentName"].ToString();
                    data += " , ";
                    data += row["CourseName"].ToString();
                    data += " , ";
                    data += row["Guardian"].ToString();
                    list.Add(data);
                }

                return list;


            }
            catch (Exception ex)
            {
                return list;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateStudent()

        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt16(StudentID));

                cmd.Parameters.AddWithValue("@StudentName", this.StudentName);
                cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                cmd.Parameters.AddWithValue("@GenderId ", Convert.ToInt16(SGenderID));
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Phone", this.Phone);
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);



                connection.Open();
                cmd.ExecuteScalar();



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

        public void GetFullStudentInfo()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStudentFullInformationById", connection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentId", Convert.ToInt32(StudentID));

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = dataSet.Tables[0].Rows[0];

                        StudentID = row["StudentId"].ToString();
                        StudentName = row["StudentName"].ToString();
                        DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                        GenderName = row["GenderName"].ToString();
                        Email = row["Email"].ToString();
                        Phone = row["Phone"].ToString();

                        CareOf = row["Guardian"].ToString();
                        BloodGroup = row["BloodGroup"].ToString();
                        Village = row["Village"].ToString();
                        Post = row["Post"].ToString();
                        PhoneNumber = row["PhoneNumber"].ToString();
                        CourseName = row["CourseName"].ToString();
                        GurdianEmail = row["GuardianEmail"].ToString();
                        GurdianPhone = row["GuardianPhone"].ToString();
                        Pin = row["Pin"].ToString();
                        Aadhaar = row["Aadhaar"].ToString();
                        Photobyte = row["Photo"] as byte[];

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void GetStudentRelatedId()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStudentRelatedIds", connection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentId", Convert.ToInt32(StudentID));

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = dataSet.Tables[0].Rows[0];

                        
                        AddressID = row["AddressId"].ToString();
                        PhotoID = row["PhotoId"].ToString();
                        EnrollmentID = row["EnrollmentId"].ToString();


                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
