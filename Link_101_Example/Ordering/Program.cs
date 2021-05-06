using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordering
{

    public class IncasesentiveCom:IComparer<string>
    {
        public int Compare(string x, string y) => 
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);

    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "sumon", "kajol", "suvo", "arman" };

            var sq = names.OrderBy(a => a, new IncasesentiveCom());

            foreach(var i in sq)
            {
                Console.WriteLine(i);

            }

            var sq2 = names.OrderBy(a => a.Length).ThenBy(a => a, new  IncasesentiveCom());

            foreach(var i in sq2)
            {
                Console.WriteLine(i);

            }

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sq3 = (from digit in digits
                      where digit[1] == 'i'
                      select digit).Take(2);
            foreach(var i in sq3)
            {
                Console.WriteLine(i);

            }



            var sq4 = sq3.Reverse();

            foreach(var i in sq4)
            {
                Console.WriteLine(i);

            }


            int[] numbers = { 23,7, 45, 90, 76, 2,4,5, 34, 56 };

            var num = numbers.Take(3);

            foreach(var i in num)
            {
                Console.WriteLine(i);
            }


            var num1 = numbers.Skip(5);

            foreach(var i in num1)
            {
                Console.WriteLine(i);

            }

            var num3 = numbers.TakeWhile(n => n > 3);

               
            foreach(var i in num3)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("query4 ");

            var num4 = numbers.TakeWhile((n, index) => n >= index);

            foreach(var i in num4)
            {
                Console.WriteLine(i);

            }


            var num5 = from n in numbers   //adding 10  with each number 
                       select n + 10;
            foreach(var i  in num5)
            {
                Console.WriteLine(i);

            }

            int[] number = { 3, 4, 5, 1, 0, 2, 6 };
            string[] day = { "saterday", "monday", "sunday", "tuesday", "wednesday", "thursday", "Friday" };

            var sq12 = from n in number
                       select day[n];

            foreach(var i in sq12)
            {
                Console.WriteLine(i);

            }

            var upperlowercase = from d in day
                                 select new { Upper = d.ToUpper(), Lower = d.ToLower() };


            foreach(var info in upperlowercase)
            {
                Console.WriteLine($"uppercase : {info.Upper}, lowercase: {info.Lower}");  

            }

            var Upperlower = from d in day
                             select (Upper: d.ToUpper(), lower: d.ToLower());      // same work previous declaration 
            foreach(var info in Upperlower)
            {
                Console.WriteLine($"upperrcase: {info.Upper}, lowercase: {info.lower}");

            }

            var sq7 = from n in number
                      select new { digit = day[n], even=(n%2==0) };
            foreach(var i in sq7)
            {
                Console.WriteLine(i.digit);

                Console.WriteLine($" {i.digit}, {(i.even ? "even":"odd")}");
            }

            int[] numb = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            var sq8 = from n in numb
                      select (digit: strings[n], even: (n % 2 == 0));
            foreach(var info in sq8)
            {
                Console.WriteLine($"digit :{ info.digit}, {(info.even ? "even" : "odd")}");

            }


            var sq9 = numb.Select((n, index) => (Num: n, inplace: (n == index)));

            foreach(var i in sq9)
            {
                Console.WriteLine($"num: {i.Num}  inplace: {i.inplace}");

            }

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var sq13 = from a in numbersA
                       from b in numbersB
                       where a < b
                       select new { v1=a,v2=b };

            
                     


            foreach(var info in sq13)
            {
                Console.WriteLine($"valuea {info.v1}  secondv: {info.v2}");

            }


            string[] words = { "believe", "relief", "receipt", "field" };

            bool value = words.Any(w => w.StartsWith("re"));

            Console.WriteLine(value);

            int[] numbers1 = { 1, 11, 3, 19, 41, 65, 19 };

            var value2 = numbers.All(n => n % 2 == 1);
            Console.WriteLine(value2);

            var value3 = numbers1.Any(n => n % 2 == 0);

            Console.WriteLine(value3);

            var j = 0;
            var q = (from n in numbers1
                    select ++j).ToList();
            foreach(var i in q)
            {
                Console.WriteLine(i);

            }
            string[] digits2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sq16 = digits2.Where((digit, index) => digit.Length < index);

            foreach(var info in sq16)
            {
                Console.WriteLine(info);

            }

            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine(match);
            int[] numbersA1 = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB1 = { 1, 3, 5, 7, 8 };

            var allnumber = numbersA1.Union(numbersB1);

            foreach(var i in allnumber)
            {
                Console.WriteLine(i);

            }
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotproduct=vectorA.Zip(vectorB,(a,b)=>a*b).Count();

            Console.WriteLine(dotproduct);

            var disticvaluecount = vectorB.Distinct().Count();

            double[] arr = { 34.5, 90.98, 23, 23, 45, 45, 67.98 };

            var distinctvalue = arr.Distinct();

            foreach(var v in distinctvalue)
            {
                Console.WriteLine(v);

            }

            Console.WriteLine(disticvaluecount);

            var unionoperation = vectorA.Union(vectorB);

            foreach(var v in unionoperation)
            {
                Console.WriteLine(v);

            }


            var commonnumber = vectorA.Intersect(vectorB);

            foreach(var v in commonnumber)
            {
                Console.WriteLine(v);

            }

            int[] numbersA11 = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB11 = { 1, 3, 5, 7, 8 };

            var exceptvalue = numbersA11.Except(numbersB11);

            foreach(var v in exceptvalue)
            {
                Console.WriteLine(v);

            }

            Console.WriteLine("odd number");

            var oddnumber = numbersB11.Count(n => n % 2 == 1);
            var evennumber = numbersB11.Count(n => n % 2 == 0);

            Console.WriteLine(evennumber);

            Console.WriteLine(oddnumber);

            double sumnum = numbersB11.Sum();

            Console.WriteLine(sumnum);


            var smallnum = numbersA11.Min();

            Console.WriteLine(smallnum);

            string[] districts = { "kushtia", "bogura", "pabna", "rajshahhi", "rangpur" };
            var shortlenthdis = districts.Min(w => w.Length);

            Console.WriteLine($"short lenth district is {shortlenthdis}");

            var aveagelenthdis = districts.Average(w => w.Length);

            Console.WriteLine(aveagelenthdis);

            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var product = doubles.Aggregate((runningproduct, nextnumber) => runningproduct * nextnumber);

            Console.WriteLine(product);

            var numbersum = doubles.Aggregate((runningsum, nextvalue) => runningsum + nextvalue);

            Console.WriteLine($"the array sum is {numbersum}");



            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };
            var endbalance = attemptedWithdrawals.Aggregate(startBalance, (balance, nextwithdraw) => (nextwithdraw <= balance) ? (balance - nextwithdraw) : balance);

            Console.WriteLine($"ending balance is {endbalance}");


            int[] numbers12 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var sq21 = from n in numbers12
                       group n by n % 5 into g 

                       select (remainder: g.Key,numbers:g);

                    
            foreach(var v in sq21)
            {
                Console.WriteLine($"key value: {v.remainder}");

               foreach(var v1 in v.numbers)
                {
                    Console.WriteLine(v1);

                }

            }

            string[] words12 = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var sq22 = from w in words12
                       group w by w[0] into g
                       select (firstletter: g.Key, words: g);

            foreach(var w in sq22)
            {
                Console.WriteLine(w.firstletter);

                foreach(var w1 in w.words)
                {
                    Console.WriteLine(w1);

                }
            }
































































        }
    }
}
