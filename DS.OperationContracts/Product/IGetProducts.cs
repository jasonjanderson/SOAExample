using DS.DataContracts.Requests;
using DS.DataContracts.Responses;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DS.OperationContracts.Product
{
    [ServiceContract(Namespace = "http://directsupply.com/services/product")]
    public interface IGetProducts
    {
        [OperationContract]
        ProductResponse GetProducts(ProductRequest request);
    }
}
