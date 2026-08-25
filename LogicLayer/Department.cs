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
    public class Department : HOD
    {
        public List <string> DepartmemtList {  get; set; }
        public string DepartmemtID { get; set; }

        public DataTable GetDepartmemt()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetDepartment", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;

                DepartmemtList = new List<string>();
                foreach (DataRow row in dataRowCollection)
                {
                    string data = row["DepartmentName"].ToString();
                    DepartmemtList.Add(data);
                }

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

        public string GetDepartmemtID(string Dept)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetDepartmentID", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@DepartmentName", Dept);
                connection.Open();
                DepartmemtID= Convert.ToString(cmd.ExecuteScalar());

                return DepartmemtID;

            }
            catch (Exception ex)
            {

                return DepartmemtID;
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
