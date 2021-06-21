using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   public  class MyORM<T>where T:IData
    {
        private SqlConnection _sqlconnection;
      

        public MyORM(SqlConnection connection)
        {
            _sqlconnection = connection;
        }

        public MyORM(string ConnectionString) :
            this(new SqlConnection(ConnectionString))
        {

        }

       
        public void Insert(T t)
        {
            if (this._sqlconnection.State == ConnectionState.Closed)
            {
                this._sqlconnection.Open();
            }
                       
            var type = typeof(T);

             var sql = new StringBuilder("INSERT INTO ");

                  sql.Append(type.Name+"(");

            var  sqlValue = new StringBuilder();
                      
            var  fields = t.GetType().GetProperties();

        var  sqlParameters = new SqlParameter[fields.Length - 1];
                        
            for(int i=1;i<fields.Length;i++)
            {
                if(i==fields.Length-1)
                {
                    sql.Append(fields[i].Name+") VALUES(");
                    sqlValue.Append("@"+fields[i].Name + ")");
                }
                else
                {
                    sql.Append(fields[i].Name + ",");
                    sqlValue.Append("@"+fields[i].Name+ ",");
                }
                sqlParameters[i - 1] = new SqlParameter("@" + fields[i].Name, fields[i].GetValue(t));
                            }
                            sql.Append(sqlValue.ToString());

            var query = sql.ToString();

                SqlCommand sqlCommand = new SqlCommand(query, _sqlconnection);
            
                sqlCommand.Parameters.AddRange(sqlParameters);
           
                this._sqlconnection.Close();
             

        }
        
        public void Update(T item)
        {
            var type = item.GetType();
            var fields = type.GetProperties();

            var sql = new StringBuilder("update ");

            sql.Append($"{type.Name} set");


            var sqlparameters = new SqlParameter[fields.Length];

            for (int i = 1; i < fields.Length; i++)
            {
                if (i == fields.Length - 1)
                {
                    sql.AppendFormat("{0}=@{0} ", fields[i].Name);
                }
                else
                {
                    sql.AppendFormat("{0}=@{0},", fields[i].Name);
                }
                sqlparameters[i - 1] = new SqlParameter("@" + fields[i].Name, fields[i].GetValue(item));
            }
            var query = sql.ToString();

            var Command = new SqlCommand(query, _sqlconnection);

            Command.Parameters.AddRange(sqlparameters);

            

            Command.ExecuteNonQuery();


        }
        private T Select1(DataTable dt)
        {
           
            T t = Activator.CreateInstance<T>();
            var type = typeof(T);
                      
            PropertyInfo[] fields = type.GetProperties();
                        
            DataRow dr = dt.Rows[0];
                        
             int count = dt.Columns.Count;
                        
             foreach (var field in fields)
            {
                for (int i = 0; i < count; i++)
                {
                    if (field.Name.ToUpper() == dt.Columns[i].ColumnName.ToUpper())
                    {
                        field.SetValue(t, dr[i], null);
                        break;
                    }
                }
            }
            return t;
        }
        public T GetById(int id)
        {
            var type = typeof(T);

            var sql = new StringBuilder("select * from ");
            sql.Append(type.Name);
            sql.Append(" where id=");
            sql.Append(id);

            var query = sql.ToString();
           
            var command= new SqlCommand(query, _sqlconnection);

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(ds);

            T t = Select1(ds.Tables[0]);
           
            return t;
        }

        private List<T> Select2(DataTable dt)
        {
            List<T> arrList = new List<T>();
                       
            var properties = typeof(T).GetProperties();
                         
            int columnCount = dt.Columns.Count;
                        
            int rowCount = dt.Rows.Count;
                        
            for (int i = 0; i < rowCount; i++)
            {
                T t = Activator.CreateInstance<T>();
                for (int j = 0; j < columnCount; j++)
                {
                    foreach (var property in properties)
                    {
                        if (property.Name.ToUpper() == dt.Columns[j].ColumnName.ToUpper())
                        {
                            property.SetValue(t, dt.Rows[i][j], null);
                            break;
                        }
                    }
                }
                arrList.Add(t);
            }
            return arrList;
        }

        public List<T>GetAll()
        {
            
            var type = typeof(T);
            
            string query = "SELECT * FROM " + type.Name;

            var command = new SqlCommand(query,_sqlconnection);

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            List<T> arrList = Select2(dt);
           
            return arrList;
        }

        public void Delete(T item)
        {
            var type = item.GetType();

            var sql = new StringBuilder("delete from ");

            sql.Append(type.Name);

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlconnection);
            command.ExecuteNonQuery();



        }

       public void Delete(int id)
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


    }
}
