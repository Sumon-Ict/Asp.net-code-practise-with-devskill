using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list1 = new List<Student>() { new Student { Name = "sumon", Age = 12 }, new Student { Name = "sujon", Age = 90 } };
            List<Student> list2 = new List<Student>() { new Student { Name = "kajol", Age = 34 }, new Student { Name = "suvo", Age = 23 } };

            List<string> result;
            var r = list1.Union(list2);

            result = (from s in r
                     orderby s.Name,s.Age ascending
                     select s.Name).ToList();


            foreach(var name in result)
            {
                Console.WriteLine(name);

            }

                    

        }
    }
}
