using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang) : base(lang)
        {
            Lang = lang;
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Get money at the end of month");
        }
    }
}
