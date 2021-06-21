using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
   public  class Class1
    {
        public string name { get; set; }
        public double weight { get; set; }


        public void showarray(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        public void show<T>(T[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
        public static void type<T>(T a)
        {
            Console.WriteLine(typeof(T));

        }


    }
}
