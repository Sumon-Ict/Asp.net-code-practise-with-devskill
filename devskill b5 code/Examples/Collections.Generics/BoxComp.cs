using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Collections.Generics
{
    public class BoxComp : IComparer<Box>
    {
        // Compares by Height, Length, and Width.
        public int Compare(Box x, Box y)
        {
            if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            else if (x.Length.CompareTo(y.Length) != 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            else if (x.Width.CompareTo(y.Width) != 0)
            {
                return x.Width.CompareTo(y.Width);
            }
            else
            {
                return 0;
            }
        }
    }
}
