using System;
using System.Data.SqlClient;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //using SqlConnection connection = new SqlConnection();
          var  ConnectionString = "Server = DESKTOP - PAVS32T\\SQLEXPRESS;Database = Aspdotnetb5;User Id = aspdotnetb5;Password = aspdotnetb5";

      
           


            MyORM<DataStore> obj = new MyORM<DataStore>(ConnectionString);

            var obj1 = new DataStore();
            obj1.WorkerName = "sumon";
            obj1.Home = "bogura";

            obj.Insert(obj1);




           








        }
    }
}
