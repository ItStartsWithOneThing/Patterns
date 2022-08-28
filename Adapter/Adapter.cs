using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterTransportToAnimal : ITransport
    {
        IAnimal Animal { get; set; }

        public AdapterTransportToAnimal(IAnimal animal)
        {
            Animal = animal;
        }

        public void Drive()
        {
            Animal.Move();
        }
    }
}
