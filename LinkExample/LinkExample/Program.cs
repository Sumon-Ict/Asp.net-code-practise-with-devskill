using System;
using System.Linq;
using System.Collections.Generic;


namespace LinkExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // IEnumerable<Student> studentQuery =

                 var studentQuery=
                from student in students
                where student.Scores[0] > 90 && student.Scores[3]<80
                select student;

            foreach (var student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }

            

            IEnumerable<Student> sq2 =
                from st2 in students
                where st2.ID > 110

                select st2;


            foreach(var st2 in sq2)   //foreach(Student st2 in sq2)  same works 
            {
                Console.WriteLine("{0}, {1}", st2.Last, st2.Scores[3]);

            }
            //IEnumerable<Student> data =
            var data =
                from studentdetails in students
                    //orderby studentdetails.ID ascending
                group studentdetails by studentdetails.Last[0];
            // select studentdetails;


            foreach (var stGroup in data)
            {
                Console.WriteLine(stGroup.Key);
                foreach (var s in stGroup)
                {
                    Console.WriteLine(" {0}, {1}",
                    s.Last, s.ID);
                }
            }


            //     group and orderby same time 
              
            var studentQuery4 =  
           from student in students
           group student by student.Last[0] into studentGroup
             orderby studentGroup.Key
             select studentGroup;
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }

            var sq4 =
                from st4 in students
                group st4 by st4.First[0] into stgroup
                orderby stgroup.Key
                select stgroup;
            foreach(var x in sq4)
            {
                Console.WriteLine(x.Key);

                   foreach(var y in x)
                {
                    Console.WriteLine("{0}, {1}", y.First, y.Last);

                }
            }


            
            /* foreach (Student sd in data)
             {
                 Console.WriteLine("{0}, {1}, {2}, {3}", sd.First, sd.Last, sd.ID, sd.Scores[3]);

             }*/
           // #endregion

            
            var studentquery5 =
                from st5 in students
                let totalscore = st5.Scores[0] + st5.Scores[1] + st5.Scores[2] + st5.Scores[3]
                where totalscore / 4 < st5.Scores[0]
                select st5.First + "   " + st5.Last;

          


            foreach(var name in studentquery5)
            {
                Console.WriteLine(name);

            }


            //to transorm of select project on clause

            IEnumerable<string> studentquery6 =
                from st6 in students
                where st6.Last == "Garcia"
                select st6.First +"   " +st6.ID;

            Console.WriteLine("student name whom last name is garcia");


            foreach(var nameandId in studentquery6)
            {
                Console.WriteLine(nameandId);

            }



            var studentquery7 =
                from st7 in students
                let totalscsore = st7.Scores[0] + st7.Scores[1] + st7.Scores[2] + st7.Scores[3]
                select totalscsore;

            double average = studentquery7.Average();



            var studentquery8 =
                from st8 in students
                let x = st8.Scores[0] + st8.Scores[1] + st8.Scores[2] + st8.Scores[3]

                where x > average
                select new { id = st8.ID, score = x };


            foreach(var s in studentquery8)
            {
                Console.WriteLine("student id ={0}, score value={1}", s.id, s.score);
            }
           
            var  sentence = "my name is sumon and I am student of islamic university dept of information and communication technology";

            string[] words = sentence.Split(' ');
           
               var query = from word in words

                        group word.ToUpper() by word.Length into gr
                        orderby gr.Key
                        select new { Length = gr.Key, Words = gr };




            foreach (var obj in query)
            {
                        Console.WriteLine("Words of length {0}:", obj.Length);

                foreach (string word in obj.Words)

                    Console.WriteLine(word);
            }

        }



        static List<Student> students = new List<Student>
                       {
              new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81,60 }},
                                                                                                         
              new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
              new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
              new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
              new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
              new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
              new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
              new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
              new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
              new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
              new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
              new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
                  
        };
    }


}


