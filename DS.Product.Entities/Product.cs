using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.Entities
{
    public sealed class Product
    {
        public int ProductID { get; set; }

        public string ProductNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Product() { }

    }
}
