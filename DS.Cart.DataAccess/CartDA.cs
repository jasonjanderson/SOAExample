using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart.DataAccess
{
    public static class CartDA
    {
        public static Cart GetCart(int cartID)
        {
            DSCartEntities da = new DSCartEntities();
            return da.Carts.FirstOrDefault(i => i.ID == cartID);
        }

        public static Cart CreateCart()
        {
            DSCartEntities da = new DSCartEntities();
            Cart c = new Cart() { CreateDate = DateTime.UtcNow, ModifyDate = DateTime.UtcNow };
            da.Carts.Add(c);
            da.SaveChanges();
            return c;
        }

        public static void AddProduct(int cartID, int productID)
        {
            DSCartEntities da = new DSCartEntities();
            Cart c = GetCart(cartID);
            if (c == null) throw new Exception("Cart does not exist");
            CartProduct cp = new CartProduct() {CartID = cartID, ProductID = productID};
            c.ModifyDate = DateTime.UtcNow;
            da.CartProducts.Add(cp);
            da.SaveChanges();
        }

        public static void RemoveProduct(int cartID, int productID)
        {
            DSCartEntities da = new DSCartEntities();
            Cart c = GetCart(cartID);
            if (c == null) throw new Exception("Cart does not exist");
            CartProduct cp = new CartProduct() { CartID = cartID, ProductID = productID };
            da.CartProducts.Attach(cp);
            c.ModifyDate = DateTime.UtcNow;
            da.CartProducts.Remove(cp);
            da.SaveChanges();
        }
    }
}
