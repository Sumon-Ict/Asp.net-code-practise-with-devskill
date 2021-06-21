using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Class2<T> where T : IComparable
    {
        public T maxf(T a, T b)   //cretate compareable fucntion
        {
            return a.CompareTo(b) > 0 ? a : b;

        }

        public T minf(T a, T b)
        {
            return a.CompareTo(b) > 0 ? b : a;


        }

        public T[] create(T firstname, T lastname)
            {
            return (new T[] { firstname, lastname });

            }

        public void testGeneric(T a, T b)
        {
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

        }
            

    }
}
