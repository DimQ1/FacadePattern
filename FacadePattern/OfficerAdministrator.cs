using System;

namespace FacadePattern
{
    public class OfficerAdministrator
    {
        public void PrepareNewEmployeeOfficer(Employee employee)
        {
            Console.WriteLine($"{employee.Name} office is ready");
        }
    }
}