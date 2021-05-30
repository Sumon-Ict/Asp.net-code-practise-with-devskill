using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractClass
{
    public class Doel : IAnimal, IFlyable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
