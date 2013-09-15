using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts.Requests
{
    [DataContract(Namespace = Namespace.CartNamespace)]
    public sealed class CartRequest
    {
        [DataMember]
        public int CartID { get; set; }
    }
}
