using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassExamples
{
    public partial class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {
            Name = string.Empty;
            Address = string.Empty;
            Age = 0;
        }

        public void Walk()
        {
            Console.WriteLine("walking");
        }
    }
}
