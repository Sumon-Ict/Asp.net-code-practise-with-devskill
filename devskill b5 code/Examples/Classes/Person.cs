using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        // public, internal, protected, private
        private string name;
        public double weight;
        public double height;
        private double speed;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value != "")
                    name = value;
            }
        }

        public Person()
        {
            name = "";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void Walk()
        {
            speed = 10;
        }

        // 50, 10
        public void Walk(double speed, int maxSpeed)
        {
            this.speed = speed > maxSpeed ? maxSpeed : speed;
        }

        public void Walk(int speed)
        {
            this.speed = speed;
        }
    }
}
