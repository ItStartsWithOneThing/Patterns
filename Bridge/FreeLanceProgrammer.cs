using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class FreeLanceProgrammer : Programmer
    {
        public FreeLanceProgrammer(ILanguage lang): base (lang)
        {
            Lang = lang;
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Recieving money after task is completed");
        }
    }
}
