//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksEntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
