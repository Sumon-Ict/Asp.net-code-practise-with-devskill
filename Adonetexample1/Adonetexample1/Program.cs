using System;
using System.Data.SqlClient;

namespace Adonetexample1
{
    class Program
    {
        static void Main(string[] args)
        {

            using SqlConnection conncection = new SqlConnection();

            conncection.ConnectionString = "Server=DESKTOP-PAVS32T\\SQLEXPRESS;Database=Aspdotnetb5;User Id=aspdotnetb5;Password=aspdotnetb5";

            if(conncection.State==System.Data.ConnectionState.Closed)
            {
                conncection.Open();

            }

            var sql = "delete from Customer where PostalCode=234";
            using SqlCommand command2 = new SqlCommand(sql, conncection);
            command2.ExecuteNonQuery();

            Console.WriteLine("delete successfully");
            Console.WriteLine();

            var sql2 = "select * from Customer";
            ReadOperation(sql2, conncection);



            var sql3="insert into Customer(Customername,ContactName,PostalCode,Country)values('rahim','Rangpur',55,'japan')";
            WriteOperation(sql3, conncection);
            Console.WriteLine();

            Console.WriteLine("after insserting the table");
            Console.WriteLine();

            var sql4 = "select * from Customer";
            ReadOperation(sql4, conncection);



            /*
             using SqlCommand command = new SqlCommand("Select * from Customer",conncection);

             using SqlDataReader sqlr = command.ExecuteReader();

             while(sqlr.Read())
             {
                 Console.WriteLine(sqlr["CustomerName"] + "  " +sqlr["ContactName"]+" "+sqlr["PostalCode"]+" "+sqlr["Country"]);


             }

             conncection.Close();
            */

        }

        static  void ReadOperation(string sql,SqlConnection connection)
        {
            
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
            
            using SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader sqlr = command.ExecuteReader();

            while(sqlr.Read())
            {
                Console.WriteLine(sqlr["CustomerName"] + "  " + sqlr["ContactName"] + " " + sqlr["PostalCode"] + " " + sqlr["Country"]);
            }


        }
        static void WriteOperation(string sql,SqlConnection connection)
        {
            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.ExecuteNonQuery();


        }
    }
}
