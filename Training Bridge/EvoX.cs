using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_second_example
{
    public class EvoX : Car
    {
        public EvoX(string model) : base(model)
        {
            Model = model;
        }

        public EvoX(string model, IBodyKit body) : base(model, body)
        {
            Model = model;
            Body = body;
        }
        public override void SetFrontBumper()
        {
            Body.FrontBumper();
        }

        public override void SetRearBumper()
        {
            Body.RearBumper();
        }

        public override void SetSideSkirts()
        {
            Body.SideSkirts();
        }
    }
}
