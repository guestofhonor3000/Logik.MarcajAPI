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
    
    public partial class CFlowOperatiuni
    {
        public int OperatiuneID { get; set; }
        public Nullable<int> ContID { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Descriere { get; set; }
        public string TipDocument { get; set; }
        public string NumarDocument { get; set; }
        public Nullable<float> Incasat { get; set; }
        public Nullable<float> Platit { get; set; }
        public Nullable<int> CategorieID { get; set; }
        public Nullable<float> Sold { get; set; }
        public Nullable<bool> GenerataAutomat { get; set; }
        public Nullable<int> IDAutomat { get; set; }
        public Nullable<int> SortNumber { get; set; }
        public Nullable<int> TipOperatiune { get; set; }
        public Nullable<int> TContID { get; set; }
        public Nullable<int> TOperatiuneID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}