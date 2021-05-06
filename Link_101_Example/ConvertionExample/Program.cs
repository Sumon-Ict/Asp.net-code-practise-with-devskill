using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertionExample
{



    public  class CaseInsensitiveComparer : IComparer<string>   //class declaration 
    {
        public int Compare(string x, string y) =>
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

            foreach(var s in sortedWords)
            {
                Console.WriteLine(s);
            }




            double[] values = { 12.3, 90.67, 23.8, 87.87 };

            var query = from d in values
                        orderby d  descending
                        select d;
            var result = query.ToArray();

            foreach(var s in result)
            {
                Console.WriteLine(s);

            }

            for(var d=0;d<result.Length;d++)
            {
                Console.WriteLine(result[d]);

            }

            string[] names = { "sumon", "sujon", "sohag" };

            var sqre1 = (from sq in names
                        orderby sq ascending
                        select sq).ToList();

            foreach(var info in sqre1)
            {
                Console.WriteLine(info);

            }

            var studentinfo = new[] { new { name = "sumon", age = 78 },  
                                  new { name = "kajol", age = 90 },
                                   new { name = "suvo", age = 65 } };
            var dictionaryinfo = studentinfo.ToDictionary(n => n.name);

            Console.WriteLine(dictionaryinfo["suvo"]);





            object[] infoval = { 12, "90", 'A', 89.98, null };

            var converinfo = infoval.OfType<string>();    //find string type values 

            foreach(var info in converinfo)
            {
                Console.WriteLine(info);

            }



            var datainfo = Product.list;

            foreach(var info in datainfo)
            {
                Console.WriteLine(info.name);

            }

            var sqlinfo12 = (from p in datainfo
                           where p.productId == 12
                           select p);

            foreach(var info in sqlinfo12)
            {
                Console.WriteLine(info.name);


            }

            int[] numbers = { };
            var firstordefault = numbers.FirstOrDefault();

            Console.WriteLine(firstordefault);

            var productid14 = datainfo.FirstOrDefault(p => p.productId == 14);

            Console.WriteLine(productid14);
            Console.WriteLine($"{ productid14 != null}");

            int[] number = { 23, 4, 21, 56, 78, 90 };

            var a = (from n in number
                     where n > 21
                     select n).ElementAt(2);

            Console.WriteLine(a);

            var number1 = from n in Enumerable.Range(100, 50)
                          select (number: n, oddeven: n % 2 == 1 ? "odd" : "even");

            foreach(var n in number1)
            {
                Console.WriteLine("the number is {0} is {1}", n.number, n.oddeven);

            }

            var number2 = Enumerable.Repeat(12,2);

            foreach(var i in number2)
            {
                Console.WriteLine(i);

            }

            string[] catagories = { "computer", "calculator", "laptop", "destop", "tap" };

            var sq2 = from c in catagories
                      join p in datainfo on c equals p.name
                      select (catagory: c, p.price);
            foreach(var info in sq2)
            {
                //Console.WriteLine(info.price);
                Console.WriteLine($"{info.catagory}  price: {info.price}");


            }


            var sq3 = from c in catagories
                      join p in datainfo on c equals p.catagory into ps
                      select (catagory2: c, datainfo: ps);
            foreach(var info in sq3)
            {
                Console.WriteLine($"{info.catagory2} :");

                foreach(var info2 in info.datainfo)
                {
                    Console.WriteLine($"{info2.name}");

                }
            }


















          
          









        }
    }
}
