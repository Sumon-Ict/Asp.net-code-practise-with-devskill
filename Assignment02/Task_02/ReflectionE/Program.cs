using System;
using System.Collections.Generic;

namespace ReflectionE
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  var type = typeof(Worker);

              var ob = new Worker() { id = 90, name = "kalam", weight = 87 };

              var methods = type.GetMethods();

              foreach(var method in methods)
              {
                  Console.WriteLine(method);

                  if(method!=null)
                  {
                      var para = method.GetParameters();

                      object obj = Activator.CreateInstance(type,null);

                      if(para.Length==0)
                      {
                          method.Invoke(obj, null);

                      }



                  }
              }
            */


            var information = new Information();

            information.id = 12;

            information.person.Add(new Person() { name = "sumon", home = "bogura", code = 98 });

            information.person.Add(new Person() { name = "sujon", home = "magura", code = 67 });
            information.person.Add(new Person() { name = "kalam", home = "dhaka", code = 87 });

            information.worker.Add(new Worker() { id = 12, name = "imran", weight = 23 });
            information.worker.Add(new Worker() { id = 23, name = "sakib", weight = 65 });
            information.worker.Add(new Worker() { id = 34, name = "suvo", weight = 98 });


            var information2 = new Information() { id = 23 };
            information2.person.Add(new Person() { name = "simu", home = "vola", code = 8 });
            information.person.Add(new Person() { name = "lovely", home = "manikgonj", code = 7 });





            IList<Person> Getinfo = information.person;

            foreach(var info in Getinfo)
            {
                Console.WriteLine($"name: {info.name}, home:{info.home}, code : {info.code}");

            }

            IList<Worker> Getworker = information.worker;

            IList<Dictionary<Person, Worker>> list = new List<Dictionary<Person, Worker>>();

            var types = information.person.GetType();


            




            



            


            


           




           






           
        }
    }
}
