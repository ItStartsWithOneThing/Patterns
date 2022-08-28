using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Adapter
{
    public class GooglePixel : IPhone
    {
        public void Pay()
        {
            Console.WriteLine("Paying through Google Pay");
        }
    }
}
