using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.ISP
{
    public class Duck : IFlyable, ISwimable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
