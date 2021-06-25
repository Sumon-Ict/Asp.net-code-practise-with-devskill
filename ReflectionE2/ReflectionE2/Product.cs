using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionE2
{
   public  class Product:Entity
    {
        public  string productname { get; set; }

        public string brand { get; set; }

        public double price { get; set; }

        public Product()
        {
            EntityType = "Product";

        }

    }
}
