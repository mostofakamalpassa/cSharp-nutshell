using System;
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

            IEnumerable<string> nameStr = Names.Where(x => x.Length > 0);

            foreach(var item in nameStr)
            {
                Console.WriteLine(item);
            }

            //foreach(var item in Names2)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
