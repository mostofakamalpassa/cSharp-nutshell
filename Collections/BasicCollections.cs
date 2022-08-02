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
    }
}
