using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart
{
    public static class Cart
    {
        public static Entities.Cart GetCart(int cartID)
        {
            return DataLogic.CartDL.GetCart(cartID);
        }

        public static Entities.Cart CreateCart()
        {
            return DataLogic.CartDL.CreateCart();
        }

        public static Entities.Cart AddProduct(int cartID, int productID)
        {
            return DataLogic.CartDL.AddProduct(cartID, productID);
        }

        public static Entities.Cart RemoveProduct(int cartID, int productID)
        {
            return DataLogic.CartDL.RemoveProduct(cartID, productID);
        }

    }
}
