using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewFeature
{
    public class ClassB : ClassA
    {

        public ClassB()
        {
            Name = "md sujon mia";

            var c = new classC();
            c.add = "bogura";

            Console.WriteLine(c.add);

        }
        
        public  class classC
        {
            public string add { get; set; }
        }

    }
}
