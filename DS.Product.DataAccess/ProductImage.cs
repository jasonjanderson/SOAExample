//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS.Product.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public int ProductID { get; set; }
        public int Sequence { get; set; }
        public string Image { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
