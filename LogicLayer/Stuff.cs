using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayer
{
    public class Stuff : Designation
    {

        public string TotalStaff { get; set; }
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StuffEmail { get; set; }
        public DateTime DateOfJoinning { get; set; }
        public string Salary { get; set; }
        public string BloodGroup { get; set; }

        public string StAddressId { get; set; }
        public string StPhotoID { get; set; }
        public string StBankID { get; set; }
        public string StDesignationID { get; set; }
        public string StDepartmentID { get; set; }
        public string StCvId { get; set; }
        public string StGendrId { get; set; }
        public string StAddress {  get; set; }
        public string StGenderName { get; set; }
        public string StDesignationName { get; set; }
        public string StDepartmentName { get; set; }


        public void getStaffRelatedIds()
        {
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                try
                {
                    using (SqlConnection connection = new SqlConnection(CS))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStaffLinkedIds", connection);
                        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StaffId", StaffID);

                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);

                        if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables[0].Rows[0];

                            StaffID = Convert.ToInt32(row["StaffId"]);
                            AddressID = row["AddressId"].ToString();
                            BankID = row["BankId"].ToString();
                            PhotoID = row["PhotoId"].ToString();
                            CVID = row["CVId"].ToString();
                            
                        }
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
        public int UpdateStaff()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUpdateStaffInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StaffId", this.StaffID);
                cmd.Parameters.AddWithValue("@StaffName", this.StaffName);
                cmd.Parameters.AddWithValue("@DateOfJoinning", this.DateOfJoinning);
                cmd.Parameters.AddWithValue("@GenderId ", Convert.ToInt16(StGendrId));
                cmd.Parameters.AddWithValue("@Email", this.StuffEmail);
                cmd.Parameters.AddWithValue("@Salary", this.Salary);
                cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
                cmd.Parameters.AddWithValue("@DesignationId", Convert.ToInt16(StDesignationID));
                cmd.Parameters.AddWithValue("@DepartmentId", Convert.ToInt16(StDepartmentID));





                connection.Open();
                StaffID = Convert.ToInt16(cmd.ExecuteScalar());

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
        public int InsertStuff()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertStaff", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@StaffName", this.StaffName);
                cmd.Parameters.AddWithValue("@DateOfJoinning", this.DateOfJoinning);
                cmd.Parameters.AddWithValue("@GenderId ", Convert.ToInt16(StGendrId));
                cmd.Parameters.AddWithValue("@Email", this.StuffEmail);
                cmd.Parameters.AddWithValue("@Salary", this.Salary);
                cmd.Parameters.AddWithValue("@AddressId", Convert.ToInt16(StAddressId));
                cmd.Parameters.AddWithValue("@PhotoId", Convert.ToInt16(StPhotoID));
                cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
                cmd.Parameters.AddWithValue("@DesignationId", Convert.ToInt16(StDesignationID));
                cmd.Parameters.AddWithValue("@BankId", Convert.ToInt16(StBankID));
                cmd.Parameters.AddWithValue("@DepartmentId", Convert.ToInt16(StDepartmentID));
                cmd.Parameters.AddWithValue("@CVId", Convert.ToInt16(StCvId));
                




                connection.Open();
                StaffID = Convert.ToInt16(cmd.ExecuteScalar());

                return StaffID;

            }
            catch (Exception ex)
            {
                return StaffID;

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        

        public void GetTotalFaculty()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;


            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spTotalStaff", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

                TotalStaff = Convert.ToString(cmd.ExecuteScalar());


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
        public void GetNextStuffID()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("spGetMaxStaffId", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                int Id = Convert.ToInt32(cmd.ExecuteScalar());
                Id++;
                StaffID = Id;
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

        public List <string> SearchStuff(string Name)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            List<string> list = null;
            


            try
            {
                connection = new SqlConnection(CS);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spSearchStaffBasic", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StaffName", Name);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;
                list = new List<string>();
                
                foreach (DataRow row in dataRowCollection)
                {
                    
                    string data = row["StaffId"].ToString();
                    data += " , ";
                    data += row["StaffName"].ToString();
                    data += " , ";
                    data += row["DepartmentName"].ToString();
                    list.Add(data);
                }

                return list;
               

            }
            catch (Exception ex)
            {
                return list ;
            }
            finally
            {
                connection.Close();
            }
        }


        public void GetFullStaffInfo()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetFullInfoByStaffId", connection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StaffId", StaffID);

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = dataSet.Tables[0].Rows[0];

                        StaffID = Convert.ToInt32(row["StaffId"]);
                        StaffName = row["StaffName"].ToString();
                        StGenderName=row["GenderName"].ToString();
                        StDesignationName = row["DesignationName"].ToString();
                        StDepartmentName = row["DepartmentName"].ToString();
                        StuffEmail = row["Email"].ToString();
                        DateOfJoinning = Convert.ToDateTime(row["DateOfJoinning"]);
                        Salary = row["Salary"].ToString();
                        BloodGroup = row["BloodGroup"].ToString();
                        CareOf = row["CareOf"].ToString();
                        StAddress = row["Village"].ToString();
                        Post = row["Post"].ToString();
                        PhoneNumber = row["PhoneNumber"].ToString();
                        BankName = row["BankName"].ToString();
                        BranchName = row["BranchName"].ToString();
                        AccountNumber = row["AccountNumber"].ToString();
                        IFSC = row["IFSC"].ToString();
                        Pin = row["Pin"].ToString();
                        Aadhaar = row["Aadhaar"].ToString();
                        Photobyte = row["Photo"] as byte[];
                        CVbyte = row["CV"] as byte[];
                    }
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
