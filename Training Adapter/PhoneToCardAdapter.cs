using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Adapter
{
    public class PhoneToCardAdapter : IPhone
    {
        IBankCard card;

        public PhoneToCardAdapter(IBankCard _card)
        {
            card = _card;
        }

        public void Pay()
        {
            card.Payment();
        }
    }
}
