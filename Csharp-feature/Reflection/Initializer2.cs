using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
  public class Initializer2
    {


        public Initializer2()     //empty constructor 
        {

        }

        public Initializer2(int n)   //parameterized cosntructor 
        {

        }
        public void InitStartup()
        {
            Console.WriteLine("starting from initilizeer set up 2");
        }

        public void printmethod()
        {
            Console.WriteLine("initializer 2 printmethod calling");

        }
    }
}
