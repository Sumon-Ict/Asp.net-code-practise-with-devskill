using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  public   class Student
    {
        public int Id { get; set; }

        public string Home { get; set; }

        public double cgpa { get; set; }

        public T maxfun<T>(T a,T b)where T:IComparable
        {
            return a.CompareTo(b)>0?a:b;

        }

        public void Test<T>(T a, T b)
        {
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }


    }
}
