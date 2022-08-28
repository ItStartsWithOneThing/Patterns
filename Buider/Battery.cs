using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Battery
    {
        public Battery(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }
    }
}
