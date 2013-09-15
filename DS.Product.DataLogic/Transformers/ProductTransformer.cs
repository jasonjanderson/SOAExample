using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.DataLogic.Transformers
{
    public static class ProductTransformer
    {
        public static Entities.Product Transform(DataAccess.Product daobj)
        {
            if (daobj == null) throw new ArgumentNullException("daobj");

            return new Entities.Product
            {
                ProductID = daobj.ID,
                ProductNumber = daobj.ProductNumber,
                Name = daobj.Name,
                Description = daobj.Description,
                Quantity = daobj.Quantity,
                Price = daobj.Price
            };

        }
    }
}
