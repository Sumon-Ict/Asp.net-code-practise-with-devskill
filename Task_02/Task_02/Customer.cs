using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
   public  class Customer
    {
        public int roll { get; set; }
        public string Home { get; set; }
        
        public double weight { get; set; }
        

        public void myfun()
        {
            Console.WriteLine($"the customer home name is {Home} ");

        }
        
    }
}
