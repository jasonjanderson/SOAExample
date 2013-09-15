using DS.DataContracts.Requests;
using DS.DataContracts.Responses;
using DS.OperationContracts.Product;
using DS.Product.DataLogic.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.Service
{
    public sealed class ProductService : IProductService
    {
        public ProductResponse GetProducts(ProductRequest request)
        {
            ProductResponse resp = new ProductResponse();

            IEnumerable<Entities.Product> products = Product.ProductInfo.GetProductInfo();
            if (!request.DisplayAll) products = products.Where(i => request.ProductIDs.Contains(i.ProductID));
            foreach (Entities.Product p in products)
            {
                DataContracts.Product dc = ProductTransformer.Transform(p);
                dc.Images = Product.Images.GetImages(p.ProductID).Select(i => ProductImageTransformer.Transform(i)).ToList();
                resp.Products.Add(dc);
            }
            return resp;
        }
    }
}
