using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class SystemAdministrator
    {
        public void GrantNewEmployeeAccess(Employee employee)
        {
            Console.WriteLine($"{employee.Name} security access granted");
        }
    }
}
