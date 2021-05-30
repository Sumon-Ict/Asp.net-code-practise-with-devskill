using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Collections.EnumerableExample
{
    public class EnumberableExampleRunner
    {
        public string Name => "Enumberable Example";

        public void Run()
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}
