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
    
    public partial class InventoryPhysicalCount
    {
        public int InventoryPhysicalCountID { get; set; }
        public System.DateTime PhysicalCountDateTime { get; set; }
        public int InventoryID { get; set; }
        public float StartQty { get; set; }
        public float StartValue { get; set; }
        public float StartUnitCost { get; set; }
        public float EndQty { get; set; }
        public float EndValue { get; set; }
        public float EndUnitCost { get; set; }
        public float UsedQty { get; set; }
        public float UsedValue { get; set; }
        public float UsedUnitCost { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual InventoryItem InventoryItem { get; set; }
    }
}
