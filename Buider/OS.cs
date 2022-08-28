using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class OS
    {
        public OS(string name, decimal version)
        {
            Name = name;

            Version = version;
        }

        public string Name { get; set; }

        public decimal Version { get; set; }
    }
}
