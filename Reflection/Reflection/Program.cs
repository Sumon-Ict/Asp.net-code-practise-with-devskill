using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            var type = typeof(Person);
            Console.WriteLine(type.Name);

            Console.WriteLine("fields names");
            var fields = type.GetFields();

            foreach(var field in fields)
            {
                Console.WriteLine(field);

            }

            var constructors = type.GetConstructors();

            Console.WriteLine("constructors");

           foreach(var c in constructors)
            {
                Console.WriteLine(c);

            }
            var methods = type.GetMethods();

            foreach(var m in methods)
            {
                Console.WriteLine(m);

            }

            Console.WriteLine("assembly");

            var r2 = type.Assembly;
            Console.WriteLine(r2);




            Console.WriteLine("properties");

            var properties = type.GetProperties();

            foreach(var property in properties)
            {
                Console.WriteLine(property);

            }


            
            Console.WriteLine("Hello World!");
            IList r = info();
            for(int i=0;i<r.Count;i++)
            {
                Console.WriteLine(r[i]);

            }

            IList<Dictionary<string, object>> res = keyValues();

            for(int i=0;i<res.Count;i++)
            {
                foreach(KeyValuePair<string,object>kv in res[i])
                {
                    
                    Console.WriteLine($"key: {kv.Key}  value:{kv.Value}");

                }

            }

            /*IList<Dictionary<int, string>> std = StudentInfo();

            for(int i=0;i<std.Count;i++)
            {

                foreach (KeyValuePair<int, string> kvp in std[i]) 
                {
                    Console.WriteLine($"key: {kvp.Key} value:{kvp.Value}");

                }
            }*/

        }

        static IList info()

        {

            string[] arr = { "sumon", "sujn" };

            List<string>list = new List<string>();

            for(int i=0;i<arr.Length;i++)
            {
                list.Add(arr[i]);
            }

            return list;

        }
        static IList<Dictionary<string,object>> keyValues()
        {


            string[] names = { "sumon", "sujon", "suvo", "kajol" };
            object[] roll = { 12, 34, 56, 78, 7 };



            var  list = new List<Dictionary<string, object>>();



            for(int i=0;i<4;i++ )
            {
                Dictionary<string, object> d = new Dictionary<string, object>();
               
                
                    d.Add(names[i], roll[i]);
             
                list.Add(d);

            }
            return list;
        }

     /*   static IList<Dictionary<int,string>> StudentInfo()
        {
            var list = new List<Dictionary<int, string>>();
            Console.WriteLine("inter the  5 student names");

            for(int i=0;i<5;i++)
            {
                var dic = new Dictionary<int, string>();

                dic.Add(i + 1, Console.ReadLine());

                list.Add(dic);

            }
            return list;
           
        }*/
    }
}
