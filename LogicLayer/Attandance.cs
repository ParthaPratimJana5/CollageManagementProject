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
    public class Attandance : Result
    {
       
        public string AttandanceStudentID { get; set; }
        public string AttandanceSubjectID { get; set; }
        public DateTime AttandanceDate { get; set; }

        public bool Present { get; set; }



        public DataTable LoadStudents(string courseId, string Year)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("spSearchStudentsByCourseAndYear", conn);

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.AddWithValue("@CourseId", courseId);
                    da.SelectCommand.Parameters.AddWithValue("@AdmissionYear", Year);

                    

                    da.Fill(dt);

                   

                    return dt;
                }
                catch (Exception ex)
                {
                    return dt;
                }
            }
        }


        //public int AttandancheckNonDuplicate(DateTime date, string course, string SubjectId )
        //{
        //    {
        //        int count=0;
        //        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //        using (SqlConnection conn = new SqlConnection(cs))
        //        {
                    
        //            try
        //            {
        //                conn.Open();

        //                // Duplicate Check
        //                SqlCommand checkCmd = new SqlCommand("spCheckAttendance", conn);
        //                checkCmd.CommandType = CommandType.StoredProcedure;

        //                checkCmd.Parameters.AddWithValue("@AttendanceDate", date);
        //                checkCmd.Parameters.AddWithValue("@CourseId", Convert.ToInt32(course));
        //                checkCmd.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(SubjectId));

        //                count = Convert.ToInt32(checkCmd.ExecuteScalar());

        //                return count;
        //            }
        //            catch (SqlException ex)
        //            {
        //                return count;
        //            }
        //        }
        //    }
        //}

        public string AddAttendance()
        {
             
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand("spAddAttendance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32( AttandanceStudentID));
                    cmd.Parameters.AddWithValue("@SubjectId", Convert.ToInt32( AttandanceSubjectID));
                    cmd.Parameters.AddWithValue("@AttendanceDate", AttandanceDate);
                    cmd.Parameters.AddWithValue("@Status", Present);

                    conn.Open();
                    object result = cmd.ExecuteScalar().ToString();
                    conn.Close();

                    return result?.ToString();
                }
            }
            


        }

        public DataTable GetAttendanceReport(string filterType, DateTime? startDate, DateTime? endDate, int? courseId)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            DataTable dt = new DataTable();

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spGetAttendanceReport", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@filterType",filterType.ToLower());
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                if (courseId > -1)
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                }
                else { cmd.Parameters.AddWithValue("@courseId", null); }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                sqlConnection.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // you can log or show error
                //throw new Exception("Error fetching attendance report: " + ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

            return dt;
        }

        //public void SaveAttendance()
        //{
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(cs))
        //    {
        //        conn.Open();





        //            SqlCommand cmd = new SqlCommand("spAddAttendance", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@StudentId", AttandanceStudentID );

        //            cmd.Parameters.AddWithValue("@SubjectId", AttandanceSubjectID);

        //            cmd.Parameters.AddWithValue("@AttendanceDate", AttandanceDate);



        //            cmd.Parameters.AddWithValue("@AttendanceStatus", Present);

        //            cmd.ExecuteNonQuery();



        //    }
        //}
    }
}
