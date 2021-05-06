using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            person p1 = new person("sujon");
            p1.blabla = "sumon";
            p1.weight = 23.45;
            p1.age = 24;
            p1.gender = "male";
            p1.H = -45.56;
            p1.D = "red";


            Console.WriteLine(p1.H);



            person p2 = new person();
            p2.blabla = "Rahim";

            p2.weight = 45.34;
            p2.age = 34;
            p2.gender = "male";
            p2.H = 45.67;
            p2.D = "green";





            p1.result();
            p2.result();



            Console.WriteLine(p2.gender);
            Console.WriteLine($"gender of p2 person is {p2.gender}");
            Console.WriteLine($"the name of p1 person is {p1.blabla}");

        }
    }
}
