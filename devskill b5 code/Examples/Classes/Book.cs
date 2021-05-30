using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Book : Product
    {
        public string Author { get; set; }

        public override string FormatPrice()
        {
            return $"Tk. {_price}";
        }
    }
}
