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
    
    public partial class CustomerCredit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerCredit()
        {
            this.FreqDinerTrackings = new HashSet<FreqDinerTracking>();
            this.OrderHeaders = new HashSet<OrderHeader>();
        }
    
        public int CreditID { get; set; }
        public System.DateTime CreditDateTime { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public string CreditReason { get; set; }
        public string CreditLimitations { get; set; }
        public string CreditType { get; set; }
        public float CreditAmount { get; set; }
        public string CreditStatus { get; set; }
        public string CreditVoidReason { get; set; }
        public Nullable<System.DateTime> CreditExpireDate { get; set; }
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
    
        public virtual CustomerFile CustomerFile { get; set; }
        public virtual EmployeeFile EmployeeFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreqDinerTracking> FreqDinerTrackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
    }
}
