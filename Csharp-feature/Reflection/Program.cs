using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.IO;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"H:\Asp.net code\Csharp-feature\Reflection\config.txt";

            var configtext = File.ReadAllText(path);

            var initclass = configtext.Split('=')[1].Trim();

            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in types)
            {
                   if(type.Name==initclass)
                {
                    //var constructor = type.GetConstructor(new Type[0]);
                    //var initializerinstance = constructor.Invoke(new object[0]);

                    // empty constructor calling 

                    var constructor = type.GetConstructor(new Type[] { typeof(int) });

                    var initializerinstance = constructor.Invoke(new object[] { 5 });

                    //parameterized constructor calling 


                   // MethodInfo method = type.GetMethod("InitStartup");

                    MethodInfo method = type.GetMethod("printmethod");

                    method.Invoke(initializerinstance, new object[0]);


                }
            }





            /*

            #region get different properties
            

            var text = "sumon=sujon";

            var text2 = text.Split('=')[0];

            Console.WriteLine(text2);




            int n = 12;
            Type type = n.GetType();

            Console.WriteLine(type);


            Type t2 = typeof(System.String);

            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Assembly);
            Console.WriteLine(t2.Attributes);

            Type t = typeof(Student);

            foreach(var property in t.GetProperties())
            {
                Console.WriteLine(property.Name);

            }

           foreach(var constructor in t.GetConstructors())
            {
                Console.WriteLine(constructor.Name);

            }

           foreach(var field in t.GetFields())
            {
                Console.WriteLine(field.Name);

            }
           foreach(var f in t.GetMethods())
            {
                Console.WriteLine(f.Name);

            }


            Type c = typeof(System.String);

            ConstructorInfo[] ci = c.GetConstructors(BindingFlags.Public|BindingFlags.Instance);

            foreach(var i in ci)
            {
                Console.WriteLine(i);
            }

            MethodInfo[] mi = c.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach(var m in mi)
            {
                Console.WriteLine(m);

            }

            Console.WriteLine("field information");


            FieldInfo[] fi = c.GetFields(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance);

            foreach(var f in fi)
            {
                Console.WriteLine(f);

            }

            #endregion
            */



        }
    }
}
