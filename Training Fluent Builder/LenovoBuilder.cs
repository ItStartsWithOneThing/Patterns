using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_Builder_second_example
{
    public class LenovoBuilder : ILaptopBuilder // CONCRETE BUILDER
    {
        protected Laptop laptop { get; set; }

        public ILaptopBuilder CreateLaptop()
        {
            laptop = new Laptop();

            return this;
        }

        public Laptop GetLaptop()
        {
            if(laptop != null)
            {
                return laptop;
            }

            else
            {
                return null;
            }
        }

        public ILaptopBuilder SetCost()
        {
            laptop.Cost = 999;

            return this;
        }

        public ILaptopBuilder SetModel()
        {
            laptop.Model = "Z50-70";

            return this;
        }

        public ILaptopBuilder SetOS()
        {
            laptop.OS = "Windows 10";

            return this;
        }
    }
}
