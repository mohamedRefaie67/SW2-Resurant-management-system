using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class InvoicesAndOrdersReport
    {
        public string ReportStart = "*******************************************Report*****************************************\n" +
        "Date : " + DateTime.Now.ToString("MM/dd/yyyy") + "     Time : " + DateTime.Now.ToString("HH:mm") + "\n" +
        "CompanyName : C Shark        ,Address : 22Wolf-Street - Cairo -Egypt        ,Mail : C.Shark22Wolf@gmail.com\n" +
        "---------------------------------------------------------------------------------------------------------------\n" +
         "mealid         mealname        quantity\n";
        public string ReportEnd = "--------------------------------------------------------------------------------------------------------\n" +
            "Hot Number : 19222      Phone Number : 011526104054 - 010053603057 - 012221853658\n" +
            "Delivery : 19225 - 01165983562 - 01023564898  \n" +
            "Owner : FCAIH_TEAM ";
        public string ReportBody;

        public void addToInvoiceOrder(SqlConnection connection ,int MealId, int quntity)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into OrderInvoice values('" + EmployeeDataBase.EmployeeIdInSession + "','" + MealId + "','" + quntity + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteFromInvoiceOrder(SqlConnection connection, int MealId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "delete from OrderInvoice where MealId = '"+MealId+"')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }


        public string InvoiceBody(int mealid ,string mealname , int quantity)
        {
            return "" + mealid + "        " + mealname + "        " + quantity + "\n\n";
        }
        public string OrderReportBody(int mealid, string mealname, int Counter)
        {
            return "" + mealid + "        " + mealname + "        " + Counter + "\n\n";
        }


        public void createInvoice (SqlConnection connection )
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT OrderInvoice.MealId OrderInvoice.Quantity MealMenu.MealName   from OrderInvoice INNER JOIN MealMenu on OrderInvoice.MealId =MealMenu.MealID  ";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();
           
            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {

                    ReportBody = ReportBody + InvoiceBody(itemReader.GetInt32(0), itemReader.GetString(2), itemReader.GetInt32(1));            
                }
                itemReader.Close();
            }
            itemReader.Close();
            saveInvoice(connection);
           
        }
       
        public void saveInvoice(SqlConnection connection)
        {
            string Invoice = ReportStart+ ReportBody + ReportEnd;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into Invoices values('" + EmployeeDataBase.EmployeeIdInSession + "','" + Invoice + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH:mm") + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
/*------------------------------------------------------------------------------------------------*/
        public void createOrderReport(SqlConnection connection)
        {

            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT MealsCounter.MealId  MealsCounter.Counter   MealMenu.MealName    from MealsCounter INNER JOIN MealMenu on MealsCounter.MealId =MealMenu.MealID  ";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();
            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    ReportBody = ReportBody + OrderReportBody(itemReader.GetInt32(0), itemReader.GetString(2), itemReader.GetInt32(1));
                }
                itemReader.Close();
                saveOrderReport(connection);
            }

        }
            public void saveOrderReport(SqlConnection connection)
        {
            string orderReport = ReportStart + ReportBody + ReportEnd;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into OrderReports values('" + EmployeeDataBase.EmployeeIdInSession + "','" + orderReport + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH:mm") + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public string retriveInvoice(SqlConnection connection , int userid)
        {

            string invoice = "";
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT   Invoice  from Invoices  where  UserId ='"+ userid + "'  ";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();

            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {

                    invoice = itemReader.GetString(0);
                }
                itemReader.Close();
            }
            itemReader.Close();
            return invoice;
        }





    }
 
}
