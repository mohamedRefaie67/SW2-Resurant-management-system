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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantManagementSystem.Gui_Dashboards.StockmanDashbourdPanel
{
    public partial class requestPanel : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        SqlConnection connection = new SqlConnection();
        CasherStockReport casherStockReport = new CasherStockReport();
        public requestPanel()
        {
            InitializeComponent();
        }

        private void requestPanel_Load(object sender, EventArgs e)
        {
            connection = dataBaseConnection.openConnection();
            // TODO: This line of code loads data into the 'resturant.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.resturant.Request);
            // TODO: This line of code loads data into the 'resturant.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.resturant.Stock);
            // TODO: This line of code loads data into the 'resturant.CasherStockReports' table. You can move, or remove it, as needed.
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

            casherStockReport.AddToRequest(connection, EmployeeDataBase.EmployeeIdInSession, Convert.ToInt32(textBox7.Text), Convert.ToInt32(Quantity.Text));
            this.requestTableAdapter.Fill(this.resturant.Request);
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TruncateTabels truncateTabels = new TruncateTabels();
            casherStockReport.createRequestReport(connection);
            truncateTabels.truncateRequst(connection);
            this.requestTableAdapter.Fill(this.resturant.Request);
            this.casherStockReportsTableAdapter.Fill(this.resturant.CasherStockReports);
        }

        private void StockDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.StockDataGrid.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {

                textBox7.Text = row.Cells[0].Value.ToString();
                textBox8.Text = row.Cells[1].Value.ToString();
            }
        }

        private void report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.report.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {

               
                textBox1.Text = row.Cells[1].Value.ToString();
            }

        }
    }
}
