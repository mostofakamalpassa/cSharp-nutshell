using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGenericCollection
{
    internal class StackNonGeneric
    {
       
        public void StackData()
        {
         var arr =    new ArrayList() { "one", "two", "three", "four", "five", "six" };
            Stack st = new Stack();
            st.Push("one");
            st.Push("Five");
            st.Push(66);
            st.Push(true);
            st.Push(arr);


            foreach(var item in st)
            {
                if(item != arr)
                {
                    Console.WriteLine(item);
                }
                if(item == arr)
                {
                    foreach(var items in arr)
                    {
                        Console.WriteLine(items);

                    }
                }
                
                
            }
        }


        public void QueData()
        {
            Queue queue = new Queue();
            queue.Enqueue("one");
            queue.Enqueue(444);
            queue.Enqueue(true);
            queue.Enqueue(new ArrayList() { "one", "two", "three" });
        }
       
    }
}
