using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class XiaomiMi6PhoneBuilder : SmartPhoneBuilder // Concrete SmartPhone Builder
    {
        public override void SetBattery()
        {
            this.SmartPhone.Battery = new Battery(3350);
        }

        public override void SetFrontCamera()
        {

            this.SmartPhone.AddCameras(new FrontCamera(8, 2.2));
        }

        public override void SetMainCamera()
        {

            this.SmartPhone.AddCameras(new MainCamera(12, 1.8));
        }

        public override void SetUltraWideCamera()
        {
        }

        public override void SetMacroCamera()
        {
        }

        public override void SetPortraitCamera()
        {

            this.SmartPhone.AddCameras(new MainCamera(8, 2.2));
        }

        public override void SetNFC()
        {
            this.SmartPhone.NFC = true;
        }

        public override void SetOS()
        {
            this.SmartPhone.OS = new OS("Android", 9.0m);
        }

        public override SmartPhone GetSmartPhone()
        {
            return this.SmartPhone;
        }
    }
}
