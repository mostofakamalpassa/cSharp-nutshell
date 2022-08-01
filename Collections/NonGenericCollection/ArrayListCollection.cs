using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGenericCollection
{
    internal class ArrayListCollection
    {
        ArrayList al = new ArrayList();
        SortedList sl = new SortedList();
        public void Add(ArrayList data)
        {
            al.Add(data);
        }

        public void AddSortedList(SortedList sortedList)
        {
            sl.Add("sort",sortedList);
        }
    }
}
