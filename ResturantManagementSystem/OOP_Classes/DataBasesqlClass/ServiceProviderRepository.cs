using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    class ServiceProviderRepository
    {
        DataBaseConnection dbConnection = new DataBaseConnection();

        public void save(ServiceProvider serviceProvider)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "insert into ServiceProvider values('" + serviceProvider.CompanyID + "' , '" + serviceProvider.Name + "','" + serviceProvider.Email + "' , '" + serviceProvider.Phone + "','" + serviceProvider.Address + "')";
                sqlcomm.Connection = dbConnection.openConnection();
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void update(ServiceProvider serviceProvider)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "UPDATE  ServiceProvider SET CompanyID ='" + serviceProvider.CompanyID + "' ,CoName ='" + serviceProvider.Name + "',CoEmail ='" + serviceProvider.Email + "',CoPhone ='" + serviceProvider.Phone + "', CoAddress ='" + serviceProvider.Address + "' Where CompanyID ='" + serviceProvider.CompanyID + "'";
                sqlcomm.Connection = dbConnection.openConnection();
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void delete(ServiceProvider serviceProvider)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "delete from ServiceProvider WHERE  CompanyID= '" + serviceProvider.CompanyID + "';";
                sqlcomm.Connection = dbConnection.openConnection();
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
