using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionExample
{
  public  class Product
    {
        public string name { get; set; }

        public int productId { get; set; }
        public string catagory { get; set; }
        public double price { get; set; }

        public static List<Product> list = new List<Product>()
        {
            new Product{name="computer",productId=12,catagory="electronics",price=78.90},
            new Product{name="calculator",productId=11,catagory="electronics",price=23.98},
            new Product{name="laptop",productId=34,catagory="abc",price=34.89},
            new Product{name="mobile",productId=14,catagory="bjgkkg",price=87.987}
        };


    }
}
