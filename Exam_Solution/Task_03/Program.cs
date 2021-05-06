using System;
using System.IO;
using System.Reflection;


namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Type[] type = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var t in type)
            {
                if(t.BaseType.Name==nameof(BaseModel))
                {
                    Console.WriteLine(t.Name);

                }
            }

        }
    }
}
