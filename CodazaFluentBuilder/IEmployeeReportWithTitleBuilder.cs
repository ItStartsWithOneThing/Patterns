using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_Builder
{
    interface IEmployeeReportWithTitleBuilder : IEmployeeReportBuilder
    {
        IEmployeeReportWithTitleBuilder BuildTitle();
    }
}
