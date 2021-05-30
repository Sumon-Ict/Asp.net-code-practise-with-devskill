using System;
using System.Collections.Generic;
using System.Text;

namespace SealedClassExample
{
    public class Member : Person
    {
        public sealed override void Vote()
        {
            base.Vote();
        }
    }
}
