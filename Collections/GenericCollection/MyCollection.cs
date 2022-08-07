using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.GenericCollection
{
    internal class MyCollection : IEnumerable
    {
        int[] data = { 2, 3, 4, 5, 6, 7 };
        public IEnumerator GetEnumerator()
        {
           foreach(var item in data)
            {
                yield return item;
            }
        }


        public IEnumerable<int> GetSomeIntegers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
        }
    }
}
