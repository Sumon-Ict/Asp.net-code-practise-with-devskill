using System;

namespace GenericDelegate
{
   
    class Program
    {
        delegate T add<T>(T a, T b);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            add<int> re = new add<int>(addf);

            var r = re(12, 45);

            Console.WriteLine($"the sum of the two inter is {r}");

            add<string> addstring = new add<string>(concate);

            var r2 = addstring("sumon", "sujon");

            Console.WriteLine($"the final string is {r2}");


        }

        static int addf(int a,int b)
        {
            return a + b;

        }

        static string concate(string a,string b)
        {
            var s = a + " " + b;
            return s;
        }
    }
}
