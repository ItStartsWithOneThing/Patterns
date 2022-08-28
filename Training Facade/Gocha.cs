using System;

namespace Facade_second_example
{
    public class Gocha // Client
    {
        public void WinDriftRace(SilviaS15Facade car)
        {
            car.MakeDrift();
        }

        public void WinDragRace(SilviaS15Facade car)
        {
            car.MakeDrag();
        }
    }
}
