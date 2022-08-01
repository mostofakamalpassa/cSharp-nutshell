using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGenericCollection
{
    internal class Hashtables
    {

        Hashtable htable = new Hashtable();

        public void Add(Hashtable hashtable)
        {
            htable.Add("Key",hashtable);
        }
    }
}
