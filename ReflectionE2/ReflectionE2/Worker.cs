using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionE2
{
   public class Worker:Entity
    {

        public string WorkerName { get; set; }
        public int Id { get; set; }

        public Worker()
        {
            EntityType = "Worker";

        }
    }
}
