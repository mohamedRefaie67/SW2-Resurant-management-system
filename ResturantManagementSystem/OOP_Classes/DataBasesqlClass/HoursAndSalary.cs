using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class HoursAndSalary
    {



        public int CalculateMonthHours(SqlConnection connection , int  userid)
        {
            int TotalWorkHours = 0;
            int day = 1;
            SqlCommand sqlcommand = new SqlCommand();
            string query = "SELECT * from MonthLog Where UserId = '" + userid + "'";
            sqlcommand.Connection = connection;
            sqlcommand.CommandText = query;
            DbDataReader reader = sqlcommand.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    
                    TotalWorkHours = TotalWorkHours + Int32.Parse(reader.GetString(day));
                    day++;
                }
                reader.Close();

            }
            return TotalWorkHours;
        }

        public int CalculateDayoff(SqlConnection connection, int userid)
        {
            int Totaldayoff = 0;
            int day = 1;
            SqlCommand sqlcommand = new SqlCommand();
            string query = "SELECT * from MonthLog Where UserId = '" + userid + "'";
            sqlcommand.Connection = connection;
            sqlcommand.CommandText = query;
            DbDataReader reader = sqlcommand.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    if (Int32.Parse(reader.GetString(day))==0){
                        Totaldayoff += 1;
                    }
                    day++;
                    
                }
                reader.Close();

            }
            return Totaldayoff;
        }

        public float Salary(SqlConnection connection ,int totalhours ,int userid)
        {
            float salary = 0;
            SqlCommand sqlcommand = new SqlCommand();
            string query = "SELECT SalaryPerHour from Employee Where UserId = '" + userid + "'";
            sqlcommand.Connection = connection;
            sqlcommand.CommandText = query;
            DbDataReader reader = sqlcommand.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {

                    salary = (float)reader.GetDouble(0) * totalhours;

                }
                reader.Close();

            }

            return salary;
        }

    }
}
