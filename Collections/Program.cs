﻿// See https://aka.ms/new-console-template for more information
using Collections;
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

SortedList sl = new SortedList();
sl.Add("one", arrayList);
sl.Add("two", arrayList);
sl.Add("three", "ok this is sorted list");
arList.AddSortedList(sl);


//StackNonGeneric stackNonGeneric = new StackNonGeneric();
//stackNonGeneric.StackData();

BasicCollections bsColl = new BasicCollections();

//bsColl.IEnumaratorEnumarable();

IEnumerable ob = new List<int>() { 2, 3, 4, 4, 5, 6, 7, 8 };


Console.WriteLine(BasicCollections.count(ob));