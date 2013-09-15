using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataAccess
{
    public static class ProductDA
    {
        public static Product GetProduct(int id)
        {
            ProductEntities da = new ProductEntities();
            return da.Products.FirstOrDefault(i => i.ID == id);
        }

        public static ICollection<Product> GetProducts()
        {
            ProductEntities da = new ProductEntities();
            return da.Products.ToList();
        }
    }
}
