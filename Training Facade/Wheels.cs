using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_second_example
{
    public class Wheels // Subsystem
    {
        public void Drifting()
        {
            Console.WriteLine("Front wheels are bending when rare wheels are only spinning, and car is sliding on a concrete");
        }

        public void DragRacing()
        {
            Console.WriteLine("Car moving afap to finish");
        }
    }
}
