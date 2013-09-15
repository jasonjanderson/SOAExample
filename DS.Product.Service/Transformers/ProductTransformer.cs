using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic.Transformers
{
    public static class ProductTransformer
    {
        public static DataContracts.Product Transform(Entities.Product product)
        {
            if (product == null) throw new ArgumentNullException("product");

            return new DataContracts.Product
            {
                ProductID = product.ProductID,
                ProductNumber = product.ProductNumber,
                Name = product.Name,
                Description = product.Description,
                Quantity = product.Quantity,
                Price = product.Price
            };

        }
    }
}
