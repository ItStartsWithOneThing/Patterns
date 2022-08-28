using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Mi6Builder : PhoneBuilder
    {
        public override Phone GetPhone()
        {
            return this.phone;
        }

        public override void SetCamera()
        {
            phone.Camera = 12;
        }

        public override void SetModel()
        {
            phone.Model = "Xiaoi Mi 6";
        }

        public override void SetOS()
        {
            phone.OS = "Android 9";
        }
    }
}
