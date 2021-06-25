using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionE2
{
   public  class Policy
    {
        public string Name { get; set; }

        public IList<Entity> Entities { get; set; } = new List<Entity>();


    }
}
