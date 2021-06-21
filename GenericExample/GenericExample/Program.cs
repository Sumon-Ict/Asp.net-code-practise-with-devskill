using System;
using System.Collections.Generic;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li =  new  List<string>();

            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { name = "sumon", weight = 12 });
            list.Add(new Class1() { name = "suvo", weight = 890 });
            list.Add(new Class1() { name = "kajol", weight = 21 });

            foreach(var info in list)
            {
                Console.WriteLine($"{info.name} , {info.weight}");
            }

            Dictionary<Class1, Class2> dic = new Dictionary<Class1, Class2>();

            dic.Add(new Class1() { name = "imran", weight = 87 }, new Class2() { name = "kajol", home = "bogura" });

            dic.Add(new Class1() { name = "suvo", weight = 65 }, new Class2() { name = "momin", home = "magura" });


            foreach(KeyValuePair<Class1,Class2>kv in dic)    
            {
                Console.WriteLine($"{kv.Key.name}, {kv.Value.home}");

            }

            int[] value = { 12, 45, 56 };

            var ob = new Class1();
            ob.showarray(value);

            string[] names = { "sumon", "sujon", "sohag", "sihab" };

            ob.show<string>(names);

            ob.show<int>(value);

            double[] weight = { 90.7, 87, 56.8 };

            ob.show<double>(weight);

            Class3<string>.show(names);  //using method  of class3

            Class3<int>.show(value);

           var r= Class3<int>.check(89, 98);
            Console.WriteLine(r);

            var r2 = Class3<string>.check("sumon", "sumon");

            Console.WriteLine(r2);

            Class1.type("sumon");

            Class1.type(90.87);


            Class3<string> ob1 = new Class3<string>();
            ob1.display("sumon", "sumon");















           

















        }
    }
}
