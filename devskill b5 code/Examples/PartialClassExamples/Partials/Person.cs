using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassExamples
{
    public partial class Person
    {
        public int Age { get; set; }
        public Person(string name, string address, int age)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void Talk()
        {
            Console.WriteLine("talking");
        }
    }
}
