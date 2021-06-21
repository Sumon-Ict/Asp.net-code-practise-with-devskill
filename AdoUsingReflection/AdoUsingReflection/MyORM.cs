using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoUsingReflection
{
   public  class MyORM<T>where T:IData
    {
        private SqlConnection _sqlconnection;
        public MyORM(SqlConnection conncection)
        {
            _sqlconnection = conncection;
        }

        public MyORM(string ConnectionString)
            :this(new SqlConnection(ConnectionString))
        {

        }
        
       /* public void delete(T item)
        {
            delete(item.Id);

        }
       */
        public void insert(T item)
        {
            var sql = new StringBuilder("insert into ");
            var type = item.GetType();
            var properties = type.GetProperties();

            sql.Append(type.Name);
            sql.Append('(');

            foreach(var property in properties)
            {
                sql.Append(' ').Append(property.Name).Append(',');
            }

            sql.Remove(sql.Length - 1, 1);
            sql.Append(")  values (");

            foreach(var property in properties)
            {
                sql.Append('@').Append(property.Name).Append(',');
            }

            sql.Remove(sql.Length - 1, 1);
            sql.Append(");");

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlconnection);

            foreach(var property in properties)
            {
                command.Parameters.Add(property.GetValue(item));

            }
            command.ExecuteNonQuery();

        }


    }
}
