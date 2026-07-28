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
    public class Gender: Course
    {
        public List <string> GenderList {  get; set; }
        public string GenderID { get; set; }



        public void GetGennder()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            

            try
            {
                connection = new SqlConnection(cs);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetGender", connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];

                DataRowCollection dataRowCollection = dataTable.Rows;

               GenderList= new List<string>();
                foreach (DataRow row in dataRowCollection)
                {
                    string data = row["GenderName"].ToString();
                    GenderList.Add(data);
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

       public string GetGenderID(string gend)
        {
            
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetGenderID", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                
                    cmd.Parameters.AddWithValue("@GenderName", gend);
                    connection.Open();
                GenderID = Convert.ToString( cmd.ExecuteScalar());

                return GenderID;
                   
            }
            catch (Exception ex)
            {

                return GenderID;
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
