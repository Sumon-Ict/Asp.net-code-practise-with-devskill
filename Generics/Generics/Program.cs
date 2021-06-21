using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            var maxvalue = Max("sumon", "sujon");


            var obj = new Student();

            obj.Test(12, 90);


            var result = obj.maxfun(23, 46);

            Console.WriteLine(result);
            Console.WriteLine(maxvalue);

            var ob2 = new Class2<string>();

           Console.WriteLine(ob2.create("ssumon", "mia"));



            var res = ob2.maxf("sujonldjkj", "kjdfkjk");

            Console.WriteLine(res);

            var minv = ob2.minf("imran", "kajol");

            Console.WriteLine(minv);



            List<string> list1 = new List<string>();

            IList<DataStore> list = new List<DataStore>();

            var d = new DataStore();

            d.id = 12;
            d.Name = "sumon";
            d.weight = 23.45;

            var d1 = new DataStore();
            d1.id = 21;
            d1.Name = "suvo";
            d1.weight = 34.54;

            list.Add(d);
            list.Add(d1);

            list.Add(new DataStore() { id = 134, Name = "Imran", weight = 87 });
            list.Add(new DataStore() { id = 76, Name = "Kajol", weight = 56 });

            list.Add(new DataStore() { Name = "nafisa", weight = 34, id = 87 });



            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine($" id: {list[i].id}, Name: {list[i].Name}, weight: {list[i].weight}");

            }   
           

            Class1<string> gc = new Class1<string>();

            gc.value = "sumon";
            gc.value = "kalam";

           
            Console.WriteLine(gc.value);


            List<string> names = new List<string>();

            names.Add("kajol");
            names.Add("momin");
            names.Add("rifat");

            names.Sort();

            foreach(var name in names)
            {
                Console.WriteLine(name);

            }


            IList<Student> std = new List<Student>();

            std.Add(new Student() { Id = 12, Home = "bogura", cgpa = 3.29 });
            std.Add(new Student() { Id = 23, Home = "magura", cgpa = 3.44 });
            std.Add(new Student() { Id = 76, Home = "kushtia", cgpa = 3.34 });


            foreach(var info in std)
            {
                Console.WriteLine($"studentId: {info.Id}, studentname: {info.Home}, cgpa: {info.cgpa}");

            }

            IList<Dictionary<int, Student>> list2 = new List<Dictionary<int, Student>>();


            var dic = new Dictionary<int, Student>();

            dic.Add(1, new Student() { Id = 23, Home = "dhaka", cgpa = 3.23 });

            list2.Add(dic);  //insert listed


            var dic1 = new Dictionary<int, Student>();

            dic1.Add(2, new Student() { Id = 23, Home = "rajshahi", cgpa = 3.21 });

            list2.Add(dic1);



            for(int i=0;i<list2.Count;i++)
            {
                foreach(KeyValuePair<int,Student>kv in list2[i])
                {
                    Console.WriteLine($"key: {kv.Key} Home: {kv.Value.Home}, Cgpa:{kv.Value.cgpa}");

                }
            }
           

        }
        static T Max<T>(T a,T b)where T:IComparable
        {
            return a.CompareTo(b)>0?a: b;

        }
    }
}
