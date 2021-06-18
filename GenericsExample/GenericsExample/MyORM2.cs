using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
   public class MyORM2<T>where T:IData
    {
        public int id { get; set; }
        public int age { get; set; }

        public string name { get; set; }

        public double weight { get; set; }

        public long length { get; set; }

        public int roll { get; set; }





    }
}
