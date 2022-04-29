using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ResturantManagementSystem.OOP_Classes
{

    class DataBaseConnection
    {

        SqlConnection conn = new SqlConnection("Data Source=ZIDAN-PC\\SQLEXPRESS;Initial Catalog=Resturant;Integrated Security=True");

        public SqlConnection DbConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Db Connected");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error In Db Connection");
            }
            return conn;
        }
        

    }
}
