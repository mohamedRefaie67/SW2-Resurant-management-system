using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class StaffReports
    {
        public string ReportStart = "*******************************************Staff Shift Report*****************************************\n" +
             "Date : " + DateTime.Now.ToString("MM/dd/yyyy") + "     Time : " + DateTime.Now.ToString("HH:mm") + "\n" +
             "CompanyName : C Shark        ,Address : 22Wolf-Street - Cairo -Egypt        ,Mail : C.Shark22Wolf@gmail.com\n" +
             "---------------------------------------------------------------------------------------------------------------\n";
        public string ReportEnd = "--------------------------------------------------------------------------------------------------------\n" +
            "Hot Number : 19222      Phone Number : 011526104054 - 010053603057 - 012221853658\n" +
            "Delivery : 19225 - 01165983562 - 01023564898  \n" +
            "Owner : FCAIH_TEAM ";
        public string ReportBody;

        EmployeeDataBase employeeDataBase = new EmployeeDataBase();
        public string ReportForm(string repbody)
        {
            return ReportStart + repbody + ReportEnd;
        }

        public string ShiftStaffReportBody(SqlConnection connection, string hours, int userid)
        {
            string ReportBody;
            employeeDataBase.setEmployeeData(connection, userid);

            if (hours.Equals("0"))
            {
                ReportBody = "   Emp.Name      Emp.Jop      Emp.Shift      WorkHours   \n" + employeeDataBase.FirstName + " " + employeeDataBase.LastName + "      " + employeeDataBase.Jop + "      " + employeeDataBase.Shift + "      DayOff\n";
            }
            else
            {
                ReportBody = "   Emp.Name      Emp.Jop      Emp.Shift      WorkHours   \n" + employeeDataBase.FirstName + " " + employeeDataBase.LastName + "      " + employeeDataBase.Jop + "      " + employeeDataBase.Shift + "      " + hours + "\n";

            }

            return ReportBody;
        }

        public void createStaffReport(SqlConnection connection, string report, int shift)
        {
            try
            {

                SqlCommand sqlcomm = new SqlCommand();
                string query = "insert into ShiftStaffReports values('" + EmployeeDataBase.EmployeeIdInSession + "' ,'" + report + "' ,'" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH") + "' ,'" + shift + "') ";
                sqlcomm.Connection = connection;
                sqlcomm.CommandText = query;
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string monthreport(int userid ,int hours ,int day ,float salary )
        {
            return "" + userid + "        " + hours + "        " + day + "       " + salary + "\n";
        }

        public string CreateStaffReportMonthly(SqlConnection connection)
        {
            string report="";
            int cont = 0;
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT UserId from Employee";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            cont =Convert.ToInt32(sqlCommand.ExecuteScalar());
            int[] userId = new int[cont];
            int user = 0;
            query = " SELECT UserId from Employee";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader employeeReader = sqlCommand.ExecuteReader();
            using (employeeReader)
            {
                while (employeeReader.Read())
                {
                    userId[user] = employeeReader.GetInt32(user);
                    user++;
                }
                employeeReader.Close();

            }
            HoursAndSalary hoursAndSalary = new HoursAndSalary();
            for(int users = 0; users <= cont; users++)
            {
                 int day = hoursAndSalary.CalculateDayoff(connection, userId[users]);
               int hours = hoursAndSalary.CalculateMonthHours(connection, userId[users]);
                 float salary  =hoursAndSalary.Salary(connection, hours, userId[users]);
                ReportBody = ReportBody + monthreport(userId[users], hours, day, salary);

            }

            return report;
        }

        public void saveMOnthReport(SqlConnection connection)
        {

            string report = ReportStart + ReportBody + ReportEnd;

            SqlCommand sqlcomm = new SqlCommand();
            string query = "insert into MonthStaffReport values('" + EmployeeDataBase.EmployeeIdInSession + "' ,'" + report + "' ,'" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH") + "') ";
            sqlcomm.Connection = connection;
            sqlcomm.CommandText = query;
            sqlcomm.ExecuteNonQuery();

        }


    }
}
