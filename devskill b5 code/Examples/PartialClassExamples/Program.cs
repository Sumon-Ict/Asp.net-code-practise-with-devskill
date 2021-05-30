using System;

namespace PartialClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("jalaluddin", "dhaka", 22);
            person.Walk();
            person.Talk();
        }
    }
}
