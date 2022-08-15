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

        public void QuerySyntax()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            IEnumerable<string> query = from name in names where name.Contains("a") orderby name.Length select name.ToUpper();


            IEnumerator quers = query.GetEnumerator();

            while (quers.MoveNext())
            {
                Console.WriteLine(quers.Current);
            }



            //from n in names // n is our range variable
            //where n.Contains("a") // n = directly from the array
            //orderby n.Length // n = subsequent to being filtered
            //select n.ToUpper() // n = subsequent to being sorted

        }

        public void MixedQuery()
        {

            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };


            int length = (from n in names where n.Contains("a") select n).Count();

            Console.WriteLine(length);

            string name = (from n in names orderby n select n).First();

            Console.WriteLine(name );
        }


        public void DefferExecution()
        {
            var numbers = new List<int> { 1};

            IEnumerable<int> query = numbers.Select(n => n*10);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(5);


            IEnumerator num  = query.GetEnumerator();

            while (num.MoveNext())
            {
                Console.WriteLine(num.Current+"|");
            }

        }

        public void DefferAndMixedQuery()
        {

            var numbers = new List<int> { 2, 3, 4, 5, 6, 7 };

            List<int> temItems = numbers.Select(x => x * 5).ToList();


            IEnumerator tem = temItems.GetEnumerator();

            while (tem.MoveNext())
            {
                Console.WriteLine(tem.Current);
            }

        }
    }
}
