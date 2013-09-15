using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Product.Entities
{
    public sealed class ProductImage
    {
        public int Sequence { get; set; }

        public string ImageData { get; set; }

        public ProductImage(int sequence, string imageData)
        {
            Sequence = sequence;
            ImageData = imageData;
        }

    }
}
