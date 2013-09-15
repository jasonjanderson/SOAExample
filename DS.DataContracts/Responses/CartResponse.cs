using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts.Responses
{
    [DataContract(Namespace = Namespace.CartNamespace)]
    public sealed class CartResponse
    {
        [DataMember]
        public int CartID { get; set; }

        [DataMember]
        public IList<Product> CartItems { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public DateTime ModifyDate { get; set; }

        public CartResponse()
        {
            CartItems = new List<Product>();
        }
    }
}
