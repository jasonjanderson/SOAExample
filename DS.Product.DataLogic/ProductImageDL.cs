using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic
{
    public static class ProductImageDL
    {
        public static ICollection<Entities.ProductImage> GetProductImages(int productID)
        {
            IList<Product.DataAccess.ProductImage> images = Product.DataAccess.ImageDA.GetImages(productID);
            return images.Select(i => Transformers.ProductImageTransformer.Transform(i)).ToList();
        }
    }
}
