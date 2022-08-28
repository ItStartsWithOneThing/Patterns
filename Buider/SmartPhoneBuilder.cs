using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class SmartPhoneBuilder // SmartPhone abstract Builder
    {
        public SmartPhone SmartPhone { get; private set; }

        public void CreateSmartPhone()
        {
            SmartPhone = new SmartPhone();
        }

        public abstract void SetFrontCamera();

        public abstract void SetMainCamera();

        public abstract void SetUltraWideCamera();

        public abstract void SetMacroCamera();

        public abstract void SetPortraitCamera();

        public abstract void SetBattery();

        public abstract void SetOS();

        public abstract void SetNFC();

        public abstract SmartPhone GetSmartPhone();
    }
}
