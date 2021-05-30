using System;
using System.Collections.Generic;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var name = "Jalaluddin";
            var person = (name, 32, married: true, 35.4, time);

            Console.WriteLine($"Name = {person.name}");
            Console.WriteLine($"Age = {person.Item2}");
            Console.WriteLine($"Married = {person.married}");
            Console.WriteLine($"Weight = {person.Item4}");
            Console.WriteLine($"Time = {person.time}");



            var listOfPersons = new List<(int age, string name, double weight)>();
            
            for(int i = 0; i<10; i++)
            {
                listOfPersons.Add(   (i + 2, $"Mr.{i}", i + 1 * 5)   );
            }

            foreach(var item in listOfPersons)
            {
                Console.WriteLine($"Name: {item.name}, Age: {item.age}, Weight: {item.weight}");
            }

            var result = GetPersonResult();
            Console.WriteLine($"Name: {result.name}, Age: {result.age}, Subject: {result.result.Subject}, Grade: {result.result.Grade} ");
        }

        static (string name, int age, Result result)  GetPersonResult()
        {
            return ("jalaluddin", 38, new Result { Subject= "Asp.net", Grade = 3.8 });
        }
    }
}
