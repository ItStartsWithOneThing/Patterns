using System;

namespace Facade
{
    public class Cashier // Facade
    {
        CookOfHamburger _hamb { get; set; }

        CookOfFries _fries { get; set; }

        CookOfDrink _drink { get; set; }

        public Cashier(CookOfHamburger hamb, CookOfFries fries, CookOfDrink drink)
        {
            _hamb = hamb;

            _fries = fries;

            _drink = drink;
        }


        public void MakeHamburgerMenu()
        {
            Console.WriteLine("Taking order\n");

            _hamb.CookHaburger();

            _fries.CookFries();

            _drink.PourDrink();

            Console.WriteLine(new string('-', 20) + "\n");
        }

        public void IssueAnOrder()
        {
            _hamb.PackHamburger();

            _fries.PackFries();

            _drink.PackDrink();

            Console.WriteLine("Delivering to the Customer");
        }
    }
}
