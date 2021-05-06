using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerisExample
{
   public class GenericsClass
    {

        public void show<T>(T mess)
            {

            Console.WriteLine($"generic method information is {mess}");

        }
        public void print<T>(T name,T age,T dept,T roll)
        {
            Console.WriteLine($" name:{name}, age: {Convert.ToInt32(age)}, deptname:{dept}, rollno: {Convert.ToInt32(roll)}");

        }


        public void Swap<T>( ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }


    }
}
