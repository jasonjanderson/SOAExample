using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.OperationContracts.Cart;

namespace DS.Cart.Service
{
    public interface ICartService : IGetCart, ICreateCart, IAddProduct, IRemoveProduct
    {
    }
}
