using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.WaterBottleExample
{
    public class JuiceBottle : Bottle
    {
        private string Pipe { get; set; }
        private string Belt { get; set; }
        public JuiceBottle(int capacity, string color, int amount) 
            : base(capacity, color, amount)
        {
        }

        public JuiceBottle(int capacity, string color)
            : this(capacity, color, 0)
        {
        }
    }
}
