using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring= "Server =DESKTOP-PAVS32T\\SQLEXPRESS;Database = Aspdotnetb5;User Id = aspdotnetb5;Password = aspdotnetb5";
           
            var s1 = new Students();
            s1.StudentName = "Karim";
            s1.Home = "magura";
            var s2 = new Students();
            s2.StudentName = "rahim";
            s2.Home = "Kushtia";

            var s3 = new Students();
            s3.StudentName = "Imran";
            s3.Home = "meherpur";

            var s4 = new Students();
            s4.StudentName = "kajol";
            s4.Home = "dhaka";

            MyORM<Students> obj1 = new MyORM<Students>(connectionstring);

            obj1.Insert(s1);
            obj1.Insert(s2);
            obj1.Insert(s3);
            obj1.Insert(s4);

          var r=  obj1.GetById(4);

            Console.WriteLine(r.StudentName);
            Console.WriteLine(r.Home);



        }
    }
}
