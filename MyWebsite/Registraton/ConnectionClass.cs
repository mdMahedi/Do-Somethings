using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MyWebsite.Registraton
{
    public class ConnectionClass
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sql_testDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        //public static SqlConnection GetConnectionIntoASPNETdb()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["sql_aspnetDB"].ConnectionString;
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    conn.Open();
        //    return conn;
        //}
    }
}