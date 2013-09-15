using DS.Cart.DataLogic.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart.DataLogic
{
    public static class CartDL
    {
        public static Entities.Cart GetCart(int cartID)
        {
            return CartTransformer.Transform(DataAccess.CartDA.GetCart(cartID));
        }

        public static Entities.Cart CreateCart()
        {
            return CartTransformer.Transform(DataAccess.CartDA.CreateCart());
        }

        public static Entities.Cart AddProduct(int cartID, int productID)
        {
            DataAccess.CartDA.AddProduct(cartID, productID);
            return GetCart(cartID);
        }

        public static Entities.Cart RemoveProduct(int cartID, int productID)
        {
            DataAccess.CartDA.RemoveProduct(cartID, productID);
            return GetCart(cartID);
        }
    }
}
