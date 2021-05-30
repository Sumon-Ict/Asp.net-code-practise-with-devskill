using System.Collections;

namespace Examples.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[20];
            ages = new int[30];

            object x = 5; // boxing
            x = "hello";
            x = 23.4;
            x = true;

            bool y = (bool)x; // unboxing

            ArrayList names = new ArrayList();
            names.Add("jalaluddin");
            names.Add("rashed");
            names.Add(23);

            string name1 = (string)names[0];

            Hashtable codes = new Hashtable();
            codes.Add("item1", "abc");
            codes.Add("item2", "def");

            ArrayList a; // -> List
            BitArray b; //
            Hashtable h; // -> Dictionary
            Queue q; // -> Queue
            SortedList sl; // -> SortedList
            Stack s; // -> Stack
        }
    }
}
