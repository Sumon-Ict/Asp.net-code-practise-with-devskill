using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> Names;
          
            foreach(var info in list1)
            {
                Console.WriteLine($"Name :{info.Name}  age: {info.Age}");

            }
            foreach(var info in list2)
            {
                Console.WriteLine($"Name :{info.Name}  age: {info.Age}");
            }

            string[] digits = { "one", "two", "three", "four", "five","sixe","seven","eight","nine" };

            var reversdigit =
               (from digit in digits
            
                select digit).Reverse();

       foreach(var info in reversdigit)
            {
                Console.WriteLine(info);

            }
        }
        static List<Student> list1 = new List<Student>()
        {
            new Student{Name="sumon",Age=23},
            new Student{Name="sujon",Age=45},
            new Student{Name="suvo",Age=21 },
            new Student{Name="kajol",Age=34},
            new Student{Name="rashid",Age=32}


        };
        static List<Student> list2 = new List<Student>()
        {
             new Student{Name="suvo",Age=13},
            new Student{Name="kalam",Age=50},
            new Student{Name="marful",Age=26 },
            new Student{Name="Humayun",Age=30},
            new Student{Name="Imran",Age=35}
        };
    }
}
