using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class FinancialOfficer
    {
        public void PrepareNewEmployeeFinances(Employee employee)
        {
            Console.WriteLine($"{employee.Name} finances are ready");
        }
    }
}
