using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Model
{
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Child navigation property, which must be of type ICollection<T>:
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
