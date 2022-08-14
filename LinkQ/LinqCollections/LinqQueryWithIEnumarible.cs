using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ.LinqCollections
{
    internal class LinqQueryWithIEnumarible
    {
        public void LinqQuery()
        {
            List<string> Names = new List<string>() { "kamal", "jamal", "tomal", "damal" };


            IEnumerable<string> Names2 =  Enumerable.Where(Names, x => x.Length > 0);

            // all so we can use  another way Linkq Query 

            //IEnumerable<string> nameStr = Names.Where(x => x.Length > 0).OrderBy(n => n.Length);
            IEnumerable<string> nameStr = Names.Where(x => x.Length > 0).OrderBy(n => n.Length).Select(x => x.ToUpper());
            foreach(var item in nameStr)
            {
                Console.WriteLine(item);
            }

            //foreach(var item in Names2)
            //{
            //    Console.WriteLine(item);
            //}




        }


        public void LinkqFiltering()
        {

            List<string> strings = new List<string>() { "bangaldehs", "india", "Pakistan", "america" };
            IEnumerable<string> filter = strings.Where(x => x.Contains("a"));
            IEnumerable<string> sorted = filter.OrderBy(x => x.Length > 0);
            IEnumerable<string> finalQuery = sorted.Select(x => x.ToLower());


            IEnumerator enumerator = finalQuery.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
  
            }
       
        }

        public void OtherOperations()
        {
            int[] numbers = { 10, 9, 8, 7, 6 };

            int firstNaumber = numbers.First();
            int lastNaumer = numbers.Last();
            int secondNumber = numbers.ElementAt(1);

            int secondLowestNumber = numbers.OrderBy(x => x).Skip(1).First();
        }


        public void UnionConcat()
        {
            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };

            IEnumerable union = seq1.Union(seq2); // { 1, 2, 3, 4, 5 }
            IEnumerable concat = seq1.Concat(seq2); // { 1, 2, 3, 3, 4, 5 }
        }
    }
}
