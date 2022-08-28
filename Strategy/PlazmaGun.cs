using System;

namespace Strategy
{
    public class PlazmaGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Shooting from PLAZZZZMA GOOOOOON");
        }
    }
}
