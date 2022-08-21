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

NutshellContext dbContext = new NutshellContext();
//var retsult = dbContext.Purchase.Where(p => p.Description.CompareTo("rr") < 0).ToList();


//foreach(var ret in retsult)
//{
//    Console.WriteLine(ret);
//}

string tempPath = Path.GetTempPath();
DirectoryInfo[] dirs = new DirectoryInfo(tempPath).GetDirectories();
var querys = from d in dirs
where (d.Attributes & FileAttributes.System) == 0
select new
{
    DirectoryName = d.FullName,
    Created = d.CreationTime,
    Files = from f in d.GetFiles()
            where (f.Attributes & FileAttributes.Hidden) == 0
            select new { FileName = f.Name, f.Length, }
};

foreach (var dirFiles in querys)
{
    Console.WriteLine("Directory: " + dirFiles.DirectoryName);
    foreach (var file in dirFiles.Files)
        Console.WriteLine(" " + file.FileName + " Len: " + file.Length);
}



var queryes =
from c in dbContext.Customers
select new
{
    c.Name,
    Purchases = (from p in dbContext.Purchase
                 where p.CustomerID == c.ID && p.Price
                 > 1000
                 select new { p.Description, p.Price })
.ToList()
};
foreach (var namePurchases in queryes)
{
    Console.WriteLine("Customer: " + namePurchases.Name);
    foreach (var purchaseDetail in namePurchases.Purchases)
        Console.WriteLine(" - $$$: " + purchaseDetail.Price);
}