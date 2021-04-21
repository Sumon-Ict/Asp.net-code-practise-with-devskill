using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
   public class Initializer1
    {

        public Initializer1()   //empty constructor 
        {

        }
        public Initializer1(int n)   //parameterized constructor 
        {

        }
        public void InitStartup()
        {
            Console.WriteLine("stating from initializer set up 1");
        }

        public void printmethod()
        {
            Console.WriteLine("initilizer 1 printmethod calling ");

        }
    }
}
