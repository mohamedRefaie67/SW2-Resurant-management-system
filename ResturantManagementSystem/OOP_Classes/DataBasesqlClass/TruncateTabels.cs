using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    class TruncateTabels
    {

        public bool IfMonthcompelete(SqlConnection connection ,int shift, int userid)
        {
            string day31="";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "select Day31hours from MonthLog where UserId='" + userid+"'";
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();

            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    day31 = itemReader.GetString(0);
                    
                }
                itemReader.Close();
            }
            itemReader.Close();
            if (Int32.Parse(day31) >= 0)
            {

                return true;
            }
            else
            {
                return false;

            }



           
        }
        public void truncateRequst(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "TRUNCATE TABLE Request";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void truncateOrderInvoice(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "TRUNCATE TABLE OrderInvoice";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void truncateLogin(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "TRUNCATE TABLE Login";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void truncateLogout(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "TRUNCATE TABLE Logout";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void intialMonthLog(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "update MonthLog set  Day1hours='-1' ,Day2hours='-1' " +
                ",Day3hours='-1' ,Day4hours='-1' ,Day5hours='-1' ,Day6hours='-1' ,Day7hours='-1' " +
                ",Day8hours='-1' ,Day9hours='-1' ,Day10hours='-1' ,Day11hours='-1' ,Day12hours='-1' " +
                ",Day13hours='-1' ,Day14hours='-1' ,Day15hours='-1' ,Day16hours='-1' ,Day17hours='-1' " +
                ",Day18hours='-1' ,Day19hours='-1' ,Day20hours='-1' ,Day21hours='-1' ,Day22hours='-1' " +
                ",Day23hours='-1' ,Day24hours='-1' ,Day25hours='-1' ,Day26hours='-1' ,Day27hours='-1' " +
                ",Day28hours='-1' ,Day29hours='-1' ,Day30hours='-1' , Day31hours='-1' ";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void truncateMealsCounter(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "TRUNCATE TABLE MealsCounter";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }


    }
}
