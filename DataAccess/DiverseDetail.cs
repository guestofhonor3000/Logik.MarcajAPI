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
    
    public partial class DiverseDetail
    {
        public int DiverseDetailsID { get; set; }
        public Nullable<int> DiverseID { get; set; }
        public string Produs { get; set; }
        public Nullable<float> Cantitate { get; set; }
        public string UnitName { get; set; }
        public Nullable<float> PU { get; set; }
        public Nullable<float> TVAU { get; set; }
        public Nullable<float> VU { get; set; }
        public Nullable<float> VFTVA { get; set; }
        public Nullable<float> TVA { get; set; }
        public Nullable<float> VT { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
