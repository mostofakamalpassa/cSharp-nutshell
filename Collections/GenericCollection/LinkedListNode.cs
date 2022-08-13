using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.GenericCollection
{
    internal sealed class LinkedListNode<T>
    {

        public LinkedListNode<T> Next{get;}
        public LinkedListNode<T> Previous{get;}
        public T Value { get; set; }
        public LinkedList<T> List { get; }
    }
}
