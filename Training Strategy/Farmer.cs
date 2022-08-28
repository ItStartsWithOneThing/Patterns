using System;

namespace Strategy_second_example
{
    public class Farmer
    {
        IHoleDigging digger { get; set; }

        public Farmer(IHoleDigging dig)
        {
            digger = dig;
        }

        public void DigHole()
        {
            digger.MakeHole();
        }
    }
}
