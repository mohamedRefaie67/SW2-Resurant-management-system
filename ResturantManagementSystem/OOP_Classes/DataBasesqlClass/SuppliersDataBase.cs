using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class SuppliersDataBase 
    {
        private int coid;
        private string coname;
        private string coemail;
        private string cophone;
        private string coaddress;

        public SuppliersDataBase(int coid, string coname, string coemail, string cophone, string coaddress)
        {
            this.Coid = coid;
            this.Coname = coname;
            this.Coemail = coemail;
            this.Cophone = cophone;
            this.Coaddress = coaddress;
        }

        public SuppliersDataBase()
        {
        }

        public void addSupplier(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into ServiceProvider values( " + coid + " ,'" + coname + "' ,'" + coemail + "','" + cophone + "','" + coaddress + "')";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();

        }

        public int Coid { get => coid; set => coid = value; }
        public string Coname { get => coname; set => coname = value; }
        public string Coemail { get => coemail; set => coemail = value; }
        public string Cophone { get => cophone; set => cophone = value; }
        public string Coaddress { get => coaddress; set => coaddress = value; }
    }
}
