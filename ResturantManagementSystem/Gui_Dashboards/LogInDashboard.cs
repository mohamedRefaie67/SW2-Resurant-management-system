using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResturantManagementSystem.OOP_Classes;
using System.Data.SqlClient;


namespace ResturantManagementSystem
{
    public partial class LogInDashboard : Form
    {
        ManagerDashboard Manager = new ManagerDashboard();
        AdminDashboard Admin = new AdminDashboard();
        StockDashboard Stock = new StockDashboard();
        CasherDashboard Casher = new CasherDashboard();
        private SqlConnection conn;
        private int Jop;
        DataBaseConnection Connection = new DataBaseConnection();
        public LogInDashboard()
        {
            InitializeComponent();
          conn = Connection.DbConnection();
            
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

            StaffLogs Staff = new StaffLogs();
            Jop =  Staff.login(conn , UserName.Text,Password.Text);
            if (Jop == 0)
            {
                MessageBox.Show("                            Try Again !!\nNote: UserName or Password is incorrect");
            }
            else if (Jop == 1)
            {
                this.Visible =  false;
                Manager.Visible = true;

            }else if(Jop == 2)
            {
                this.Visible = false;
                Admin.Visible = true;
            }
            else if (Jop == 3)
            {
                this.Visible = false;
                Casher.Visible = true;
            }
            else if (Jop == 4)
            {
                this.Visible = false;
                Stock.Visible = true;
            }
            else if (Jop == 5)
            {
                MessageBox.Show("Done");
            }
 /*---------------------------------------------------------------------*/

            
        }
    }
}
