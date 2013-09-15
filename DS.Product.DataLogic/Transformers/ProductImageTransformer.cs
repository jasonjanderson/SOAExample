using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic.Transformers
{
    public static class ProductImageTransformer
    {
        public static Entities.ProductImage Transform(Product.DataAccess.ProductImage daobj)
        {
            if (daobj == null) throw new ArgumentNullException("daobj");

            return new Entities.ProductImage(daobj.Sequence, daobj.Image);
        }
    }
}
