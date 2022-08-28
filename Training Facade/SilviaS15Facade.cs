using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_second_example
{
    public class SilviaS15Facade // Facade
    {
        Engine2jz engine { get; set; }

        Wheels wheels { get; set; }

        SteeringWheel steeringWheel { get; set; }

        public SilviaS15Facade(Engine2jz _engine, Wheels _wheels, SteeringWheel _steeringWheel)
        {
            engine = _engine;
            wheels = _wheels;
            steeringWheel = _steeringWheel;
        }

        public void MakeDrift()
        {
            engine.Work();
            wheels.Drifting();
            steeringWheel.Bend();
        }

        public void MakeDrag()
        {
            engine.Work();
            wheels.DragRacing();
            steeringWheel.Straight();
        }
    }
}
