using System;
using System.Collections.Generic;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeBL employeBL = new EmployeBL(new EmployeDetails());
            List<Employee> employees = employeBL.getallemployee();

            foreach(var i in employees)
            {
                Console.WriteLine($" id={i.Id} name:{i.Name}, home:{i.home}");

            }


        }
    }
}
