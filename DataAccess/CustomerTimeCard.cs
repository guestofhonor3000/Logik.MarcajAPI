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
    
    public partial class CustomerTimeCard
    {
        public int TimeCardID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> ClockInTime { get; set; }
        public Nullable<System.DateTime> ClockOutTime { get; set; }
        public Nullable<float> TotalHours { get; set; }
        public Nullable<float> TotalCost { get; set; }
        public Nullable<int> CostID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
