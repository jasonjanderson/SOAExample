using DS.DataContracts.Requests;
using DS.DataContracts.Responses;
using DS.OperationContracts.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart.Service
{
    public sealed class CartService : ICartService
    {

        public CartResponse GetCart(CartRequest request)
        {
            CartResponse resp = new CartResponse();
            Entities.Cart c = DS.Cart.Cart.GetCart(request.CartID);
            resp.CartID = c.CartID;
            resp.CreateDate = c.CreateDate;
            resp.ModifyDate = c.ModifyDate;
            resp.CartItems = GetProducts(c.ProductIDs);
            resp.Total = resp.CartItems.Sum(i => i.Price);
            return resp;
        }

        public CartResponse CreateCart()
        {
            CartResponse resp = new CartResponse();
            Entities.Cart c = DS.Cart.Cart.CreateCart();
            resp.CartID = c.CartID;
            resp.CreateDate = c.CreateDate;
            resp.ModifyDate = c.ModifyDate;
            resp.Total = resp.CartItems.Sum(i => i.Price);
            return resp;
        }

        public CartResponse AddProduct(CartProductRequest request)
        {
            CartResponse resp = new CartResponse();
            Entities.Cart c = DS.Cart.Cart.AddProduct(request.CartID, request.ProductID);
            resp.CartID = c.CartID;
            resp.CreateDate = c.CreateDate;
            resp.ModifyDate = c.ModifyDate;
            resp.CartItems = GetProducts(c.ProductIDs);
            resp.Total = resp.CartItems.Sum(i => i.Price);
            return resp;
        }

        public CartResponse RemoveProduct(CartProductRequest request)
        {
            CartResponse resp = new CartResponse();
            Entities.Cart c = DS.Cart.Cart.RemoveProduct(request.CartID, request.ProductID);
            resp.CartID = c.CartID;
            resp.CreateDate = c.CreateDate;
            resp.ModifyDate = c.ModifyDate;
            resp.CartItems = GetProducts(c.ProductIDs);
            resp.Total = resp.CartItems.Sum(i => i.Price);
            return resp;
        }

        private static List<DataContracts.Product> GetProducts(IEnumerable<int> productIDs)
        {
            GetProductsClient client = new GetProductsClient();
            DataContracts.Requests.ProductRequest req = new DataContracts.Requests.ProductRequest();
            req.ProductIDs = new List<int>(productIDs);
            req.DisplayAll = false;
            DataContracts.Responses.ProductResponse resp = client.GetProducts(req);
            return new List<DataContracts.Product>(resp.Products);
        }
    }
}
