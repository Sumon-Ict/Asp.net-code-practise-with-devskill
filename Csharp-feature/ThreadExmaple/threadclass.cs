using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExmaple
{
   public  class threadclass
    {


        public void print1()
        {
            for(int i=2;i<100;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);

                
            }
        }

        public void print2()
        {
            for(int i=0;i<123;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);

            }
        }
    }
}
