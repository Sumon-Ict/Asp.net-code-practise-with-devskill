using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public  class MyORM<T>where T:IData
    {
        public void Add(T input)
        {
            
        }
    }
}
