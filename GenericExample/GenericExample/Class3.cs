using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
  public class Class3<T>
    {

        public T name { get; set; }
        public T home { get; set; }


          public void display(T a, T b)
        {
            Console.WriteLine($"  firstvalue: {a}, secondvalue: {b}");

        }
        public static void show(T[] arr)
        {
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
        public static bool check(T a,T b)
        {
            var c = a.Equals(b);

            return c;
        }

       
    }
}
