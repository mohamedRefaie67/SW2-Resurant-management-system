using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace ResturantManagementSystem.OOP_Classes
{
    class StaffLogs
    {
        private string Query;
        private SqlCommand cmd = new SqlCommand();
        public static int jop;

        /*--------------------------------------------------------------------*/
/*------------------------------------------------------------------------------------------------------------------------*/
        public int login(SqlConnection conn, string username, string password)
        {
            Query = "Select *from Accounts Where UserName ='" + username + "' and Password = '" + password + "'";
            cmd.Connection = conn;
            cmd.CommandText = Query;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int Jopindex = reader.GetOrdinal("Jop");
                        jop =Convert.ToInt32( reader.GetValue(Jopindex));
                    }
                }else
                {
                    return 0;
                } 
            }
            return jop;
        }
/*------------------------------------------------------------------------------------------------------------------*/


    }

}
