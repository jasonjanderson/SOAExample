using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart.DataLogic.Transformers
{
    public static class CartTransformer
    {
        public static Entities.Cart Transform(DataAccess.Cart daobj)
        {
            return new Entities.Cart()
            {
                CartID = daobj.ID,
                CreateDate = daobj.CreateDate,
                ModifyDate = daobj.ModifyDate,
                ProductIDs = new List<int>(daobj.CartProducts.Select(i => i.ProductID))
            };
        }
    }
}
