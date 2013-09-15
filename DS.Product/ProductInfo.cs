using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.Product.Entities;

namespace DS.Product
{
    public static class ProductInfo
    {
        public static ICollection<Entities.Product> GetProductInfo()
        {
            return DataLogic.ProductDL.GetProducts();
        }
    }
}
