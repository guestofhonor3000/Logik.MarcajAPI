//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdOrderExplosion
    {
        public int ExplosionID { get; set; }
        public Nullable<int> OrderTransactionID { get; set; }
        public Nullable<int> vInventoryItemID { get; set; }
        public Nullable<float> Quantity { get; set; }
        public Nullable<float> UnitCost { get; set; }
        public Nullable<float> TotalValue { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual ProdOrderTransaction ProdOrderTransaction { get; set; }
    }
}