using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  public  class DataStore:IData
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double weight { get; set; }

    }
}
