using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionE2
{
   public  class Person:Entity
    {

        public string Name { get; set; }
        public double weight { get; set; }

        public Person()
        {
            EntityType = "Person";

        }

    }
}
