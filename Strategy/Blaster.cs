using System;

namespace Strategy
{
    public class Blaster : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Shooting from BLAZZZZTER");
        }
    }
}
