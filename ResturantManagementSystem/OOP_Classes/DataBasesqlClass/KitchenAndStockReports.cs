using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    class KitchenAndStockReports 
    {

        public string ReportStart = "*******************************************Report*****************************************\n" +
           "Date : " + DateTime.Now.ToString("MM/dd/yyyy") + "     Time : " + DateTime.Now.ToString("HH:mm") + "\n" +
           "CompanyName : C Shark        ,Address : 22Wolf-Street - Cairo -Egypt        ,Mail : C.Shark22Wolf@gmail.com\n" +
           "---------------------------------------------------------------------------------------------------------------\n" +
            "itemID         itemName        costPerOne        quantity\n";
        public string ReportEnd = "--------------------------------------------------------------------------------------------------------\n" +
            "Hot Number : 19222      Phone Number : 011526104054 - 010053603057 - 012221853658\n" +
            "Delivery : 19225 - 01165983562 - 01023564898  \n" +
            "Owner : FCAIH_TEAM ";


        private int itemID;
        private string itemName;
        private float costPerOne;
        private float quantity;
        public string ReportBody;
        



        public string stockKitchenReportBody(int itemid,string itemname,float costperOne,float Quantity)
        {
           return ReportBody = ""+ itemid + "       "+itemname+"       "+costperOne+"        "+Quantity+"\n";
        }
        public void saveStockReport(SqlConnection connection , string repstart,string repend , string repbody)
        {
            string report = repstart + repbody + repend;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into StockReport values('" + EmployeeDataBase.EmployeeIdInSession + "','" + report + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH:mm") + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();

        }

        public void saveKitchenReport(SqlConnection connection, string repstart, string repend, string repbody)
        {
            string report = repstart + repbody + repend;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into KitchenReport values('" + EmployeeDataBase.EmployeeIdInSession + "','" + report + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("HH:mm") + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();

        }

        public void createstockReport(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT * from Stock ";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();
            string Report= "";
            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    this.itemID = itemReader.GetInt32(0);
                    this.itemName = itemReader.GetString(1);
                    this.costPerOne = (float)itemReader.GetDouble(2);
                    this.quantity = (float)itemReader.GetDouble(3);
                    Report = Report + stockKitchenReportBody(this.itemID, this.itemName, this.costPerOne, this.quantity);



                }
                itemReader.Close();
            }
            itemReader.Close();
            saveStockReport(connection, ReportStart, ReportEnd, Report);

        }
        public void createKitchenReport(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT * from Kitchen";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader itemReader = sqlCommand.ExecuteReader();
            string Report = "";

            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    this.itemID = itemReader.GetInt32(0);
                    this.itemName = itemReader.GetString(1);
                    this.costPerOne = (float)itemReader.GetDouble(2);
                    this.quantity = (float)itemReader.GetDouble(3);
                    Report = Report + stockKitchenReportBody(this.itemID, this.itemName, this.costPerOne, this.quantity);

                }
                itemReader.Close();
            }
            itemReader.Close();
            saveKitchenReport(connection, ReportStart, ReportEnd, Report);
        }

        public int ItemID { get => itemID; set => itemID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public float CostPerOne { get => costPerOne; set => costPerOne = value; }
        public float Quantity { get => quantity; set => quantity = value; }

    }
}
