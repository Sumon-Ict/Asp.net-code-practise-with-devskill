using System;
using System.Linq;
using System.Collections.Generic;

namespace GenericAndDelegate
{
    delegate T mydelegate<T>(T value);
    delegate T mydelegate2<T>(T a, T b);


    class Program
    {
        static int addnum(int a)
        {
            return a + 100;
        }

        static string Name(string name)
        {
            return name;
        }
        static int mul(int a,int b)
        {
            var r = a * b;
            return r;
        }

        static string address(string s,string s2)
        {
            var r = (s+" "+s2);
            return r;
               
          

        }
        static string info(string s1,string s2)
        {
            string s = "my name is " + s1 + "my home district name is " + s2;
            return s;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            mydelegate<string> dl = new mydelegate<string>(Name);

            var r = dl("sumon");

            Console.WriteLine($"my name is {r}");

            mydelegate<int> dl2 = new mydelegate<int>(addnum);

            var r2 = dl2(234);
            Console.WriteLine("the number after adding is {0}", r2);

            mydelegate2<int> dl3 = new mydelegate2<int>(mul);

            var r3 = dl3(12, 345);
            Console.WriteLine("the multiplication is {0}", r3);

            mydelegate2<string> dl4 = new mydelegate2<string>(address);

            var r4 = dl4("sumon  ", " sujon");
            Console.WriteLine(r4);

            mydelegate2<string> dl5 = new mydelegate2<string>(info);

            var r5 = dl5("sumon", "Bogura");

            Console.WriteLine(r5);


           



        }
    }
}
