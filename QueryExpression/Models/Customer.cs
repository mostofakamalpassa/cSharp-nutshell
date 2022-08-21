using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpression.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
