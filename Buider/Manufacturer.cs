using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Manufacturer // Director
    {
        SmartPhoneBuilder builder;

        public Manufacturer(SmartPhoneBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.CreateSmartPhone();
            builder.SetBattery();
            builder.SetFrontCamera();
            builder.SetMacroCamera();
            builder.SetMainCamera();
            builder.SetPortraitCamera();
            builder.SetUltraWideCamera();
            builder.SetNFC();
            builder.SetOS();
        }

    }
}
