using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ResturantManagementSystem.OOP_Classes
{
    class DataBaseConnection
    {
        string connectionString = @"Data Source=ZIDAN-PC\SQLEXPRESS;Initial Catalog=Resturant;Integrated Security=True;";
        private SqlConnection Connection;


        public SqlConnection openConnection()
        {
            try
            {

                Connection = new SqlConnection(connectionString);
                Connection.Open();
               

            }
            catch(SqlException exeption)
            {
                MessageBox.Show(exeption.ToString());
            }
            return Connection;
        }

    }
}
