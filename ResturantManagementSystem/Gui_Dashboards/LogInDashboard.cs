using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ResturantManagementSystem.OOP_Classes;
using ResturantManagementSystem.OOP_Classes.DataBaseHandel;

namespace ResturantManagementSystem
{
    public partial class LogInDashboard : Form
    {
        DataBaseConnection ConnectDataBase = new DataBaseConnection();
      
        
        SqlConnection Connection = new SqlConnection();
        ManagerDashboard Manager = new ManagerDashboard();
     
        StockDashboard Stock = new StockDashboard();
        CasherDashboard Casher = new CasherDashboard();
       

        public LogInDashboard()
        {
          
            InitializeComponent();
            Connection = ConnectDataBase.openConnection();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInDashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

       
           try
            {
                if( LogsDataBase.login(Connection, UserName.Text, Password.Text))
                {
                    if( LogsDataBase.employeeJop.Equals("Manager"))
                    {
                        this.Visible = false;
                        EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase( LogsDataBase.employeeId);
                        LogsDataBase.setEmployeeShift(Connection,  LogsDataBase.employeeId);
                        employeeDataBaseHandel.setEmployeeData(Connection,  LogsDataBase.username,  LogsDataBase.password,  LogsDataBase.employeeJop);
                        LogsDataBase.saveInLoginTable(Connection, employeeDataBaseHandel.UserId,employeeDataBaseHandel.Jop, employeeDataBaseHandel.Shift);
                        Manager.Visible = true;
                        EmployeeDataBase.EmployeeIdInSession = LogsDataBase.employeeId;


                    }

                    else if ( LogsDataBase.employeeJop.Equals("StockKeeper"))
                    {
                        EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(LogsDataBase.employeeId);
                        KitchenAndStockReports kitchenAndStockReports = new KitchenAndStockReports();
                        LogsDataBase.setEmployeeShift(Connection, LogsDataBase.employeeId);
                        employeeDataBaseHandel.setEmployeeData(Connection, LogsDataBase.username, LogsDataBase.password, LogsDataBase.employeeJop);
                        LogsDataBase.saveInLoginTable(Connection, employeeDataBaseHandel.UserId, employeeDataBaseHandel.Jop, employeeDataBaseHandel.Shift);
                        this.Visible = false;
                        Stock.Visible = true;
                        EmployeeDataBase.EmployeeIdInSession = LogsDataBase.employeeId;
                        kitchenAndStockReports.createstockReport(Connection);



                    }
                    else if ( LogsDataBase.employeeJop.Equals("Casher"))
                    {
                        EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(LogsDataBase.employeeId);
                        KitchenAndStockReports kitchenAndStockReports = new KitchenAndStockReports();
                        LogsDataBase.setEmployeeShift(Connection, LogsDataBase.employeeId);
                        employeeDataBaseHandel.setEmployeeData(Connection, LogsDataBase.username, LogsDataBase.password, LogsDataBase.employeeJop);
                        LogsDataBase.saveInLoginTable(Connection, employeeDataBaseHandel.UserId, employeeDataBaseHandel.Jop, employeeDataBaseHandel.Shift);
                        this.Visible = false;
                        Casher.Visible = true;
                        EmployeeDataBase.EmployeeIdInSession = LogsDataBase.employeeId;
                        kitchenAndStockReports.createKitchenReport(Connection);




                    }
                    else if ( LogsDataBase.employeeJop.Equals("Staff"))
                    {
                        EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(LogsDataBase.employeeId);
                        LogsDataBase.setEmployeeShift(Connection, LogsDataBase.employeeId);
                        employeeDataBaseHandel.setEmployeeData(Connection, LogsDataBase.username, LogsDataBase.password, LogsDataBase.employeeJop);
                        LogsDataBase.saveInLoginTable(Connection, employeeDataBaseHandel.UserId, employeeDataBaseHandel.Jop, employeeDataBaseHandel.Shift);
                        MessageBox.Show("LOG AT Time" + DateTime.Now +"\n"+ employeeDataBaseHandel.UserName);

                    }
                }
                else
                {
                    MessageBox.Show("UserName Or Password Is Wrong !!", "Error", MessageBoxButtons.OK);
                   
                }
                    
            }
            catch(SqlException exeption)
            {
                MessageBox.Show(exeption.ToString());
            }
          

        }

       
    }
}
