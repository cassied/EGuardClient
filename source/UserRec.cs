using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Configuration;

namespace EGuardClient
{
    class UserRec
    {
     
        public UserRec()
        {
                     
        }

        public Boolean authenticateUser(string username, string password)
        {
            Boolean authenticated = false;
            int rec = 0;

            SqlCeConnection con = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            SqlCeCommand cmd = new SqlCeCommand();
               
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM UserRec WHERE Username='" + username + "' AND Password = '" +password + "';";
            
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteScalar();
                rec = (int)cmd.ExecuteScalar();
                if (rec == 1)
                {
                    authenticated = true;
                }
                else
                {
                    authenticated = false;
                }
            }
            catch
            {
                authenticated = false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();                  
                }
                
            }
            return authenticated;
        }       
    }
}
