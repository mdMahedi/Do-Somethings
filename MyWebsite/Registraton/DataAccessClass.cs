using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Registraton
{
    public class DataAccessClass
    {
        public bool InsertEmployeeRegistration(int id, string name, string pass, string rePass, string emil) {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            SqlCommand comnd = new SqlCommand("[dbo].[InsertRegPage]", conn);
            comnd.CommandType = CommandType.StoredProcedure;

            comnd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comnd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            comnd.Parameters.Add("@pass", SqlDbType.NVarChar, 100).Value = pass;
            comnd.Parameters.Add("@RePass", SqlDbType.NVarChar, 100).Value = rePass;
            comnd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = emil;

            if (comnd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckLoginValueFromSQL(string email, string passwrd) {
            string mail="";
            string pass="";

            SqlConnection conn = ConnectionClass.GetSqlConnection();
            SqlCommand comnd = new SqlCommand("select [email],[passwrd] from [dbo].[RegistrationPage]", conn);
            SqlDataReader reader = comnd.ExecuteReader();
            while (reader.Read())
            {
               mail= reader.GetString(0);
               pass= reader.GetString(1);
            }
            if (email == mail && passwrd == pass)
                return true;
            else return false;
        }
    }
}