using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataAccess
{
    public static class ImageDA
    {
        public static IList<ProductImage> GetImages(int productID)
        {
            ProductEntities da = new ProductEntities();
            return da.ProductImages.Where(i => i.ProductID == productID).ToList();
        }
    }
}
