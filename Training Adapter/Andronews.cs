using System;

namespace Training_Adapter
{
    public class Andronews
    {
        public void MakePurchase(IPhone phone)
        {
            phone.Pay();
        }
    }
}
