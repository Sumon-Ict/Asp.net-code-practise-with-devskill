using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Examples.Collections.ComparerExample
{
    public class ComparerExampleRunner
    {
        public string Name => nameof(ComparerExampleRunner);

        public void Run()
        {
            // Creates the strings to compare.
            var str1 = "llegar";
            var str2 = "lugar";
            Console.WriteLine("Comparing \"{0}\" and \"{1}\" ...", str1, str2);

            // Uses the DefaultInvariant Comparer.
            Console.WriteLine("   Invariant Comparer: {0}", Comparer.DefaultInvariant.Compare(str1, str2));

            // Uses the Comparer based on the culture "es-ES" (Spanish - Spain, international sort).
            var myCompIntl = new Comparer(new CultureInfo("es-ES", false));
            Console.WriteLine("   International Sort: {0}", myCompIntl.Compare(str1, str2));

            // Uses the Comparer based on the culture identifier 0x040A (Spanish - Spain, traditional sort).
            var myCompTrad = new Comparer(new CultureInfo(0x040A, false));
            Console.WriteLine("   Traditional Sort  : {0}", myCompTrad.Compare(str1, str2));
        }
    }
}
