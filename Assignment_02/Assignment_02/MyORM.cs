using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
   public class MyORM<T>where T:IData
    {

        private SqlConnection _sqlconnection;
        public MyORM(SqlConnection connection)
        {
            _sqlconnection = connection;
        }

      
        public MyORM(string ConnectionString):
            this(new SqlConnection(ConnectionString))
        {

        }


        public void Insert(T item)
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
            sql.Append(") values(");


            foreach(var property in properties)
            {
                sql.Append('@').Append(property.Name).Append(',');
            }

            sql.Remove(sql.Length - 1, 1);
            sql.Append(");");

            var query = sql.ToString();

            using SqlCommand command = new SqlCommand(query, _sqlconnection);

            command.ExecuteNonQuery();

            /*foreach(var property in properties)
            {
                command.Parameters.Add(property.GetValue(item));

            }*/

            //command.ExecuteNonQuery();


        }
        public void Delete(T item)
        {
            var sql = new StringBuilder("delete from ");
            var type = item.GetType();

            sql.Append(type.Name);
            var properties = type.GetProperties();
            sql.Append(" where ");

            sql.Append(properties[0].Name);
            sql.Append('=');
            sql.Append(properties[0].GetValue(item));

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlconnection);

            command.ExecuteNonQuery();



        }
        public void Update(T item)
        {

            int ctr = 0;
            var type = item.GetType();

            var properties = type.GetProperties();

            var sql = new StringBuilder();

            foreach(var property in properties )
            {
                if(sql.ToString()==string.Empty)
                {
                    sql.AppendFormat("update {0} set {1}={2}", type.Name, property.Name, "[" + ctr + "]");

                }
                else
                {
                    sql.AppendFormat(" , {0}={1}", property.Name, "[" + ctr + "]");
                }
                ctr++;
            }
            if(sql.ToString()!=string.Empty)
            {
                sql.AppendFormat("  where {0}= {1} ", properties[0].Name, "[" + ctr + "]");

            }
            sql.Replace('[', '{').Replace(']', '}');

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlconnection);

            command.ExecuteNonQuery();


        }

        public void GetAll()
        {


            var type = typeof(T);
            var properties = type.GetProperties();
            var sql = new StringBuilder();

            foreach(var property in properties)
            {
                if(sql.ToString()==string.Empty)
                {
                    sql.AppendFormat("select {0} ", property.Name);
                }
                else
                {
                    sql.AppendFormat(", {0}", property.Name);
                }
            }
            if(sql.ToString()!=string.Empty)
            {
                sql.AppendFormat(" from {0} ", type.Name);

            }

            var query = sql.ToString();

            using SqlCommand command = new SqlCommand(query, _sqlconnection);
            command.ExecuteNonQuery();

        }

     public void   Delete(int id)
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            var sql = new StringBuilder("delete from ");

            sql.Append(type.Name);
            sql.Append(" where ");
            sql.Append(properties[0].Name);
            sql.Append('=');
            sql.Append(id);

            var query = sql.ToString();
            var command = new SqlCommand(query, _sqlconnection);

            command.ExecuteNonQuery();


        }
        public void GetById(int id)
        {
            var sql = new StringBuilder();
            var type = typeof(T);
            var properties = type.GetProperties();
           
                foreach (var property in properties)
                {
                    if (sql.ToString() == string.Empty)
                    {
                        sql.AppendFormat("select {0} ", property.Name);
                    }
                    else
                    {
                        sql.AppendFormat(", {0}", property.Name);
                    }
                }
                if (sql.ToString() != string.Empty)
                {
                    sql.AppendFormat(" from {0} ", type.Name);

                }
            sql.AppendFormat($"where {properties[0].Name}={id}");

            var query = sql.ToString();

            using var command= new SqlCommand(query, _sqlconnection);

            command.ExecuteNonQuery();





        }

    }
}
