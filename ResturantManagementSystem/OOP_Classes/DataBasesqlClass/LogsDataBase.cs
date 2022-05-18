using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using ResturantManagementSystem.OOP_Classes.DataBasesqlClass;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    public class LogsDataBase
    {
        public static string employeeJop;
        public static  int employeeId;
        public static string username;
        public static string password;
        public static int employeeShift;
     
        public static void setEmployeeId(SqlConnection connection, string userName, string password)
        {
            try
            {
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT UserId from Accounts Where UserName = '" + userName + "' and Password = '" + password + "'";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                DbDataReader reader = sqlcommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetOrdinal("UserId");
                        employeeId = Convert.ToInt32(reader.GetValue(id));


                    }
                   
                }
                reader.Close();
            } catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void setEmployeeUserName(string userName)
        {
            LogsDataBase.username = userName;
        }
        public static void setEmployeePassword(string password)
        {
            LogsDataBase.password = password;

        }
        public static void setEmployeeJop(SqlConnection connection, string userName, string password)
        {
            try {
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT Jop from Accounts Where UserName = '" + userName + "' and Password = '" + password + "'";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                DbDataReader reader = sqlcommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int jop = reader.GetOrdinal("Jop");
                        employeeJop = Convert.ToString(reader.GetValue(jop));


                    }
                   
                }
                reader.Close();
            } catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static void setEmployeeShift(SqlConnection connection, int id)
        {
            try
            {
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT Shift from Employee Where UserId = '" + id + "' ";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                DbDataReader reader = sqlcommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int shift = reader.GetOrdinal("Shift");
                        employeeShift = Convert.ToInt32(reader.GetValue(shift));


                    }
                     
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static bool isHaveAccount(SqlConnection connection, string userName, string password)
        {
            try { 
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT * from Accounts Where UserName = '" + userName + "' and Password = '" + password + "'";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                using ( DbDataReader reader = sqlcommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
          
                }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
              
                return false;
            }


        }
        public static bool login(SqlConnection Connection,string userName, string password )
        {
            if (isHaveAccount(Connection, userName, password))
            {
                setEmployeeJop(Connection, userName, password);
                setEmployeeId(Connection, userName, password);
                setEmployeeUserName(userName);
                setEmployeePassword(password);
                
                
                 return true;
            }
            else
            {

                return false;

            }
        } 
        public static void saveInLoginTable(SqlConnection connection, int id, string jop, int shift)
        {
            try { 
            SqlCommand sqlcomm = new SqlCommand();
            string query = "insert into Login values('" + id+"' , '"+DateTime.Now.ToString("MM/dd/yyyy")+"','"+ DateTime.Now.ToString("HH") + "' , '"+jop+"','"+shift+"') ";
            sqlcomm.Connection = connection;
            sqlcomm.CommandText = query;
            sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        
    }
        /*-----------------------------------------------------------------------------------------------------------------*/
        public static int Currentday(DbDataReader reader)
        {
            string[] days = new string[31];
            int currentDay = 0;
            int dayconter = 0;
            while (reader.Read())
            {
                for (dayconter = 1; dayconter <= 31; dayconter++)
                {
                   
                    days[dayconter-1 ] = reader.GetString(dayconter);
                    
                }
            }
           
           

            for (dayconter = 1; dayconter <= 31; dayconter++)
            {
                if (Int32.Parse(days[dayconter - 1]) == -1)
                {
                    currentDay = dayconter;
                    break;
                }

            }


            return currentDay;



        }
        public static bool CheckifLogin(SqlConnection connection, int id)
        {
            try
            {
                SqlCommand sqlcmmand = new SqlCommand();
                string query = "SELECT UserId from Login Where UserId = '" + id + "' ";
                sqlcmmand.Connection = connection;
                sqlcmmand.CommandText = query;
                DbDataReader Reader = sqlcmmand.ExecuteReader();
                using (Reader)
                {

                    if (Reader.HasRows)
                    {
                        Reader.Close();
                        Reader.Dispose();
                        return true;
                    }
                    else
                    {
                        Reader.Close();
                        Reader.Dispose();
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
        public static void isInLogin(SqlConnection connection, int Shift)
        {
            try
            {
                int idcounter =0 ;
                string reportBody = "";                    
                int id=0;
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT UserId from Employee Where Shift = '" + Shift + "' ";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                DbDataReader reader = sqlcommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {


                       
                        idcounter++;
                        Console.WriteLine("ID "+ idcounter);

                 

                    }

                    reader.Close();
                    reader.Dispose();
                   


                }
                int[] userId = new int[idcounter];
                int columnNumber = 0;
                query = "SELECT UserId from Employee Where Shift = '" + Shift + "' ";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                DbDataReader Reader = sqlcommand.ExecuteReader();
                using (Reader)
                {
                    while (Reader.Read())
                    {


                       
                        id = Reader.GetOrdinal("UserId");
                        userId[columnNumber] = Convert.ToInt32(Reader.GetValue(id));
                        columnNumber += 1;

                    

                    }

                    Reader.Close();
                    Reader.Dispose();
                    StaffReports staffReports1 = new StaffReports();
                    

                    for (int i = 0; i < idcounter; i++)
                    {
                      if (CheckifLogin(connection, userId[i])) 
                     {
                         bool islogin = true;
                         saveInLogoutTable(connection, userId[i]);
                         saveInMonthLogTable(connection, userId[i], calculateEmployeeHours(connection, userId[i], islogin));
                          
                            reportBody = reportBody + staffReports1.ShiftStaffReportBody(connection, calculateEmployeeHours(connection, userId[i], islogin), userId[i]);
                          
                        }
                     else
                     {
                         bool islogin = false;
                         saveInMonthLogTable(connection, userId[i], calculateEmployeeHours(connection, userId[i], islogin));
                            reportBody = reportBody + staffReports1.ShiftStaffReportBody(connection, calculateEmployeeHours(connection, userId[i], islogin), userId[i]);
                           
                        }
                    
                    }

                    string Reports = staffReports1.ReportForm(reportBody);
                    staffReports1.createStaffReport(connection, Reports, Shift);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }


           
        }
        public static void saveInLogoutTable(SqlConnection connection, int userID)
        {
            SqlCommand sqlcommand = new SqlCommand();
            string query = "insert into Logout values('" + userID + "','"+ DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH") + "' )";
            sqlcommand.Connection = connection;
            sqlcommand.CommandText = query;
            sqlcommand.ExecuteNonQuery();
        }
        public static void saveInMonthLogTable(SqlConnection connection , int UserId, string totalWorkHours)
        {
            try
            {
                int daycounter; 
                SqlCommand sqlcommand = new SqlCommand();
                string query = "SELECT * from MonthLog Where UserId = '" + UserId + "'";
                sqlcommand.Connection = connection;
                sqlcommand.CommandText = query;
                
                using (DbDataReader reader = sqlcommand.ExecuteReader())
                {
                    daycounter = Currentday(reader);
                    reader.Close();
                    SqlCommand sqlcmmand = new SqlCommand();
                    string Query = "update MonthLog set Day"+daycounter+"hours='" + totalWorkHours + "' Where UserId = '" + UserId + "' ";
                    sqlcmmand.Connection = connection;
                    sqlcmmand.CommandText = Query;
                    sqlcmmand.ExecuteNonQuery();
                               
                           
                      
                  
                   
                }
              
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static string calculateEmployeeHours(SqlConnection connection, int UserId , bool islogin)
        {
            string startWorkTime = "";
            string endWorkTime = "";
            string totalTime = "";
            if (islogin)
            {
                try
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    string query = "SELECT Time from Login Where UserId = '" + UserId + "'";
                    sqlcommand.Connection = connection;
                    sqlcommand.CommandText = query;
                    DbDataReader reader = sqlcommand.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            int Time = reader.GetOrdinal("Time");
                            startWorkTime = Convert.ToString(reader.GetValue(Time));
                        }
                        reader.Close();
                        reader.Dispose();

                    }
                    reader.Close();
                    reader.Dispose();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    string query = "SELECT Time from Logout Where UserId = '" + UserId + "'";
                    sqlcommand.Connection = connection;
                    sqlcommand.CommandText = query;
                    DbDataReader reader = sqlcommand.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            int Time = reader.GetOrdinal("Time");
                            endWorkTime = Convert.ToString(reader.GetValue(Time));
                        }
                        reader.Close();
                        reader.Dispose();

                    }
                    reader.Close();
                    reader.Dispose();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                 totalTime = Convert.ToString(Int32.Parse(startWorkTime) - Int32.Parse(endWorkTime));

                return totalTime;


            }
            else
            {
                return "0";
            }
        }
        public static void logOut(SqlConnection connection , int UserId , int dashboardType, int shift)
        {


            if(dashboardType == 1)/*manager*/
            {
                bool islogin = true;
                saveInLogoutTable(connection, UserId);
                string workHours = calculateEmployeeHours(connection, UserId, islogin);
                saveInMonthLogTable(connection, UserId,workHours );

            }
         
            else if (dashboardType == 3)/*stock*/
            {
                bool islogin = true;
                saveInLogoutTable(connection, UserId);
                string workHours = calculateEmployeeHours(connection, UserId, islogin);
                saveInMonthLogTable(connection, UserId, workHours);

            }
            else if (dashboardType == 4)/*staff*/
            {
                bool islogin = true;
                saveInLogoutTable(connection, UserId);
                string workHours = calculateEmployeeHours(connection, UserId, islogin);
                saveInMonthLogTable(connection, UserId, workHours);
            }
            else if (dashboardType == 5)/*casher*/
            {
                isInLogin(connection, shift);
               
            }
           
        }
    }
}
