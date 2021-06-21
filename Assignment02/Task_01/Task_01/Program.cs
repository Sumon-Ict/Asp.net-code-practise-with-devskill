using System;
using System.Data.SqlClient;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
      
          using  SqlConnection connection = new SqlConnection();
            connection.ConnectionString= "Server=DESKTOP-PAVS32T\\SQLEXPRESS;Database=Aspdotnetb5;User Id=aspdotnetb5;Password=aspdotnetb5";

            /* var query="insert into Students(StudentName,Home) values('sumon','Bogura')";

             if(connection.State==System.Data.ConnectionState.Closed)
             {
                 connection.Open();

             }

            using SqlCommand command = new SqlCommand();
             command.CommandText = query;
             command.Connection = connection;

             command.ExecuteNonQuery();*/

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }

            MyORM<Students> orm = new MyORM<Students>(connection);

            var obj = new Students();
            obj.StudentName = "sujon";
            obj.Home = "meherpur";

            orm.Insert(obj);




        }
    }
}
