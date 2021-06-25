using System;

namespace ReflectionE2
{
    class Program
    {
        static void Main(string[] args)
        {
            var policy = new Policy();

            policy.Name = "abc";
            policy.Entities.Add(new House() { address = "bogura", housecode = 12 });
            policy.Entities.Add(new House() { address = "pabna", housecode = 23 });
            policy.Entities.Add(new Product() { productname = "books", brand = "kajol", price = 123 });

            policy.Entities.Add(new Product() { productname = "laptop", brand = "hp", price = 23000 });

            policy.Entities.Add(new Person() { Name = "sumon", weight = 78 });
            policy.Entities.Add(new Person() { Name = "kajol", weight = 76 });

            policy.Entities.Add(new Worker() { WorkerName = "imran", Id = 23 });
            policy.Entities.Add(new Worker() { WorkerName = "suvo", Id = 89 });


            reflection(policy);



        }

        static void reflection(Policy policy)
        {
            Console.WriteLine(policy.Name);

            foreach(var classentity in policy.Entities)
            {

                Console.WriteLine(classentity.EntityType);

                foreach(var property in classentity.GetType().GetProperties())
                {
                    Console.WriteLine($"propertyname: {property.Name}- {property.GetValue(classentity)}");
                }

                Console.WriteLine("");

            }
        }
    }
}
