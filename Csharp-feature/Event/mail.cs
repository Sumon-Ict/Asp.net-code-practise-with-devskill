using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
   public class mail
    {
       // public delegate void notification1(string add, string m);

       // public event notification1 notify;


        public void emailnotification(string add,string m)
        {
            Console.WriteLine($"address {add}  message {m}");

        }
        public void messagenotification(string add,string m)
        {
            Console.WriteLine($"address {add}  message {m}");

        }


    }
}
