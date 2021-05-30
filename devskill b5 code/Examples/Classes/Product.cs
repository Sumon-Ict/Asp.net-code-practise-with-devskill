using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    _price = 0;
                else
                    _price = value;
            }
        }

        // Overriding

        public virtual string FormatPrice()
        {
            return $"Taka: {_price.ToString("0.000")}";
        }

        public virtual double CalculateDiscount()
        {
            return _price * 15 / 100.0;
        }
    }
}
