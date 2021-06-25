using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
   public class Room:IData
    {
        public int Id { get; set; }
        public double Rent { get; set; }

        public void date()
        {
            Console.WriteLine(DateTime.Now.ToString());


        }

        public void displayName()
        {
            Console.WriteLine("my name is sumon");

        }


    }
}
