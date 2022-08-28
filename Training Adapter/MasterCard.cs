using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Adapter
{
    class MasterCard : IBankCard
    {
        public void Payment()
        {
            Console.WriteLine("Paying through terminal");
        }
    }
}
