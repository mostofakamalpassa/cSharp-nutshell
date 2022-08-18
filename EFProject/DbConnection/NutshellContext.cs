using EFProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.DbConnection
{
    internal class NutshellContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer(@"Server=Server;Database=Nutshell;Trusted_Connection=True");

        public DbSet<Customer> Customers { get; set; }
    }
}
