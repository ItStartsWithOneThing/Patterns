using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_second_example
{
    public class Shovel : IHoleDigging
    {
        public void MakeHole()
        {
            Console.WriteLine("Take Shovel and dig it manualy and slowly");
        }
    }
}
