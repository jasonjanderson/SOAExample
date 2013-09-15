using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.Product.Entities;

namespace DS.Product
{
    public static class Images
    {
        public static ICollection<Entities.ProductImage> GetImages(int productID)
        {
            return DataLogic.ProductImageDL.GetProductImages(productID);
        }
    }
}
