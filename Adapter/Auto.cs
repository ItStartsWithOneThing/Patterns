using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Wehicle is driving by the road");
        }
    }
}
