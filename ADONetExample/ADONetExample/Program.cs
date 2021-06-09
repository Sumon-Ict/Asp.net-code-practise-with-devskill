using System;
using System.Data.SqlClient;

namespace ADONetExample
{
    class Program
    {
        static void Main(string[] args)
        {
          using   SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PAVS32T\\SQLEXPRESS;Database=Aspdotnetb5;User Id=aspdotnetb5;Password=aspdotnetb5";
             
           
            var sql = "insert into Customer (CustomerName,ContactName,PostalCode,Country) values('asad','meherpur',234,'india')";
           
            WriteOperation(sql, connection);

            Console.WriteLine("insert success");



        }
        static void WriteOperation(string sql,SqlConnection connection)
        {
            if(connection.State==System.Data.ConnectionState.Closed)
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
