using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using ResturantManagementSystem.OOP_Classes;
using ResturantManagementSystem.OOP_Classes.DataBasesqlClass;

namespace ResturantManagementSystem
{
    public partial class ManagerDashboard : Form
    {
        private Button currentBtn;
        LogsDataBase logDataBaseHandel = new LogsDataBase();
        SqlConnection connection = new SqlConnection();
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        int DashboardType = 1;

        public ManagerDashboard()
        {
            InitializeComponent();
            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            StaffPAnael.Visible = false;
            Reportpanel.Visible = false;
          
            supplypanel.Visible = false;
            foodmenupanel.Visible = false;
            pictureBox1.Visible = true;
            UPDATEUSERPANEL.Visible = false;
            ADDUSERPANEL.Visible = false;
        }

        //private  

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.BackColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; 
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //end

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(133, 133, 133);
            public static Color color8 = Color.FromArgb(0, 0, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            StaffPAnael.Visible = true;
            StaffPAnael.BringToFront();

        }

        private void DashbourdManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturant.MealFromStock' table. You can move, or remove it, as needed.
            this.mealFromStockTableAdapter.Fill(this.resturant.MealFromStock);
            connection = dataBaseConnection.openConnection();
            // TODO: This line of code loads data into the 'resturantDataSet.OrderReports' table. You can move, or remove it, as needed.
            this.orderReportsTableAdapter1.Fill(this.resturantDataSet.OrderReports);
            // TODO: This line of code loads data into the 'resturant.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.resturant.Stock);
            // TODO: This line of code loads data into the 'resturant.MealMenu' table. You can move, or remove it, as needed.
            this.mealMenuTableAdapter.Fill(this.resturant.MealMenu);
            // TODO: This line of code loads data into the 'resturant.MonthStaffReport' table. You can move, or remove it, as needed.
            this.monthStaffReportTableAdapter.Fill(this.resturant.MonthStaffReport);
            // TODO: This line of code loads data into the 'resturant.MonthLog' table. You can move, or remove it, as needed.
            this.monthLogTableAdapter.Fill(this.resturant.MonthLog);
            // TODO: This line of code loads data into the 'resturant.OrderReports' table. You can move, or remove it, as needed.
            this.kitchenReportTableAdapter.Fill(this.resturant.KitchenReport);
            // TODO: This line of code loads data into the 'resturant.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.resturant.Invoices);
            // TODO: This line of code loads data into the 'resturant.StockReport' table. You can move, or remove it, as needed.
            this.stockReportTableAdapter.Fill(this.resturant.StockReport);
            // TODO: This line of code loads data into the 'resturant.ShiftStaffReports' table. You can move, or remove it, as needed.
            this.shiftStaffReportsTableAdapter.Fill(this.resturant.ShiftStaffReports);
            // TODO: This line of code loads data into the 'resturant.CasherStockReports' table. You can move, or remove it, as needed.
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
            // TODO: This line of code loads data into the 'resturant.ServiceProvider' table. You can move, or remove it, as needed.
            this.serviceProviderTableAdapter.Fill(this.resturant.ServiceProvider);
            // TODO: This line of code loads data into the 'resturant.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.resturant.Accounts);
            // TODO: This line of code loads data into the 'resturant.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.resturant.Employee);           
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            LogsDataBase.logOut(connection, LogsDataBase.employeeId,DashboardType, LogsDataBase.employeeShift);
           
            LogInDashboard l = new LogInDashboard();

            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
           
            Reportpanel.Visible = true;
            Reportpanel.BringToFront();

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

            foodmenupanel.Visible = true;
            foodmenupanel.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            supplypanel.Visible = true;
            supplypanel.BringToFront();
        }


        private void ADDuser_Click(object sender, EventArgs e)
        {
            ADDuser.BackColor = Color.Red;
        }

     


        private void StaffTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StaffTable.Rows[e.RowIndex];
                DataGridViewRow row1 = this.AccountsTAble.Rows[e.RowIndex];
                UserNameUpdate.Text = row1.Cells[0].Value.ToString();
                PAsswordUpdate.Text = row1.Cells[1].Value.ToString();
                Jop.Text = row1.Cells[2].Value.ToString();
                UserId.Text = row.Cells[0].Value.ToString();
                FirstName.Text = row.Cells[1].Value.ToString();
                LastName.Text = row.Cells[2].Value.ToString();
                PhoneNumber.Text = row.Cells[3].Value.ToString();
                NAtioNumber.Text = row.Cells[4].Value.ToString();
                Address.Text = row.Cells[5].Value.ToString();
                Gender.Text = row.Cells[6].Value.ToString();
                Education.Text = row.Cells[7].Value.ToString();
                Email.Text = row.Cells[8].Value.ToString();              
                Salary.Text = row.Cells[9].Value.ToString();
                Shift.Text = row.Cells[10].Value.ToString();
            }
         
          
               

        }
/*------------------------------------------------------------------------------------------------------*/
        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void StaffPAnael_Paint(object sender, PaintEventArgs e)
        {

        }
/*-------------------------------------------------------------------------------------------------------*/

        private void button7_Click(object sender, EventArgs e)
        {
            ADDUSERPANEL.Visible = true;
            ADDUSERPANEL.BringToFront();
        }

        private void UPDATEUSERPANELBUTTON_Click(object sender, EventArgs e)
        {
            ADDUSERPANEL.Visible = false;
            UPDATEUSERPANEL.Visible = true;
            ADDUSERPANEL.BringToFront();
        }

        private void ADDuser_Click_3(object sender, EventArgs e)
        {
            try {
                EmployeeDataBase employeeDataBaseHandel = new  EmployeeDataBase(Int32.Parse(ADDuserid.Text), ADDfNAme.Text, ADDlName.Text, ADDNumberPhone.Text, ADDnatinumber.Text, ADDaddress.Text, ADDGender.Text, ADDeducation.Text, AddEmail.Text, float.Parse( ADDsalary.Text), Int32.Parse(ADDShift.Text), ADDusername.Text, ADDpassword.Text,ADDjop.Text);
                employeeDataBaseHandel.addEmployee(connection);
                employeeDataBaseHandel.addEmployeeAccount(connection);
                employeeDataBaseHandel.addEmployeeAccount(connection);

                this.accountsTableAdapter.Fill(this.resturant.Accounts);
                this.employeeTableAdapter.Fill(this.resturant.Employee);
                MessageBox.Show("ADDED Successfully","Done!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(" Failed\n" +
                    "Fill All Statements", "Error!!");
            }



        }

        private void DeleteUser_Click_1(object sender, EventArgs e)
        {

            try
            {

                EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(Int32.Parse(UserId.Text), FirstName.Text, LastName.Text, PhoneNumber.Text, NAtioNumber.Text,
                Address.Text, Gender.Text, Education.Text, Email.Text, float.Parse(Salary.Text), Int32.Parse(Shift.Text), UserNameUpdate.Text, PAsswordUpdate.Text, Jop.Text);
                employeeDataBaseHandel.deleteEmployeeInMonthlog(connection);
                employeeDataBaseHandel.deleteEmployeeAccount(connection);
                employeeDataBaseHandel.deleteEmployee(connection);

                this.accountsTableAdapter.Fill(this.resturant.Accounts);
                this.employeeTableAdapter.Fill(this.resturant.Employee);
                MessageBox.Show("Deleted Successfully ^-^");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Updateuser_Click_1(object sender, EventArgs e)
        {


            try
            {
                EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(Int32.Parse(UserId.Text), FirstName.Text, LastName.Text, PhoneNumber.Text, NAtioNumber.Text, 
                Address.Text, Gender.Text, Education.Text, Email.Text, float.Parse(Salary.Text), Int32.Parse(Shift.Text), UserNameUpdate.Text, PAsswordUpdate.Text, Jop.Text);
                employeeDataBaseHandel.updateEmployee(connection);
                employeeDataBaseHandel.updateEmployeeAccount(connection);

                this.accountsTableAdapter.Fill(this.resturant.Accounts);
                this.employeeTableAdapter.Fill(this.resturant.Employee);

                MessageBox.Show("Updated Successfully ^-^");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CasherReport.Visible = true;
            CasherReport.BringToFront();
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;

        }

        private void InvoicesReportBt_Click(object sender, EventArgs e)
        {
            CasherReport.Visible = false;
            InvoicesReport.Visible = true;
            InvoicesReport.BringToFront();
            OrderReports.Visible = false;
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;

        }

        private void KitchenReportBt_Click(object sender, EventArgs e)
        {
            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            KitchenReports.Visible = true;
            KitchenReports.BringToFront();
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;
        }

        private void StockReportBt_Click(object sender, EventArgs e)
        {
            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            KitchenReports.Visible = false;
            Stockreports.Visible = true;
            Stockreports.BringToFront();
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;
        }

        private void ShiftReportBt_Click(object sender, EventArgs e)
        {
            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = true;
            ShiftReports.BringToFront();
            MonthStaffreport.Visible = false;
        }

        private void OrderReportsBt_Click(object sender, EventArgs e)
        {
            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = true;
            OrderReports.BringToFront();
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
            MonthStaffreport.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            CasherReport.Visible = false;
            InvoicesReport.Visible = false;
            OrderReports.Visible = false;
            MonthStaffreport.Visible = true;
            MonthStaffreport.BringToFront();
            KitchenReports.Visible = false;
            Stockreports.Visible = false;
            ShiftReports.Visible = false;
        }

        private void OrderReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.OrderReports.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }

        }

        private void KitchenReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.KitchenReports.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void InvoicesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.InvoicesReport.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void Stockreports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.Stockreports.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void ShiftReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.ShiftReports.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void CasherReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.CasherReport.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void MonthStaffreport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.MonthStaffreport.Rows[e.RowIndex];
                ReportView.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Addmealpanel.Visible = false;
           
           
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Addmealpanel.Visible = true;
            Addmealpanel.BringToFront();
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AddConsumptionpanel.Visible = true;
            AddConsumptionpanel.BringToFront();
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {  
            AddConsumptionpanel.Visible = false;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void Reportpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Addsuplypanel.Visible = true;
            Addsuplypanel.BringToFront();
           
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.mealsTable.Rows[e.RowIndex];
                

                mealid.Text = row.Cells[0].Value.ToString();
             

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.mealsTable.Rows[e.RowIndex];
                DataGridViewRow row1 = this.ingredients.Rows[e.RowIndex];
              
                textBox4.Text = row1.Cells[0].Value.ToString();
                textBox5.Text = row1.Cells[1].Value.ToString();
                
            }



        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MealsDataBase mealsDataBase = new MealsDataBase(Convert.ToInt32(textBox13.Text.ToString()) , textBox14.Text.ToString(), (float)Convert.ToDouble(textBox15.Text.ToString()));
            mealsDataBase.addNewMeal(connection);
            mealsDataBase.addtoMealCounter(connection);
            this.mealMenuTableAdapter.Fill(this.resturant.MealMenu);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MealsDataBase mealsDataBase = new MealsDataBase();

            mealsDataBase.addconsumptions(connection, Convert.ToInt32(mealid.Text.ToString()), Convert.ToInt32(textBox4.Text.ToString()), (float)Convert.ToDouble(consumption.Text.ToString()));
            this.mealFromStockTableAdapter.Fill(this.resturant.MealFromStock);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            SuppliersDataBase suppliersDataBase = new SuppliersDataBase(Convert.ToInt32(textBox16.Text.ToString()), textBox24.Text.ToString(), textBox23.Text.ToString(), textBox18.Text.ToString(), textBox17.Text.ToString());
            suppliersDataBase.addSupplier(connection);
           
            this.serviceProviderTableAdapter.Fill(this.resturant.ServiceProvider);

        }

        private void supplypanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
