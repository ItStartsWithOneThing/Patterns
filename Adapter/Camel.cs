using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel walking by the sand dune");
        }
    }
}
