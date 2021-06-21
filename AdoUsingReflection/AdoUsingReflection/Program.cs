using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdoUsingReflection
{
    class Program
    {

        private const string  ConnectionString="Server=DESKTOP-PAVS32T\\SQLEXPRESS;Database=Aspdotnetb5;User Id = aspdotnetb5; Password=aspdotnetb5";
        private static SqlConnection connection;

        static void Main(string[] args)
        {
            connection = new SqlConnection(ConnectionString);

            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }

            var sql= "insert into Customer (CustomerName,ContactName,PostalCode,Country) values('asik','joypurhat',890,'bangladesh')";

            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.ExecuteNonQuery();

            var datavalue = Read("Customer");

            foreach(var row in datavalue)
            {
                foreach(var col in row)
                {
                    Console.WriteLine($"{col.Key}  ={col.Value}");

                }
                Console.WriteLine(new string('=', 8));

            }

           

        }

       public static IList<IDictionary<string, object>> Read(string tablename)
        {
            var result = new List<IDictionary<string, object>>();
            var query = "select * from " + tablename;

            try
            {
                if(connection.State==System.Data.ConnectionState.Closed)
                {
                    connection.Open();

                }

                using  SqlCommand command = new SqlCommand(query, connection);

                using var reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var row = new Dictionary<string, object>();

                    for(var i=0;i<reader.FieldCount;i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));

                    }
                    result.Add(row);
                }
                
            }

            catch(SqlException e)
            {
                Console.WriteLine("something is wrong " + e.Message);

            }
            catch(Exception E)
            {
                Console.WriteLine("ther is exception error" + E.Message);

            }
            finally
               {
                connection?.Close();


            }
            return result;           

        }
        public static void WriteOperation(string sql)
        {
            try
            {

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();

                }

                using SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch(SqlException se)
            {
                Console.WriteLine("sqlexception error" + se.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine("exception error" + e.Message);

            }
            finally
            {
                connection?.Close();

            }


        }
    }
}
