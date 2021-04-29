using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkQuery
{

    class Program
    {
        static void Main(string[] args)
        {

            var datainfo = Product.products;      //information collection without creating instance 

            foreach(var v in datainfo)
            {
                Console.WriteLine(v.ProductName);

            }

             
            var datainfo2 = new ProductInfo();   
            var data = datainfo2.productvalue;   //information collection by creating instance 

            foreach(var i in data)
            {
                Console.WriteLine(i.UnitPrice);

            }


            var productquery1 =
                from SQ1 in data
                where SQ1.ProductID > 23 && SQ1.ProductID < 30
                select (productname: SQ1.ProductName, productprice: SQ1.UnitPrice);
            
            foreach(var s in productquery1)
            {
                Console.WriteLine($"productname: {s.productname}, price {s.productprice}");

            }

            var productquery2 =
                from SQ2 in data
                group SQ2 by SQ2.Category into g
                select (catagory: g.Key, productcount: g.Count());

            foreach(var info in productquery2)
            {
                Console.WriteLine($" catagory: {info.catagory}, productcount: {info.productcount}");

            }

            double[] values = { 12.3, 45.6, 90.3, 34.56, 7.98 };

            var data1 = from d in values
                        orderby d descending
                        select d;
            foreach(var i in data1)
            {
                Console.WriteLine(i);

            }

            var array = data1.ToArray();

           for(var i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);

            }

            var dictionary = new[] {new {name="sumon",mark=12}, new{name="sujon",mark=89},
                new{name="kajol",mark=76}

           };

            var dictionaryresult = dictionary.ToDictionary(sr => sr.name);

            Console.WriteLine(dictionaryresult["sumon"]);


            var product12 = (from p in data
                             where p.ProductID == 12
                             select p).First();
            Console.WriteLine(product12.UnitPrice);

            string[] names = { "kalam", "kajol", "momin", "malek", "sumon", "sujon" };

            var namestartwithofm = names.First(s => s[0] == 'm');
            Console.WriteLine(namestartwithofm);

            var ordergroup = from SQ3 in data
                             group SQ3 by SQ3.Category into g
                             select (catagory: g.Key, p: g);
            foreach(var info in ordergroup)
            {
                Console.WriteLine("kename {0}", info.catagory);

                foreach(var re in info.p)
                {
                    Console.WriteLine(re);

                }
            }




















        }


    }
}
