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
    
    public partial class FreqDinerTracking
    {
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime TrackingDateTime { get; set; }
        public int OrderID { get; set; }
        public Nullable<int> RewardCreditID { get; set; }
        public int AutoID { get; set; }
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
    
        public virtual CustomerCredit CustomerCredit { get; set; }
        public virtual CustomerFile CustomerFile { get; set; }
        public virtual EmployeeFile EmployeeFile { get; set; }
        public virtual OrderHeader OrderHeader { get; set; }
    }
}