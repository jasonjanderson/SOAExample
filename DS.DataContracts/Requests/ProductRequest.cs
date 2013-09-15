using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts.Requests
{
    [DataContract(Namespace = Namespace.ProductNamespace)]
    public sealed class ProductRequest
    {
        [DataMember]
        public IList<int> ProductIDs { get; set; }

        [DataMember]
        public bool DisplayAll { get; set; }
    }
}
