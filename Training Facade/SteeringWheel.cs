using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_second_example
{
    public class SteeringWheel // Subsystem
    {
        public void Bend()
        {
            Console.WriteLine("Wheel is bending");
        }

        public void Straight()
        {
            Console.WriteLine("Stabilizing a car");
        }
    }
}
