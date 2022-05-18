using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class CasherStockReport
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

        public void AddToRequest(SqlConnection connection ,int userid , int ingid , int Quantity)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into Request values('" + userid + "','" + ingid + "','" + Quantity + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public string OrderReportBody(int mealid, string mealname, int Quntity)
        {
            return "" + mealid + "        " + mealname + "        " + Quntity + "\n\n";
        }
        public void createRequestReport(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = "SELECT Request.IngId, Request.Quantity, Stock.GoodsName  FROM Request INNER JOIN Stock ON Request.IngId = Stock.GoodsID ";
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
            }
            
            Console.WriteLine("REPOOOOOrt" + ReportBody);
            saveCasherRequestReport(connection);

        }
        public void saveCasherRequestReport(SqlConnection connection)
        {
            string casherStockReport = ReportStart + ReportBody + ReportEnd;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            Console.WriteLine("Before sqlquey\n" );
            string query = "insert into CasherStockReports Values(" + EmployeeDataBase.EmployeeIdInSession + ",'" + casherStockReport + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH:mm") + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("after sqlquey\n");
        }
    }
}
