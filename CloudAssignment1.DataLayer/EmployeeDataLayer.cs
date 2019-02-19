using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CloudAssignment1.DataLayer
{
    public class EmployeeDataLayer
    {
        private static readonly string SchemaName = "nkumar.";
        public DataTable GetAllEmployeeDataFromDB()
        {
            string connStr = "server=db.cs.dal.ca;user=nkumar;database=nkumar;port=3306;password=B00782012";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = SchemaName + "sp_GetAllEmployees";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                return dt;
            }
            catch(MySqlException msex)
            {
                if(msex.ErrorCode == 2000)
                {
                    throw new Exception("Foregin key violation constraint");
                }

                throw msex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}