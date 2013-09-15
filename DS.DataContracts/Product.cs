using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DS.DataContracts
{
    [DataContract]
    public sealed class Product
    {
        [DataMember]
        public int ProductID { get; set; }
        
        [DataMember]
        public string ProductNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public IList<ProductImage> Images { get; set; }

        public Product()
        {
            Images = new List<ProductImage>();
        }
    }
}
