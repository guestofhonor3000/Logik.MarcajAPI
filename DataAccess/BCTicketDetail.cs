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
    
    public partial class BCTicketDetail
    {
        public int TicketDetailID { get; set; }
        public Nullable<int> TicketID { get; set; }
        public Nullable<System.DateTime> DetailDateTime { get; set; }
        public string Barcode { get; set; }
        public Nullable<float> Qty { get; set; }
        public Nullable<int> ItemID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
