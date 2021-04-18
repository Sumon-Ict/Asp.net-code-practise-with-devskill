using System;
using System.Collections.Generic;
using System.Linq;



namespace LinkExample03
{
    class Program
    {
       
        static List<Person> persons = new List<Person>
        {
            new Person{name="sumon",age=23,weight=21.34, subjects=new List<string>{"bagla","english","math"},marks=new List<int>{12,34,32}},
            new Person{name="rahim",age=21,weight=23,subjects=new List<string>{"arabic","history","economics"},marks=new List<int>{34,21,45}},
            new Person{name="suvo",age=67,weight=56,subjects=new List<string>{"datastructure","Ict","cse"},marks=new List<int>{56,4,23}},
            new Person{name="kajol",age=2,weight=89,subjects=new List<string>{"EEE","farmacy","statistics"},marks=new List<int>{3,2,4}},
            new Person{name="himu",age=5,weight=54,subjects=new List<string>{"socialscience","marketing","accounting"},marks=new List<int>{45,67,89}},
            new Person{name="imran",age=54,weight=34,subjects=new List<string>{"agriculture","cse","ice"},marks=new List<int>{89,43,234}},
            new Person{name="sujon",age=90,weight=90,subjects=new List<string>{"ict","ict-101","ict=102"},marks=new List<int>{9,98,67}},
            new Person{name="rakib",age=87,weight=8,subjects=new List<string>{"ict-103","ict-104","ict-105"},marks=new List<int>{3,56,78}}

        };
        static void Main(string[] args)
        {
            IEnumerable<Person> personquery1 =
                from SQ1 in persons
                select SQ1;

            foreach(var personinfo in personquery1)
            {
                Console.Write("name={0}, age={1},weight={2} ", personinfo.name, personinfo.age, personinfo.weight);

                //Console.WriteLine(personinfo.subjects.Count);
                int subjectcount = personinfo.subjects.Count;
                int markscount = personinfo.marks.Count;

                Console.Write("subjects: ");

                for(int i=0;i<subjectcount;i++)
                {
                    //Console.Write(personinfo.subjects[i]);
                    Console.Write("  {0}", personinfo.subjects[i]);

                }
                Console.Write("  marks:");

                foreach(var m in personinfo.marks)
                {
                    // Console.WriteLine(m);
                    Console.Write(" ");
                    Console.Write(m);


                }
                Console.WriteLine("\n\n");




            }

            var personquery2 =
                from SQ2 in persons
                where SQ2.age > 20 && SQ2.age < 100
                select SQ2.name + "  " + SQ2.weight;

            foreach(var personinfo in personquery2)
            {
                Console.WriteLine(personinfo);

            }

            var personquery3 =
                from SQ3 in persons
                where SQ3.age > 20
                select SQ3;

            foreach(var personinfo in  personquery3)
            {
                Console.WriteLine("name={0}, weight={1}", personinfo.name, personinfo.weight);

            }

            var personquery4 =
                from SQ4 in persons
                orderby SQ4.name
                select SQ4;
            foreach(var personinfo in personquery4)
            {
                Console.WriteLine(" name={0}, age={1}, subject={2}", personinfo.name, personinfo.age, personinfo.subjects[0]);

            }

            var personquery5 =
                from SQ5 in persons
                group SQ5 by SQ5.name[0];
               

            foreach(var personinfo in personquery5)
            {
                Console.WriteLine(personinfo.Key);

                foreach(var person in personinfo)
                {
                    Console.WriteLine(person.name);

                }
            }
                    
                


        }





    }
}
