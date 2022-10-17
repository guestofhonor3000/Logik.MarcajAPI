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
    
    public partial class BadCheckFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BadCheckFile()
        {
            this.OtherPayments = new HashSet<OtherPayment>();
        }
    
        public int BadCheckID { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string DriverLicenseNumber { get; set; }
        public System.DateTime CheckIssueDate { get; set; }
        public string ABANumber { get; set; }
        public string CheckingAcctNumber { get; set; }
        public int CheckNumber { get; set; }
        public float CheckAmount { get; set; }
        public Nullable<int> RefOrderNumber { get; set; }
        public int BadCheckReasonID { get; set; }
        public int BadCheckPenaltyID { get; set; }
        public float BadCheckPenaltyAmount { get; set; }
        public string BadCheckNotes { get; set; }
        public int BankID { get; set; }
        public string CollectionStatus { get; set; }
        public string AlertCode { get; set; }
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
    
        public virtual BankFile BankFile { get; set; }
        public virtual BadCheckReason BadCheckReason { get; set; }
        public virtual BadCheckPenalty BadCheckPenalty { get; set; }
        public virtual OrderHeader OrderHeader { get; set; }
        public virtual ZipCode ZipCode1 { get; set; }
        public virtual CustomerFile CustomerFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherPayment> OtherPayments { get; set; }
    }
}
