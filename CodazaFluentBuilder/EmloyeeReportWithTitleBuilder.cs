using System;
using System.Collections.Generic;

namespace Fluent_Builder
{
    class EmloyeeReportWithTitleBuilder : EmployeeReportBuilder, IEmployeeReportWithTitleBuilder
    {
        public EmloyeeReportWithTitleBuilder(IEnumerable<Employee> employees) : base(employees)
        {
           
        }
        public IEmployeeReportWithTitleBuilder BuildTitle()
        {
            _employeeReport.Title =
                  "TITLE\n";

            _employeeReport.Title =
                  $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";

            _employeeReport.Title +=
                "\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }
    }
}
