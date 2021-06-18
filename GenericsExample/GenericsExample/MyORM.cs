using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
  
      public  class MyORM<T>

    {
       public T Title { get; set; }
        public T Name { get; set; }
        public T age { get; set; }

    }
}
