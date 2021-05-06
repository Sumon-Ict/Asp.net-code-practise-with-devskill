using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class person
    {

        private string N;
        public double weight;
        public int age;
        public string gender;

        private double heihgt;
        private string dres;


        public string D
        {
            get
            {
                return dres;
            }
            set
            {
                dres = value;
            }
        }





        public double H
        {
            get
            {
                return heihgt;
            }
            set
            {
                if (heihgt > 0)
                
                heihgt = value;
            }
        }

        #region constructor 
        public person()
        {

        }
        public person(string Name)
        {
            this.N = Name;

        }
        #endregion

        public void result()
        {
            var r = weight * age;
            Console.WriteLine(r);

        }

       public string blabla
        {
            get
            {
                return N;
            }
            set
            {
                N = value;
            }
        }



    }
}
