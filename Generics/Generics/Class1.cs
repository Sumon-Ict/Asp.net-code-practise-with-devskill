using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public  class Class1<T>
    {

        private T data;

        public T value
        {
            get { return this.data; }
            set
            {
                this.data = value;
            }
        }

    }
}
