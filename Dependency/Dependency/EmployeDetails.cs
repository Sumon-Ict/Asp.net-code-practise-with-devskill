using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    public class EmployeDetails : IEmployeeDetail
    {
        public List<Employee> SetAllEmplyee()
        {
            List<Employee> employeelist = new List<Employee>();
           employeelist.Add(new Employee() { Id = 12, Name = "sumon", home = "bogura" });
            employeelist.Add(new Employee() { Id = 23, Name = "kajol", home = "kajol" });


            return SetAllEmplyee();

        }
    }
}
