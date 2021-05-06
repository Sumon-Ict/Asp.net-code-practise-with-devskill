using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerisExample
{
    public class Person<T>
    {
        public T name { get; set; }
        public T dept { get; set; }
        public T Home { get; set; }

        public T age { get; set; }
        public T weight { get; set; }

        public T height { get; set; }

        public T width { get; set; }

        public T lenth { get; set; }

        public double Area()
        {
            var h = Convert.ToDouble(height);
            var w = Convert.ToDouble(width);
            var l = Convert.ToDouble(lenth);

            return (h * w * l);


        }


        public void print()

        {
            Console.WriteLine($"name:{name}, Deptname:{dept}, Home:{Home}, age:{Convert.ToInt32(age)}, weight:{Convert.ToDouble(weight)}");

        }



        public void print2()
        {
            Console.WriteLine($"name: {name}, Deptname: {dept}, Home:{Home}");

        }

        public Person(T name)  //a argument constructor 
            {
            Console.WriteLine($"my name is {name}");

            }

        public Person()  //empty costructor 
        {

        }

       

    }
}
