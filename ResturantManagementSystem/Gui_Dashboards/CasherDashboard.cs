using ResturantManagementSystem.OOP_Classes;
using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using ResturantManagementSystem.OOP_Classes.DataBasesqlClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ResturantManagementSystem
{
    public partial class CasherDashboard : Form
    {

        private Button currentBtn;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        SqlConnection connection = new SqlConnection();
        CasherStockReport casherStockReport = new CasherStockReport();
        public CasherDashboard()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void dashbourdCasher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet1.OrderInvoice' table. You can move, or remove it, as needed.
            this.orderInvoiceTableAdapter1.Fill(this.resturantDataSet1.OrderInvoice);
            // TODO: This line of code loads data into the 'resturant.MealMenu' table. You can move, or remove it, as needed.
            this.mealMenuTableAdapter.Fill(this.resturant.MealMenu);
            // TODO: This line of code loads data into the 'resturant.OrderInvoice' table. You can move, or remove it, as needed.
          
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
            // TODO: This line of code loads data into the 'resturant.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.resturant.Request);
            // TODO: This line of code loads data into the 'resturant.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.resturant.Stock);
            // TODO: This line of code loads data into the 'resturant.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.resturant.Login);
            // TODO: This line of code loads data into the 'resturant.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.resturant.Employee);
            connection = dataBaseConnection.openConnection();

        }

        //here
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
                currentBtn.BackColor = Color.FromArgb(0, 0,0);
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
            StaffPanel.Visible = true;
            StaffPanel.BringToFront();
            Requestpanel.Visible = false;
            Orderspanel.Visible = false;
            ActivateButton(sender, RGBColors.color8);
        }

        private void DashbourdManager_Load(object sender, EventArgs e)
        {
            StaffPanel.Visible = false;
            Requestpanel.Visible = false;
            Orderspanel.Visible = false;
            
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();



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
            KitchenAndStockReports kitchenAndStockReports = new KitchenAndStockReports();

            LogsDataBase.logOut(connection, LogsDataBase.employeeId, 5, LogsDataBase.employeeShift);
            kitchenAndStockReports.createKitchenReport(connection);
            LogInDashboard l = new LogInDashboard();
            TruncateTabels truncateTabels = new TruncateTabels();
            truncateTabels.truncateLogin(connection);
            truncateTabels.truncateLogout(connection);
            if(truncateTabels.IfMonthcompelete(connection, LogsDataBase.employeeShift, LogsDataBase.employeeId))
            {

                truncateTabels.intialMonthLog(connection);

            }



            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffPanel.Visible = false;
            Requestpanel.Visible = true;
            Requestpanel.BringToFront();
            Orderspanel.Visible = false;
            ActivateButton(sender, RGBColors.color3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffPanel.Visible = false;
            Requestpanel.Visible = false;
            Orderspanel.Visible = true;
            Orderspanel.BringToFront();

            ActivateButton(sender, RGBColors.color4);
        }

        private void DashbourdMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StaffPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = this.OrderInvoice.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                
                textBox2.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void Orderspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {  
            casherStockReport.AddToRequest(connection,EmployeeDataBase.EmployeeIdInSession,Convert.ToInt32(textBox7.Text), Convert.ToInt32(Quantity.Text));
            this.requestTableAdapter.Fill(this.resturant.Request);
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = this.StockDataGrid.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                textBox7.Text = Row.Cells[0].Value.ToString();
                textBox8.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TruncateTabels truncateTabels = new TruncateTabels();
            casherStockReport.createRequestReport(connection);
            truncateTabels.truncateRequst(connection);
            this.requestTableAdapter.Fill(this.resturant.Request);
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
        }

        private void OrderReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Staff.Rows[e.RowIndex];
                Employeetxt.Text = row.Cells[0].Value.ToString() ;
                joptitletxt.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                shifttxt.Text = row.Cells[10].Value.ToString();

                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmployeeDataBase employeeDataBaseHandel = new EmployeeDataBase(Convert.ToInt32(Employeetxt.Text));
            LogsDataBase.setEmployeeShift(connection, Convert.ToInt32(Employeetxt.Text));

            employeeDataBaseHandel.setEmployeeData(connection, Convert.ToInt32(Employeetxt.Text));
            LogsDataBase.saveInLoginTable(connection, employeeDataBaseHandel.UserId, employeeDataBaseHandel.Jop, employeeDataBaseHandel.Shift);
            this.loginTableAdapter.Fill(this.resturant.Login);
            

        }

        private void Login_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Login.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogsDataBase.logOut(connection, Convert.ToInt32(textBox4.Text), 4, Convert.ToInt32(textBox1.Text));
            this.loginTableAdapter.Fill(this.resturant.Login);

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Staff.Rows[e.RowIndex];
                textBox10.Text = row.Cells[0].Value.ToString();
                textBox11.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InvoicesAndOrdersReport invoicesAndOrdersReport = new InvoicesAndOrdersReport();
            invoicesAndOrdersReport.addToInvoiceOrder(connection, Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text));
            this.orderInvoiceTableAdapter1.Fill(this.resturantDataSet1.OrderInvoice);

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            InvoicesAndOrdersReport invoicesAndOrdersReport = new InvoicesAndOrdersReport();
            invoicesAndOrdersReport.DeleteFromInvoiceOrder(connection, Convert.ToInt32(textBox2.Text));
            this.orderInvoiceTableAdapter1.Fill(this.resturantDataSet1.OrderInvoice);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TruncateTabels truncateTabels = new TruncateTabels();
            InvoicesAndOrdersReport invoicesAndOrdersReport = new InvoicesAndOrdersReport();
            invoicesAndOrdersReport.createInvoice(connection);
            truncateTabels.truncateOrderInvoice(connection);
            Invoicetxt.Text = invoicesAndOrdersReport.retriveInvoice(connection,EmployeeDataBase.EmployeeIdInSession);
            this.orderInvoiceTableAdapter1.Fill(this.resturantDataSet1.OrderInvoice);

        }

        private void Requestpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
