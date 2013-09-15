using DS.DataContracts.Requests;
using DS.DataContracts.Responses;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DS.OperationContracts.Cart
{
    [ServiceContract(Namespace = "http://directsupply.com/services/cart")]
    public interface IAddProduct
    {
        [OperationContract]
        CartResponse AddProduct(CartProductRequest request);
    }
}
