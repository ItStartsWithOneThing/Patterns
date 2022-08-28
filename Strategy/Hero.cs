using System;

namespace Strategy
{
    public class Hero
    {
        private string name { get; set; }

        private IWeapon weapon { get; set; }
 

        public Hero(string _name)
        {
            name = _name; 
        }

        public Hero(string _name, IWeapon _weapon)
        {
            name = _name;

            weapon = _weapon;
        }

        public void SetWeapon(IWeapon _weapon)
        {
            weapon = _weapon;
        }

        public void Attack()
        {
            if(weapon == null)
            {
                Console.WriteLine("There is no weapon");
                return;
            }

            weapon.Fire();
        }
    }
}
