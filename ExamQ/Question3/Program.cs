using System;
using System.Reflection;
using System.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("the inheritate class name from the BaseModel class");


            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in types)
            {
                if(type.IsSubclassOf(typeof(BaseModel)))
                    {
                    Console.WriteLine(type.Name);


                }
            }
            

        }

    }
}
