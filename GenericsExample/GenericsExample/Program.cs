using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyORM<IData> obj = new MyORM<IData>();
            MyORM<string> obj2 = new MyORM<string>();
            obj2.Name = "sumon";
            obj2.Title = "student";
  

            Console.WriteLine(obj2.Name);
            Console.WriteLine(obj2.Title);



            MyORM2<IData> obj3 = new MyORM2<IData>();
            obj3.age = 12;
            obj3.id = 123;
            obj3.name = "sumon";
            obj3.roll = 1234;
            obj3.length = 987;
            obj3.weight = 89.98;


            Console.WriteLine(obj3.age);
            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.weight);








           


        }
    }
}
