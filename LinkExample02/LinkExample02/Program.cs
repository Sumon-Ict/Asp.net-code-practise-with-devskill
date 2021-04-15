using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          
            
            List<string> names;   //list declaratioin rules 
            names = new List<string> { "sumon", "suvo", "kajol", "rashid" };

            List<int> result;
            result = new List<int>();
            result.Add(123);
            result.Add(234);
            result.Add(345);
            result.Add(90);

            foreach(var i in result)
            {
                Console.WriteLine(i);

            }

            var sum = 0;
            foreach(var i in result)
            {
                sum = sum + i;

            }

            Console.WriteLine(sum);
            Console.WriteLine("the sum of the integers value is {0}", sum);

            foreach(string name in names)
            {
                Console.WriteLine(name);

            }


            foreach(var student in students)
            {
                Console.WriteLine("score={0},homed={1}, age={2}, weight={3}", student.score[1], student.homedistrict,student.age,student.weight);

            }

          

            IEnumerable<Student> studentdetails =
                from std in students
                where std.weight > 12 && std.weight < 200
                select std;


            foreach(var studentinfo in studentdetails)
            {
                Console.WriteLine("name={0}, age={1}", studentinfo.name, studentinfo.age);

            }


            var studentQuerry =
                from SQ1 in students
                select SQ1;

            foreach(var studentinfo in  studentQuerry)
            {
                Console.WriteLine("name={0}, homedistrict={1},age={2},weigt={3}", studentinfo.name, studentinfo.homedistrict, studentinfo.age, studentinfo.weight);

            }

            var studenquery2 =
                from SQ2 in students
                where SQ2.score[2] > 23
                select SQ2;

            foreach(var studentinfo in studenquery2)
            {
                Console.WriteLine("age={0},weight={1}", studentinfo.age, studentinfo.weight);

            }

            var studentquery3 =
                from SQ3 in students
                let totalscore = SQ3.score[0] + SQ3.score[1] + SQ3.score[2] + SQ3.score[3]
                where totalscore / 4 > SQ3.score[0]
                select SQ3.name + "  " + SQ3.homedistrict;

            foreach(var studentinfo in studentquery3)
            {
                Console.WriteLine(studentinfo);

            }

            var studentquery4 =
                from SQ4 in students
                orderby SQ4.weight ascending
                select SQ4.name+"  "+SQ4.age;

            foreach(var studentinfo in studentquery4)
            {
                //Console.WriteLine("name={0}", studentinfo.name);
                Console.WriteLine(studentinfo);


            }



            var studentquery5 =
                from SQ5 in students
                group SQ5 by SQ5.name[0] into studentgroup
                orderby studentgroup.Key
                select studentgroup;



            foreach(var studentinfo in studentquery5)
            {
                Console.WriteLine(studentinfo.Key);

                foreach(var st in studentinfo)  // same works if we write such as foreach(Student st in studentinfo)
                {
                    Console.WriteLine(st.name);

                }
            }


            var studentquery6 =
                from SQ6 in students
                group SQ6 by SQ6.homedistrict[0] into studentG

                orderby studentG.Key
                select studentG;

            foreach(var studentinfo in studentquery6)
            {
                Console.WriteLine(studentinfo.Key);

                foreach(Student stinfo in studentinfo)
                {
                    Console.WriteLine(stinfo.age);

                }
            }



            var studentquery7 =
                from SQ7 in students
                let totalscore = SQ7.score[0] + SQ7.score[1] + SQ7.score[2] + SQ7.score[3]
                select totalscore;

            double average = studentquery7.Average();

            Console.WriteLine("the average value of the integers number is {0}", average);

            var studentquery8 =
                from SQ8 in students
                let x = SQ8.score[0] + SQ8.score[1] + SQ8.score[2] + SQ8.score[3]
                where x > average
                select new { Name = SQ8.name, Weight = SQ8.weight };    //  class property value is changed by this statement

            foreach(var studentinfo in studentquery8)
            {
                Console.WriteLine("student name={0}, student weight={1}", studentinfo.Name, studentinfo.Weight);

            }       



        }

        static List<Student> students = new List<Student>
        {
            new Student{name="sumon",homedistrict="bogura",age=12,weight=24,score=new List<int>{12,34,56,21}},
            new Student{name="sujon",homedistrict="magura",age=21,weight=23,score=new List<int>{23,43,12,32} },
            new Student{name="suvo",homedistrict="kushtia",age=34,weight=231,score=new List<int>{1,2,3,4}},
            new Student{name="kalam",homedistrict="magura",age=43,weight=87,score=new List<int>{4,5,6,7}},
            new Student{name="rashid",homedistrict="naogoan",age=87,weight=123,score=new List<int>{8,8,9,12}},
            new Student{name="rakib",homedistrict="chadpur",age=76,weight=345,score=new List<int>{13,14,15,16 } },
            new Student{name="himu",homedistrict="chuyadanga",age=34,weight=45,score=new List<int>{17,23,12,54}},
            new Student{name="rifat",homedistrict="rangpur",age=43,weight=89,score=new List<int>{32,45,67,89}}

        };
       
    }
}

