using System;
using System.Data.SqlClient;

namespace Adonetexample2
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString= "Server=DESKTOP-PAVS32T\\SQLEXPRESS;Database=Aspdotnetb5;User Id=aspdotnetb5;Password=aspdotnetb5";

             //var sql = "insert into Customer (CustomerName,ContactName,PostalCode,Country) values('asik','joypurhat',890,'bangladesh')";
            //var sql = "Update Customer set ContactName='magura',Country='Bangladesh' where CustomerName='asad'";
          
            
            var sql2 = "delete from Customer where PostalCode=890";

            WriteOperation(sql2, connection);

            // WriteOperation(sql, connection);

            // Console.WriteLine("insert operation is success");
            // Console.WriteLine("update operation is success");  

            Console.WriteLine("delete operation is successs");   //both all the operation  work is successfull


        }

        static void WriteOperation(string sql,SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;

            command.Connection = connection;

            command.ExecuteNonQuery();


        }
    }
}
