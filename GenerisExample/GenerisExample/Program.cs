using System;

namespace GenerisExample
{

    delegate T mydelegate<T>(T a);
    class Program
    {
        static int addnum(int a)
        {
            return a + 120;
        }

        static void swap<T>(  ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {

            mydelegate<int> dl = new mydelegate<int>(addnum);
            var r = dl(12);
            Console.WriteLine(r);





            char c1 = 'K';
            char c2 = 'M';

            Console.WriteLine("before swap c1: {0}, c2: {1}", c1, c2);

            swap<char>(ref c1, ref c2);

            Console.WriteLine("after swap c1: {0}, c2: {1}", c1, c2);




            Person<string> Name = new Person<string>("sumon");

            Person<string> info = new Person<string>();
            info.name = "sumon";
            info.Home = "bogura";
            info.dept = "ICT";

            Console.WriteLine(info.dept);


            Person<string> info2 = new Person<string>();
            info2.name = "Kajol";
            info2.Home = "kushtia";
            info2.dept = "CSE";
            info2.age = "67";
            info2.weight = "87";

            info2.print();

            info2.print2();

            Person<double> getArea = new Person<double>();
            getArea.height = 78.90;
            getArea.width = 89.87;
            getArea.lenth = 12345;

            Console.WriteLine(getArea.height * getArea.width * getArea.lenth);  //without method 

            var result = getArea.Area();  //method callling 
            Console.WriteLine(result);


            Person<string> data2 = new Person<string>();  //also method for calculating area
            data2.height = "345";
            data2.width = "876";
            data2.lenth = "6780";

            var area = data2.Area();

            Console.WriteLine(area);


            GenericsClass gc = new GenericsClass();
            gc.show("method declaration ");

            gc.print("sujon", "56", "ICT", "1418013");

            int a = 12;
            int b = 32;

            Console.WriteLine($"befor swap a={a}, b={b}");


            gc.Swap<int>(ref a, ref b);


            Console.WriteLine($"after swap a={a}, b={b}");




            GenericsClass2<string> gc2 = new GenericsClass2<string>(8);

            gc2.setvalue(1, "sumon");
            gc2.setvalue(0, "suvo");
            gc2.setvalue(2, "kajol");
            gc2.setvalue(3, "imran");
            gc2.setvalue(4, "rashid");


            var name = gc2.getvalue(2);

            


            Console.WriteLine("the student name is {0}", name);

            GenericsClass2<char> gc3 = new GenericsClass2<char>(5);
            gc3.setvalue(2, 'K');
            gc3.setvalue(3, 'M');
            gc3.setvalue(4, 'S');
            gc3.setvalue(1, 'U');

            char c = gc3.getvalue(3);

            Console.WriteLine($"the getcharacter value is {c}");

            GenericClass3 Gc3 = new GenericClass3();

            int a1 = 23;
            int b1 = 43;
            Console.WriteLine("befor swap v1={0}, v2={1}", a1, b1);

            Gc3.Swap<int>(ref a1, ref b1);

            Console.WriteLine("after swap:  v1= {0}, v2={1}", a1, b1);

            Gc3.address("sumon", "bogura");

          var sumr=  Gc3.sum<int>(12, 45);

            Console.WriteLine($"the sum of two number is {sumr}");

            var sum2 = Gc3.sum<string>("879", "568");

            Console.WriteLine($"the sum2 is {sum2}");








































            





        }
    }
}
