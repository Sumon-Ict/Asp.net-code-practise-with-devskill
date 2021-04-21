using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_feature
{
   public class DelegateExample
    {
        public int area(int height,int width)
        {
            return height * width;

        }

        public double volume(int h,int w,int length)
        {
            return h * w * length;
        }

        public void stringmethod(string s)
        {
            Console.WriteLine("my name is {0}", s);

        }


    }
}
