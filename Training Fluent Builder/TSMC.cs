using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_Builder_second_example
{
    public class TSMC // DIRECTOR
    {
        ILaptopBuilder laptopBuilder { get; set; }

        public TSMC(ILaptopBuilder builder)
        {
            laptopBuilder = builder;
        }

        public void Build()
        {
            laptopBuilder.CreateLaptop().SetModel().SetOS().SetCost(); // FLUENT
        }
    }
}
