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


        public void ListSystem()
        {
            List<string> str = new List<string>();

            str.Add("one");
            str.Add("two");
            str.Insert(0, "insert one");
            str.Insert(3, "insert three");
            str.AddRange(new string[] { "addRange one", "addrange two", "addragne Three" });
            str.InsertRange(4, new List<string> { "inserRangeOne", "inserRagne two" });


            foreach(var item in str)
            {
                Console.WriteLine(item);
            }

            //str.Remove("two");
           // str.RemoveAt(3);
           // str.RemoveRange(3, 5);
           // str.RemoveAll(s => s.StartsWith("a"));
        }



        public void ArrayListSystem()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("one");   
            arrayList.Add("two");
           // arrayList.Add(55);


            // convert to array list to List object 

            List<string> list = arrayList.Cast<string>().ToList();
        }


        public void LinkedListSystem()
        {
            LinkedList<string> list = new LinkedList<string>();

        }
    }


   
}
