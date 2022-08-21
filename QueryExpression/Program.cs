// See https://aka.ms/new-console-template for more information


using QueryExpression.DBConnect;

string[] names = { "Kamal", "jamal", "tomal", "damal","juma" };


//IEnumerable<string> query = from n in names where n.EndsWith("a") select n;

//foreach(string name in query)
//{
//    Console.WriteLine(name);
//}


//from n in names where n.Length > 4 let u = n.ToUpper() where u.EndsWith("l") select u;



IEnumerable<string> query = names.Where((n, i) => i % 2 == 0);

//foreach(string name in query)
//{
//    Console.WriteLine(name);

//NutshellContext dbContext = new NutshellContext();
//var retsult = dbContext.Purchase.Where(p => p.Description.CompareTo("rr") < 0).ToList();


//foreach(var ret in retsult)
//{
//    Console.WriteLine(ret);
//}