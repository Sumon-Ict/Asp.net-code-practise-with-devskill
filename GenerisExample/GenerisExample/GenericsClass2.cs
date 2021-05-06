using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerisExample
{
   public  class GenericsClass2<T>
    {

       // public string[] names;

        public T[] array;

        public GenericsClass2(int size)
        {
             array = new T[size+1];     //names=new string[size];

        }

        /*
        public void setnames(int index,string value)
        {
            names[index] = value;
        }

        public  string getnames(int index)
        {

        return names[index];

        }
        
         
         */

        public void setvalue(int index,T value)       
        {
            //names[index] = value;
            array[index] = value;
        }

        public T getvalue(int index)
        {
            return array[index];   //return names[index]

        }


    }
}
