using System;

namespace Fluent_Builder_second_example
{
    public interface ILaptopBuilder // INTERFACE INSTEAD OF ABSTRACT CLASS
    {
        ILaptopBuilder CreateLaptop();

        ILaptopBuilder SetOS();

        ILaptopBuilder SetModel();

        ILaptopBuilder SetCost();

        Laptop GetLaptop();
    }
}
