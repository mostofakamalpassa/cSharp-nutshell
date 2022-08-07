using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class BasicCollections
    {
        public void IEnumaratorEnumarable()
        {

            var str = "Hello kamal";
            IEnumerator enumerator = str.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item.ToString());
            }

        }

        public void IEnumariable()
        {
            int[] data = { 2, 3, 4, 5, 6, 78 };

            var rator = ((IEnumerable<int>)data).GetEnumerator();
        }

        public static int count(IEnumerable e)
        {
            int count = 0;

            foreach (object o in e)
            {
                var subElement = o as IEnumerable;

                if (subElement != null)
                {
                    count += subElement.Cast<int>().Count();

                }
                else
                {
                    count++;
                }
            }

            return count;
        }

        public void BitArrays()
        {
            // creating two bit arrays of size 8
            BitArray bitArray = new BitArray(8);
            BitArray bitArray1 = new BitArray(30);

            int[] bitOne = { 60 };
            int[] bitTwo = { 100 };
            var a = new BitArray(bitOne);
            var b = new BitArray(bitTwo);

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
