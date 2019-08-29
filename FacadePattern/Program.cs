using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee() { Name = "Robert" };
            var hrOfficer = new HumanResourcesOfficer();
            hrOfficer.StartNewEmployeeProcess(employee);

            Console.ReadKey();
        }
    }
}
