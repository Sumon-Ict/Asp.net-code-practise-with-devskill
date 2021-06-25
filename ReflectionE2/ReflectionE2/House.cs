using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionE2
{
   public  class House:Entity
    {
        public string address { get; set; }

        public int housecode { get; set; }


        public House()
        {
            EntityType = "House";

        }
    }
}
