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
    
    public partial class IesiriGestiune
    {
        public int AutoID { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string TipDocument { get; set; }
        public Nullable<int> NumarDocument { get; set; }
        public Nullable<int> InventoryItemID { get; set; }
        public Nullable<float> Cantitate { get; set; }
        public Nullable<float> Valoare { get; set; }
        public Nullable<byte> Tip { get; set; }
        public Nullable<int> SursaID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
