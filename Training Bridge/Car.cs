using System;

namespace Bridge_second_example
{
    public abstract class Car
    {
        protected IBodyKit Body {get;set;}
        public string Model { get; set; }



        public Car(string model)
        {
            Model = model;
        }

        public Car(string model, IBodyKit body)
        {
            Model = model;
            Body = body;
        }

        public virtual void SetBodyKit(IBodyKit body)
        {
            Body = body;
        }

        public abstract void SetFrontBumper();

        public abstract void SetSideSkirts();

        public abstract void SetRearBumper();
    }
}
