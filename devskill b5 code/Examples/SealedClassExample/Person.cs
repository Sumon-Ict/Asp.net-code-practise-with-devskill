using System;
using System.Collections.Generic;
using System.Text;

namespace SealedClassExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public virtual void Vote()
        {

        }
    }
}
