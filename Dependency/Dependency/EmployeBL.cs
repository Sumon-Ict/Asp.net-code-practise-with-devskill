using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
   public  class EmployeBL
    {

        public IEmployeeDetail _employedetail;

       public EmployeBL(IEmployeeDetail employeedetail)
        {
            _employedetail = employeedetail;

        }
        public List<Employee>getallemployee()
        {
          return  _employedetail.SetAllEmplyee();

        }



    }
}
