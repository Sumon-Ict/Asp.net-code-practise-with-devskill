using System;
using System.Reflection;
namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Assembly assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            foreach(var type in types )
            {
                Console.WriteLine(type.Name);
                Console.WriteLine(type.FullName);
                Console.WriteLine(type.Assembly);
                Console.WriteLine(type.BaseType);

                var methods = type.GetMethods();

                foreach(var m in methods)
                {
                    Console.WriteLine(m.Name);


                    var fields = m.GetParameters();

                    foreach (var f in fields)
                    {
                        Console.WriteLine($"{f.Name}  {f.ParameterType}");

                    }

                }
            }

            
        }
    }

    public class person
    {
       public  int Id { get; set; }
        public int roll { get; set; }

        public string Name { get; set; }

        public double weight { get; set; }

        public person(int i, int r)
        {
            this.Id = i;
            this.roll = r;
        }

        public person(int i,int r,string n,double w)
        {
            this.Id = i;
            this.roll = r;
            this.Name = n;
            this.weight = w;
        }
        public person()
        {

        }

        public void mul()
        {
            var r = Id * roll;

            Console.WriteLine($"the mul {r}");

        }



    }
}
