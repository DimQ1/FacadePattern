using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class HumanResourcesOfficer
    {
        private FinancialOfficer financialOfficer;
        private SystemAdministrator systemAdministrator;
        private OfficerAdministrator officerAdministrator;

        public HumanResourcesOfficer()
        {
            this.financialOfficer = new FinancialOfficer();
            this.officerAdministrator = new OfficerAdministrator();
            this.systemAdministrator = new SystemAdministrator();
        }

        public void StartNewEmployeeProcess(Employee employee)
        {
            this.financialOfficer.PrepareNewEmployeeFinances(employee);
            this.officerAdministrator.PrepareNewEmployeeOfficer(employee);
            this.systemAdministrator.GrantNewEmployeeAccess(employee);
            Console.WriteLine($"{employee.Name} papers are prepared an ready to start!");
        }
    }
}
