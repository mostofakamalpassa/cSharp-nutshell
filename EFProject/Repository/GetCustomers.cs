using EFProject.DbConnection;
using EFProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Repository
{
    internal class GetCustomers
    {
        public Customer CustormesTable()
        {
            var customer = new NutshellContext().Customers.Where(x => x.Name.Contains("k")).FirstOrDefault();

            return customer;

        }
    }
}
