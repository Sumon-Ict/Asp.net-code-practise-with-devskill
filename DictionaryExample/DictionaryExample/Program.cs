using System;
using System.Collections.Generic;
namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> datas = new Dictionary<int, string>();

            datas.Add(12, "sumon");
            datas.Add(23, "sujon");
            datas.Add(21, "kajol");

            foreach(KeyValuePair<int,string>k in datas)
            {
                Console.WriteLine($"key :{k.Key}  keyvalue: {k.Value}");

            }

            Dictionary<int, string>.KeyCollection keyval = datas.Keys;

            foreach(var k in keyval)
            {
                Console.WriteLine(k);

            }
            Dictionary<int, string>.ValueCollection values = datas.Values;

            foreach(var v in values)
            {
                Console.WriteLine($"value : {v}");

            }

            string[] input = { "sumon", "sujon", "sohaj" };


            List<string> names = new List<string>(input);

            foreach(var s in names)
            {
                Console.WriteLine(s);
            }


           
        }
    }
}
