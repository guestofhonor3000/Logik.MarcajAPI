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
    
    public partial class OnAccountPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OnAccountPayment()
        {
            this.OnAccountCharges = new HashSet<OnAccountCharge>();
        }
    
        public int OrderChargePaymentID { get; set; }
        public System.DateTime PaymentDateTime { get; set; }
        public int CashierID { get; set; }
        public Nullable<int> NonCashierEmployeeID { get; set; }
        public float AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public float AmountTendered { get; set; }
        public Nullable<int> OrderChargeID { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public Nullable<int> EDCTransID { get; set; }
        public string EDCCardLast4 { get; set; }
        public Nullable<int> EDCCardType { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual EmployeeFile EmployeeFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnAccountCharge> OnAccountCharges { get; set; }
        public virtual RegisterCashier RegisterCashier { get; set; }
    }
}
