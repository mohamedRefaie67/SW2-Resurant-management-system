using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBaseHandel
{
    class EmployeeDataBase
    {
        public static int EmployeeIdInSession ;
        private  int userId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string nationalNumber;
        private string address;
        private string gender ;
        private string education;
        private string email;
        private float salaryPerHour;
        private int shift;
        private string userName;
        private string password;
        private string jop;
        private string monthlogintialhour = "-1";

        public EmployeeDataBase()
        {

        }

        public EmployeeDataBase(int euserId, string efirstName, string elastName, string ephoneNumber, string enationalNumber, string eaddress, string egender, string eeducation, string eemail, float esalaryPerHour, int eshift, string euserName, string epassword, string ejop)
        {
          
            UserId = euserId;
            FirstName = efirstName;
            LastName = elastName;
            PhoneNumber = ephoneNumber;
            NationalNumber = enationalNumber;
            Address = eaddress;
            Gender = egender;
            Education = eeducation;
            Email = eemail;
            SalaryPerHour = esalaryPerHour;
            Shift = eshift;
            UserName = euserName;
            Password = epassword;
            Jop = ejop;
        }

        public EmployeeDataBase(int userId)
        {
            this.userId = userId;
        }

        public void setEmployeeData(SqlConnection connection  , string username , string Password , string jop)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT * from Employee Where  UserId = '" + this.UserId+ "'";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader employeeReader = sqlCommand.ExecuteReader();
            if (employeeReader.HasRows)
            {
                while (employeeReader.Read())
                {
                    this.userId = employeeReader.GetInt32(0);
                    this.firstName = employeeReader.GetString(1);
                    this.lastName = employeeReader.GetString(2);
                    this.phoneNumber = employeeReader.GetString(3);
                    this.nationalNumber = employeeReader.GetString(4);
                    this.address = employeeReader.GetString(5);
                    this.gender = employeeReader.GetString(6);
                    this.education = employeeReader.GetString(7);
                    this.email = employeeReader.GetString(8);
                    this.salaryPerHour = (float) employeeReader.GetDouble(9);
                    this.shift = employeeReader.GetInt32(10);
                    this.userName = username;
                    this.password = Password;
                    this.jop = jop;
                }
                employeeReader.Close();
            }
            employeeReader.Close();
        }

        public  void setEmployeeData(SqlConnection connection,int userID)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = " SELECT * from Employee Where  UserId = '" + userID + "'";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            SqlDataReader employeeReader = sqlCommand.ExecuteReader();
            if (employeeReader.HasRows)
            {
                while (employeeReader.Read())
                {
                    this.userId = employeeReader.GetInt32(0);
                    this.firstName = employeeReader.GetString(1);
                    this.lastName = employeeReader.GetString(2);
                    this.phoneNumber = employeeReader.GetString(3);
                    this.nationalNumber = employeeReader.GetString(4);
                    this.address = employeeReader.GetString(5);
                    this.gender = employeeReader.GetString(6);
                    this.education = employeeReader.GetString(7);
                    this.email = employeeReader.GetString(8);
                    this.salaryPerHour = (float)employeeReader.GetDouble(9);
                    this.shift = employeeReader.GetInt32(10);
                   
                }
                employeeReader.Close();
            }
            query = " SELECT * from Accounts Where  UserId = '" + userID + "'";

            sqlCommand.CommandText = query;
            employeeReader = sqlCommand.ExecuteReader();
            if (employeeReader.HasRows)
            {
                while (employeeReader.Read())
                {
                    this.userName = employeeReader.GetString(1);
                    this.password = employeeReader.GetString(2);
                    this.jop = employeeReader.GetString(3);

                }
                employeeReader.Close();
            }
           
        }


        public void addEmployee(SqlConnection connection)
        {
        
  
        SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into Employee values( '" + userId + "' ,'" + firstName + "' ,'" + lastName + "' ,'" + phoneNumber + "' ,'" + nationalNumber + "' ,'" + address + "' ,'" + gender + "','" + education + "' ,'" + email + "' ,'" + salaryPerHour + "' ,'" + shift + "' )";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery(); 
        }
        public void addEmployeeAccount(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into Accounts values('" + userId + "','" + userName + "','" + password + "','" + jop + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void addEmployeeInMonthlog(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "insert into MonthLog values('" + userId + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "'," +
                "'" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "'," +
                "'" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "'," +
                "'" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "'," +
                "'" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "'," +
                "'" + monthlogintialhour + "','" + monthlogintialhour + "','" + monthlogintialhour + "' )";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        /*----------------------------------------------------------------------------------------------------------------*/
        public void updateEmployee(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = "update Employee set  UserId='" + userId + "' ,FirstName='" + firstName + "' ,LastName='" + lastName + "' ,PhoneNumber='" + phoneNumber + "' ,NationalNumber='" + nationalNumber + "' ,Address='" + address + "' ,Gender='" + gender + "' ,Education='" + education + "' ,Email='" + email + "' ,SalaryPerHour='" + salaryPerHour + "' ,Shift='" + shift + "' Where UserId = '" + userId + "' ";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void updateEmployeeAccount(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "update Accounts set UserId= '" + userId + "',UserName='" + userName + "',Password='" + password + "',Jop='" + jop + "' Where UserId = '"+ userId + "'";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        /*--------------------------------------------------------------------------------------------------------------*/
        public void deleteEmployee(SqlConnection connection)
        {


            SqlCommand sqlCommand = new SqlCommand();
            string query = "delete from Employee Where UserId ='"+userId+"'";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void deleteEmployeeAccount(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query ="delete from Accounts Where UserId ='" + userId + "'";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void deleteEmployeeInMonthlog(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            string query = "delete from MonthLog Where UserId ='" + userId + "'";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }


        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string NationalNumber { get => nationalNumber; set => nationalNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Education { get => education; set => education = value; }
        public string Email { get => email; set => email = value; }
        public float SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
        public int Shift { get => shift; set => shift = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Jop { get => jop; set => jop = value; }
    }
}
