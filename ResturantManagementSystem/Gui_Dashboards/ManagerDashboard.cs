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
using ResturantManagementSystem.OOP_Classes;

namespace ResturantManagementSystem
{
    public partial class ManagerDashboard : Form
    {
        private Button currentBtn;

        public ManagerDashboard()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            // TODO: This line of code loads data into the 'resturantDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.resturantDataSet.Users);
            StaffPAnael.Visible= false;
            Reportpanel.Visible = false;
            panel2.Visible = false;
            supplypanel.Visible = false;
            foodmenupanel.Visible = false;
            pictureBox1.Visible = true;
           
           

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
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.BackColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color.;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                //Current Child Form Icon
                // iconCurrentChildForm.IconChar = currentBtn.IconChar;
                // iconCurrentChildForm.IconColor = color;
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
            // TODO: This line of code loads data into the 'resturantDataSet2.ServiceProvider' table. You can move, or remove it, as needed.
            this.serviceProviderTableAdapter.Fill(this.resturantDataSet2.ServiceProvider);
            // TODO: This line of code loads data into the 'resturantDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.resturantDataSet2.Users);
            // TODO: This line of code loads data into the 'resturantDataSet2.SendMail' table. You can move, or remove it, as needed.
            this.sendMailTableAdapter.Fill(this.resturantDataSet2.SendMail);
            // TODO: This line of code loads data into the 'resturantDataSet2.ReciveMail' table. You can move, or remove it, as needed.
            this.reciveMailTableAdapter.Fill(this.resturantDataSet2.ReciveMail);
            // TODO: This line of code loads data into the 'resturantDataSet1.StaffAdmin' table. You can move, or remove it, as needed.
            this.staffAdminTableAdapter.Fill(this.resturantDataSet1.StaffAdmin);





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
            // Application.Exit();
           // Hide();
            LogInDashboard l = new LogInDashboard();
            //l.Show();
            //Application.Run(new FormLogIn());

            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            panel2.Visible = false;
            Reportpanel.Visible = true;
            Reportpanel.BringToFront();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panel2.Visible = true;
            panel2.BringToFront();
        
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void StaffPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STAFFTABLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*------------------------------------------------------------------*/
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.STAFFTABLE.Rows[e.RowIndex];

                UserId.Text = row.Cells[0].Value.ToString();
                FirstName.Text = row.Cells[1].Value.ToString();
                LastName.Text = row.Cells[2].Value.ToString();
                PhoneNumber.Text = row.Cells[3].Value.ToString();
                NAtioNumber.Text = row.Cells[4].Value.ToString();
                Address.Text = row.Cells[5].Value.ToString();
                Gender.Text = row.Cells[6].Value.ToString();
                Education.Text = row.Cells[7].Value.ToString();
                Email.Text = row.Cells[8].Value.ToString();
                Jop.Text = row.Cells[9].Value.ToString();
                Salary.Text = row.Cells[10].Value.ToString();
                Shift.Text = row.Cells[11].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ADDuser_Click(object sender, EventArgs e)
        {
            ADDuser.BackColor = Color.Red;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
