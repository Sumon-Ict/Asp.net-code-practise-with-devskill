using System;
using System.Collections.Generic;

namespace CsharpNewFeature
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "sumon", "sjikm", "rahim", "karim", "salam", "rashid" };

            foreach(var name in names[..4])
            {
                Console.WriteLine(name);

            }

            foreach(var name in names[..])    ///print all array elements 
            {
                Console.WriteLine(name);

            }

            foreach(var name in names[1..4])
            {
                Console.WriteLine(name);

            }

            var words = new string[]
                       {
                                    // index from start index from end
                            "The",                    // 0 ^9
                            "quick",            // 1 ^8
                            "brown", // 2 ^7
                            "fox", // 3 ^6
                            "jumped", // 4 ^5
                            "over", // 5 ^4
                            "the", // 6 ^3
                            "lazy", // 7 ^2
                            "dog" // 8 ^1
                            }; // 9 (or words.Length) ^



            (string a, int b, double c) x = ("sumon", 23, 34.90);  //tuple example

            Console.WriteLine("tuple 1 example");

            var n = x.a;
            Console.WriteLine(n);

            var age = (x.b);
            Console.WriteLine(age);

            Console.WriteLine("tuple 2 example");

            (string, int, float) info = ("kajol", 45, 90);

            Console.WriteLine(info.Item1);
            Console.WriteLine(info.Item3);

            var datastore = (p: "sujon", q: 90, weight: 76);  //tuple example

            Console.WriteLine(datastore.p);
            Console.WriteLine(datastore.weight);



            var results = getvalues(23);

            var r = results.Item2;
            Console.WriteLine(r);

            foreach (var name in results.names) 
            {
                Console.WriteLine(name);

            }

            Console.WriteLine("method information is given  ");

            var res = getinfo();
            Console.WriteLine(res.Item2);

            foreach(var v in res.Item1)
            {
                Console.WriteLine(v);

            }

            var line = Console.ReadLine();

            var re = int.TryParse(line, out int number);
            Console.WriteLine(number);





        }

        

        public static (List<string>names,int ) getvalues(int count)
        {
            List<string>names = new List<string>() { "sumon", "sujon", "kajol", "suvo" };

            int c = 23;
            return (names, c);

        }

        public static (List<string>,int) getinfo()
        {
            List<string> values = new List<string>() { "kalol", "rashid", "sarif" };
            int count = 45;

            return (values, count);

        }
    }
}
