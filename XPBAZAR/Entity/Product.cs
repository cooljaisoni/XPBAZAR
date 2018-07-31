using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XPBAZAR.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
    }
}
