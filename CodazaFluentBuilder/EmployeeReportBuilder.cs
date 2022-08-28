﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Fluent_Builder
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        protected EmployeeReport _employeeReport;

        protected readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new EmployeeReport();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header =
                $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";

            _employeeReport.Header +=
                "\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                    _employees.Select(e =>
                    $"Employee: {e.Name}\t\tSalary: {e.Salary}$"));

            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer =
                "\n----------------------------------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\nTOTAL EMPLOYEES: {_employees.Count()}, " +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new EmployeeReport();

            return employeeReport;
        }
    }
}
