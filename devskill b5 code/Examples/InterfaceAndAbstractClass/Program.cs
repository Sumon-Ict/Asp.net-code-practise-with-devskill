using System;

namespace InterfaceAndAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = GetAnimal();
            animal.Eat();
            animal.Move();

            Console.WriteLine("Hello World!");
        }

        private static IAnimal GetAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
