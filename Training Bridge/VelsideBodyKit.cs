using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_second_example
{
    public class VelsideBodyKit : IBodyKit
    {
        public void FrontBumper()
        {
            Console.WriteLine("Front bumper from Velside");
        }

        public void RearBumper()
        {
            Console.WriteLine("Rear bumper from Velside");
        }

        public void SideSkirts()
        {
            Console.WriteLine("Side skirtss from Velside");
        }
    }
}
