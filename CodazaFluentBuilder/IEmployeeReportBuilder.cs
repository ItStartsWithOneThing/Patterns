﻿namespace Fluent_Builder
{
    public interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuildHeader();

        IEmployeeReportBuilder BuildBody();

        IEmployeeReportBuilder BuildFooter();

        EmployeeReport GetReport();
    }
}
