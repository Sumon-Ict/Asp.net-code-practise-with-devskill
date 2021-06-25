using System;
using System.Reflection;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {


            /*  var ob = new Person();
              ob.id = 12;
              ob.name = "sumon";

              var type = typeof(Person);

              Console.WriteLine(type.Name);
              Console.WriteLine(type.FullName);

              var property = type.GetProperty("name");

              var sample = new Person() { name = "sumon", id = 90 };

              var t = sample.GetType();

              Console.WriteLine(t.Name);

              Console.WriteLine("property name");

              var prop = t.GetProperty("name");

              var propertyvalue = prop.GetValue(sample);
              Console.WriteLine(propertyvalue);

              */

            var person = new Person() { code = 12, id = 90, name = "rafik" };

            var type3 = person.GetType();

            var properties3 = type3.GetProperties();

            foreach(var property in properties3)
            {
                Console.WriteLine($"propertytype {property.PropertyType.Name},  name: {property.Name}  ");

            }

            var methods2 = type3.GetMethods();

            foreach(var method in methods2)
            {
                Console.WriteLine($"methodreturntype : {method.ReturnType.Name}, name: {method.Name}");

            }




            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type);

                var properties = type.GetProperties();

                foreach (var property in properties)
                {
                   // Console.WriteLine(property);

                }

                var fields = type.GetFields();

                foreach(var field in fields)
                {
                    Console.WriteLine(field);

                }

                var methods = type.GetMethods();

                Console.WriteLine("methods names");
                Console.WriteLine("");


                foreach(var method in methods)
                {
                    Console.WriteLine(method);

                    var parameters = method.GetParameters();

                    Console.WriteLine("parameters names ");


                    foreach (var param in parameters)
                    {
                        Console.WriteLine(param);

                    }



                }

                var f = type.GetMembers();

                Console.WriteLine("members name");

                foreach(var m in f)
                {
                    Console.WriteLine(m);

                }

            
            }

            
            var personob = new Person() { name = "imran", id = 87 };
            var customerob = new Customer() { Home = "bogura", weight = 89.09, roll = 90 };


            var type2 = customerob.GetType();

            var method2 = type2.GetMethod("myfun");

            method2.Invoke(customerob, null);



            var properties2 = type2.GetProperties();

            foreach(var property in properties2)
            {

                Console.WriteLine(property);

            }
            var pr = type2.GetProperty("Home");

            Console.WriteLine(pr.GetValue(customerob));

            var weightp = type2.GetProperty("roll");

            Console.WriteLine(weightp.GetValue(customerob));
                     

        }
    }
}
