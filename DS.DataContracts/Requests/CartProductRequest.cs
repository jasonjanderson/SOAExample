using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts.Requests
{
    [DataContract(Namespace = Namespace.CartNamespace)]
    public sealed class CartProductRequest
    {
        [DataMember]
        public int CartID { get; set; }

        [DataMember]
        public int ProductID { get; set; }
    }
}
