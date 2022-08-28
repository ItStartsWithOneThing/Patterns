using System;

namespace Strategy_second_example
{
    public class Excavator : IHoleDigging
    {
        public void MakeHole()
        {
            Console.WriteLine("Take control of the excavator and rapidly fast dig a big hole");
        }
    }
}
