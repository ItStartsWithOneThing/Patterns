using System;

namespace Builder
{
    public class Fabric
    {
        public PhoneBuilder phoneBuilder { get; set; }

        public Fabric(PhoneBuilder _phoneBuilder)
        {
            phoneBuilder = _phoneBuilder;
        }

        
        public void Build()
        {
            phoneBuilder.CreatePhone();

            phoneBuilder.SetModel();

            phoneBuilder.SetCamera();

            phoneBuilder.SetOS();
        }
    }
}
