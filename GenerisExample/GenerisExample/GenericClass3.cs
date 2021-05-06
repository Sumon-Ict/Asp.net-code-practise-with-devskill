using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerisExample
{

   
   public  class GenericClass3
    {
        public void address<T>(T name,T district)
        {
            Console.WriteLine($"my name is {name} and my home distric is {district}");


        }


        public void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public int sum<T>(T a, T b)
        {
            var v = Convert.ToInt32(a);
            var v2 = Convert.ToInt32(b);

            return v + v2;

        }




    }
}
