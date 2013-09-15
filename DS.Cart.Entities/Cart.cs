using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Cart.Entities
{
    public sealed class Cart
    {
        public int CartID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public ICollection<int> ProductIDs { get; set; }
    }
}
