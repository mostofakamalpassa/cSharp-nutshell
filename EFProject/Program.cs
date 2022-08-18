// See https://aka.ms/new-console-template for more information
using EFProject.DbConnection;
using EFProject.Model;

Console.WriteLine("Hello, World!");

var dbContext = new NutshellContext();

//Customer cust = new Customer()
//{
//    Name = "Sara Wells"
//};
//dbContext.Customers.Add(cust);
//dbContext.SaveChanges(); // Writes changes back to database


//var result = dbContext.Customers.FirstOrDefault();
//var result = from db in dbContext.Customers where db.ID == 2 select db;
var result = dbContext.Customers.Where(x => x.ID == 3).Select(x => x.Name); ;

//Console.WriteLine(result.FirstOrDefault());