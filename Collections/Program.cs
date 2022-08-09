// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.GenericCollection;
using Collections.NonGenericCollection;
using System.Collections;
using System.Collections.Generic;
using System.Text;






//ArrayListCollection arList = new ArrayListCollection();
//ArrayList  arrayList = new ArrayList();
//arrayList.Add("one");
//arrayList.Add(DateTime.Now);
//arrayList.Add(5000);
//arrayList.Add(true);
//arList.Add(arrayList);

//Hashtable ht = new Hashtable();
//ht.Add("one", arrayList);
//ht.Add("two", "hello every one");
//Hashtables htable = new Hashtables();

//htable.Add(ht);

//SortedList sl = new SortedList();
//sl.Add("one", arrayList);
//sl.Add("two", arrayList);
//sl.Add("three", "ok this is sorted list");
//arList.AddSortedList(sl);


//StackNonGeneric stackNonGeneric = new StackNonGeneric();
//stackNonGeneric.StackData();

BasicCollections bsColl = new BasicCollections();

//bsColl.IEnumaratorEnumarable();

IEnumerable ob = new List<int>() { 2, 3, 4, 4, 5, 6, 7, 8 };


//Console.WriteLine(BasicCollections.count(ob));

//bsColl.BitArrays();


IEnumariblesAndOtherGeneric enumariblesAndOtherGeneric = new IEnumariblesAndOtherGeneric();
//enumariblesAndOtherGeneric.OtherGeneric();

List<int> ints = new List<int>() { 4, 5, 65, 6, 7, 8, 9 };

//Console.WriteLine(IEnumariblesAndOtherGeneric.Count(ints)) ;

//MyCollection myCollection = new MyCollection();
//IEnumerable values =  myCollection.GetEnumerator() as IEnumerable;
//if (values != null)
//{
//    foreach (var i in values)
//    {
//        Console.WriteLine(i);

//    }
// }



//Console.WriteLine(myCollection.GetSomeIntegers().First());
//Console.WriteLine(myCollection.GetSomeIntegers().Last());
//var mList = myCollection.GetSomeIntegers().ToList();
//var list = mList.GetEnumerator();

//while (list.MoveNext())
//{
//    Console.WriteLine(list.Current);
//}




StringBuilder[] stringBuilder = new StringBuilder[5];
stringBuilder[0] = new StringBuilder("jamal kahan");
stringBuilder[1] = new StringBuilder("we love alahe");
stringBuilder[2] = new StringBuilder("toamal kahan");
stringBuilder[3] = new StringBuilder("adfadsfasdf");
stringBuilder[4] = new StringBuilder("terewrqwer");

//foreach(var item in stringBuilder)
//{
//    Console.WriteLine(item);
//}