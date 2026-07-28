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
    public class Designation : Department
    {
       public List <string> DesignationList { get; set; }
       public string DesignationID {  get; set; }


        public void GetDesignation()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;



            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetDesignation", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;

                DesignationList= new List<string>();
                foreach (DataRow row in dataRowCollection)
                {
                    string data = row["DesignationName"].ToString();
                    DesignationList.Add(data);
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
        public string GetDesignationID(string Desig)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetDesignationID", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@DesignationName", Desig);
                connection.Open();
                DesignationID = Convert.ToString(cmd.ExecuteScalar());
                return DesignationID;
            }
            catch (Exception ex)
            {

                return DesignationID;
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
