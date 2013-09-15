using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic.Transformers
{
    public static class ProductImageTransformer
    {
        public static DataContracts.ProductImage Transform(Entities.ProductImage image)
        {
            if (image == null) throw new ArgumentNullException("image");

            return new DataContracts.ProductImage(image.Sequence, image.ImageData);
        }
    }
}
