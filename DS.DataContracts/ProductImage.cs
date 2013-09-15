using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DS.DataContracts
{
    [DataContract]
    public sealed class ProductImage
    {
        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        public string ImageData { get; set; }

        public ProductImage(int sequence, string imageData)
        {
            Sequence = sequence;
            ImageData = imageData;
        }
    }
}
