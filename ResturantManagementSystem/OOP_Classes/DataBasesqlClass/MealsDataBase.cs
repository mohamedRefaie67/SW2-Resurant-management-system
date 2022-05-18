using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes.DataBasesqlClass
{
    class MealsDataBase
    {
        private int mealid;
        private string mealname;
        private float mealcost;

        public MealsDataBase(int mealid, string mealname, float mealcost)
        {
            Mealid = mealid;
            Mealname = mealname;
            Mealcost = mealcost;
           
        }//first call 

        public MealsDataBase()
        {
        }

        public void addNewMeal(SqlConnection connection)
        {


            SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into MealMenu values( '" + mealid + "' ,'" + mealname + "' ,'" + mealcost + "')";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void addtoMealCounter(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into MealsCounter values( '" + mealid + "',"+0+")";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
        }
        public void addconsumptions(SqlConnection connection , int mealID , int IngID , float consumption)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into MealFromStock values( '" + mealID + "' ,'" + IngID + "' ,'" + consumption + "')";
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();

        }




        public int Mealid { get => mealid; set => mealid = value; }
        public string Mealname { get => mealname; set => mealname = value; }
        public float Mealcost { get => mealcost; set => mealcost = value; }
    }
}
