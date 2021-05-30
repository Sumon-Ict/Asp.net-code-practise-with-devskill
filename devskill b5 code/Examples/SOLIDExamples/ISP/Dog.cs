using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.ISP
{
    public class Dog : ISwimable
    {
        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
