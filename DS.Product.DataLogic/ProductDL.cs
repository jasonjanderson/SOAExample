using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic
{
    public static class ProductDL
    {
        public static Entities.Product GetProduct(int productID)
        {
            Product.DataAccess.Product product = Product.DataAccess.ProductDA.GetProduct(productID);
            if (product == null) throw new Exception(string.Format("No product found with ID: {0}", productID));
            return Transformers.ProductTransformer.Transform(product);
        }

        public static ICollection<Entities.Product> GetProducts()
        {
            ICollection<Product.DataAccess.Product> products = Product.DataAccess.ProductDA.GetProducts();
            return products.Select(i => Transformers.ProductTransformer.Transform(i)).ToList();
        }
    }
}
