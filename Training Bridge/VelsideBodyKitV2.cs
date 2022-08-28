using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_second_example
{
    public class VelsideBodyKitV2 : IBodyKit
    {
        public void FrontBumper()
        {
            Console.WriteLine("Front bumper V2 from Velside");
        }

        public void RearBumper()
        {
            Console.WriteLine("Rear bumper V2 from Velside");
        }

        public void SideSkirts()
        {
            Console.WriteLine("Side skirts V2 from Velside");
        }
    }
}
