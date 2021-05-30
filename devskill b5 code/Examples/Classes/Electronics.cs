using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Electronics : Product
    {
        public string BrandName { get; set; }

        public override double CalculateDiscount()
        {
            return _price * 25 / 100.0;
        }
    }
}
