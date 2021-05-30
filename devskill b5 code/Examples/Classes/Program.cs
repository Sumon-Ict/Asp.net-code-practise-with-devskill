using Classes.WaterBottleExample;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jalaluddin = new Person("Jalal uddin");
            jalaluddin.Name = "Jalal Uddin";
            jalaluddin.weight = 75.5;
            jalaluddin.height = 5.11;
            jalaluddin.Walk();

            Person hasan = new Person();
            hasan.Name = "Hasan Ahmed";
            hasan.height = 5.9;
            hasan.weight = 65.9;
            hasan.Walk(10, 50);

            var x = hasan.Name;


            var products = new Product[10];

            var aBook = new Book();
            aBook.Name = "C# programming";
            aBook.Description = "Something";
            aBook.Price = 125;
            aBook.Author = "M. Steve";

            var anElectronics = new Electronics();
            anElectronics.Name = "Camera";
            anElectronics.Description = "Smart DSLR";
            anElectronics.Price = 50000.3456;
            anElectronics.BrandName = "Cannon";

            products[0] = aBook;
            products[1] = anElectronics;

            //var bookAgain = (Book)products[0];

            //Console.WriteLine(bookAgain.Author);

            //object o = jalaluddin;
            //Book p = o as Book;

            Print(aBook);
            Print(anElectronics);

            var bottle1 = new JuiceBottle(200, "red");
            var capacity = bottle1.CurrentAmount;

            var bottle2 = new JuiceBottle(200, "blue", 100);
            var capacity2 = bottle2.CurrentAmount;
        }

        static void Print(Product product)
        {
            Console.WriteLine($"Name = {product.Name}");
            Console.WriteLine($"Description = {product.Description}");
            Console.WriteLine($"Price = {product.FormatPrice()}");
            Console.WriteLine($"Discount = {product.CalculateDiscount()}");

            if(product is Book)
            {
                var book = product as Book;
                Console.WriteLine($"Author = {book.Author}");
            }
            else if(product is Electronics)
            {
                var electronics = product as Electronics;
                Console.WriteLine($"BranName = {electronics.BrandName}");
            }
        }
    }
}
