using System.Text;

namespace Fluent_Builder
{
    public class EmployeeReport
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public string Title { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .Append(Title)
            .ToString();
    }
}
