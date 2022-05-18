using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    class StockRepository
    {
        DataBaseConnection dbConnection = new DataBaseConnection();

        public void save(Stock stock)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "insert into Stock values('" + stock.GoodId + "' , '" + stock.GoodName + "','" + stock.CostPerOne + "' , '" + stock.Quantity + "')";
                sqlcomm.Connection = dbConnection.openConnection();
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }


        public void update(Stock stock)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "UPDATE  Stock SET GoodsID='" + stock.GoodId + "' ,GoodsName= '" + stock.GoodName + "',CostPerOne='" + stock.CostPerOne + "' ,Quantity= '" + stock.Quantity + "'Where GoodsID='" + stock.GoodId + "'";
                sqlcomm.Connection = dbConnection.openConnection();
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void delete(Stock stock)
        {
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                string query = "delete from Stock WHERE  GoodsID= '" + stock.GoodId + "';";
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
