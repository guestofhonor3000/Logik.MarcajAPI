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
    
    public partial class ImprimanteMultiple
    {
        public int ID { get; set; }
        public string NumeImprimanta { get; set; }
        public Nullable<bool> GenerareInFolder { get; set; }
        public string LocatieFolder { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
