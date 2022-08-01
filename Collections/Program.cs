// See https://aka.ms/new-console-template for more information
using Collections.NonGenericCollection;
using System.Collections;

Console.WriteLine("Hello, World!");


ArrayListCollection arList = new ArrayListCollection();
ArrayList  arrayList = new ArrayList();
arrayList.Add("one");
arrayList.Add(DateTime.Now);
arrayList.Add(5000);
arrayList.Add(true);
//arList.Add(arrayList);

Hashtable ht = new Hashtable();
ht.Add("one", arrayList);
ht.Add("two", "hello every one");
Hashtables htable = new Hashtables();

htable.Add(ht);