using System;

namespace Adapter
{
    public class Driver
    {
        public string Name { get; set; }

        public void Travel(ITransport auto)
        {
            auto.Drive();
        }
    }
}
