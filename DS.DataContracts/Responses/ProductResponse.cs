using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts.Responses
{
    [DataContract(Namespace = Namespace.ProductNamespace)]
    public sealed class ProductResponse
    {
        [DataMember]
        public IList<Product> Products { get; set; }

        public ProductResponse()
        {
            Products = new List<Product>();
        }
    }
}
