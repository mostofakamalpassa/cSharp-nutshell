// See https://aka.ms/new-console-template for more information
using EFProject.DbConnection;
using EFProject.Model;
using EFProject.Repository;

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


var dbCustomer = new GetCustomers();

//Console.WriteLine(dbCustomer.CustormesTable().Name);


//Customer cust = dbContext.Customers.Single(c => c.ID == 1);
//Purchase p1 = new Purchase { Description = "Bike", Price = 500 };
//Purchase p2 = new Purchase { Description = "Tools", Price = 100 };
//cust.Purchases.Add(p1);
//cust.Purchases.Add(p2);
//dbContext.SaveChanges();