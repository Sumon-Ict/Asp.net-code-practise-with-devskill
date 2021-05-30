using System;
using System.Collections.Generic;
using System.Text;

namespace Answer2
{
    public class JolyNumber
    {
        public int Number { get; protected set; }

        public JolyNumber()
        {
            Number = 0;
        }

        public JolyNumber(int number)
        {
            Number = number;
        }

        public virtual void Increment()
        {
            Number++;
        }

        public void Increment(int n)
        {
            Number += n;
        }
    }
}
