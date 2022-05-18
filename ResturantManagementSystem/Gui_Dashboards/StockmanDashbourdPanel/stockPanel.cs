using ResturantManagementSystem.OOP_Classes;
using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantManagementSystem.Gui_Dashboards.StockmanDashbourdPanel
{
    public partial class stockPanel : Form
    {
        public stockPanel()
        {
            InitializeComponent();
        }

        private void stockPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturant.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.resturant.Stock);
            // TODO: This line of code loads data into the 'resturant.ServiceProvider' table. You can move, or remove it, as needed.
            this.serviceProviderTableAdapter.Fill(this.resturant.ServiceProvider);

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();

            KitchenAndStockReports kitchenAndStockReports = new KitchenAndStockReports();
            Stock stock = new Stock(Int32.Parse(goodsIdTextBox.Text), goodsNameTextBox.Text, float.Parse(costPerOneTextBox.Text), float.Parse(QuantityTextBox.Text));
            stock.save();
            goodsIdTextBox.Text = "";
            goodsNameTextBox.Text = "";
            costPerOneTextBox.Text = "";
            QuantityTextBox.Text = "";
            kitchenAndStockReports.createstockReport(dataBaseConnection.openConnection());
            MessageBox.Show("Save Data");
            this.stockTableAdapter.Fill(this.resturant.Stock);

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(Int32.Parse(goodsIdTextBox.Text), goodsNameTextBox.Text, float.Parse(costPerOneTextBox.Text), float.Parse(QuantityTextBox.Text));
            stock.update();
            goodsIdTextBox.Text = "";
            goodsNameTextBox.Text = "";
            costPerOneTextBox.Text = "";
            QuantityTextBox.Text = "";
            MessageBox.Show("Data Updated");
            this.stockTableAdapter.Fill(this.resturant.Stock);

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.GoodId = Int32.Parse(goodsIdTextBox.Text);
            stock.delete();
            goodsIdTextBox.Text = "";
            MessageBox.Show("Data Deleted");
            this.stockTableAdapter.Fill(this.resturant.Stock);

        }
    }
}
