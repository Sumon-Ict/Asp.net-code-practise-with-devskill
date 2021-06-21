using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
   public class MyORM<T>where T:IData
    {

        private SqlConnection _sqlconnection;

        public MyORM(SqlConnection connection)
        {
            _sqlconnection = connection;

        }

        public MyORM(  string ConnectionString):
            this(new SqlConnection(ConnectionString))
        {


        }

        public void Insert(T item)
        {
            var sql = new StringBuilder("Insert into ");
            var type = item.GetType();
            var properties = type.GetProperties();

            sql.Append(type.Name);
            sql.Append('(');
            foreach (var property in properties)
            {
                sql.Append(' ').Append(property.Name).Append(',');
            }
            sql.Remove(sql.Length - 1, 1);

            sql.Append(") values(");

            foreach (var property in properties)
            {
                sql.Append('@').Append(property.Name).Append(',');
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append(");");

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlconnection);
            foreach (var property in properties)
            {
                command.Parameters.Add(property.GetValue(item));
            }

            command.ExecuteNonQuery();
        }

    }
}
