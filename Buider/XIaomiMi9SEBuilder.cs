using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class XIaomiMi9SEBuilder : SmartPhoneBuilder
    {
        public override SmartPhone GetSmartPhone()
        {
            return this.SmartPhone;
        }

        public override void SetBattery()
        {
            this.SmartPhone.Battery = new Battery(3080);
        }

        public override void SetFrontCamera()
        {
            this.SmartPhone.AddCameras(new FrontCamera(12, 2.0));
        }

        public override void SetMacroCamera()
        {
            
        }

        public override void SetMainCamera()
        {
            this.SmartPhone.AddCameras(new MainCamera(12, 2.0));
        }

        public override void SetNFC()
        {
            this.SmartPhone.NFC = true;
        }

        public override void SetOS()
        {
            this.SmartPhone.OS = new OS("Android", 10.0M);
        }

        public override void SetPortraitCamera()
        {
            this.SmartPhone.AddCameras(new PortraitCamera(8, 2.2));
        }

        public override void SetUltraWideCamera()
        {
            this.SmartPhone.AddCameras(new FrontCamera(8, 2.0));
        }
    }
}
