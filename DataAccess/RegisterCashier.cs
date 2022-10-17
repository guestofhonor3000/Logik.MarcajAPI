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
    
    public partial class RegisterCashier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegisterCashier()
        {
            this.ComplimentaryAmounts = new HashSet<ComplimentaryAmount>();
            this.OnAccountCharges = new HashSet<OnAccountCharge>();
            this.OnAccountPayments = new HashSet<OnAccountPayment>();
            this.OrderPayments = new HashSet<OrderPayment>();
            this.OtherPayments = new HashSet<OtherPayment>();
            this.PayOuts = new HashSet<PayOut>();
            this.GiftCertificateUsages = new HashSet<GiftCertificateUsage>();
            this.NoSaleLogs = new HashSet<NoSaleLog>();
            this.OrderRefunds = new HashSet<OrderRefund>();
        }
    
        public int CashierID { get; set; }
        public int EmployeeID { get; set; }
        public int CashTrayID { get; set; }
        public int StationID { get; set; }
        public System.DateTime SignInDateTime { get; set; }
        public float RegisterStartAmount { get; set; }
        public Nullable<System.DateTime> SignOutDateTime { get; set; }
        public Nullable<float> RegisterEndAmount { get; set; }
        public Nullable<float> DiscrepancyAmount { get; set; }
        public string DiscrepancyNotes { get; set; }
        public Nullable<int> ManagerEmployeeID { get; set; }
        public Nullable<float> TotalCash { get; set; }
        public Nullable<float> TotalChecks { get; set; }
        public Nullable<float> TotalCharges { get; set; }
        public Nullable<int> ZReportID { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public Nullable<float> TotalRoomCharges { get; set; }
        public Nullable<float> TotalHouseCharges { get; set; }
        public Nullable<int> CashDrawerNumber { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual CashTray CashTray { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComplimentaryAmount> ComplimentaryAmounts { get; set; }
        public virtual EmployeeFile EmployeeFile { get; set; }
        public virtual EmployeeFile EmployeeFile1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnAccountCharge> OnAccountCharges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnAccountPayment> OnAccountPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPayment> OrderPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherPayment> OtherPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayOut> PayOuts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiftCertificateUsage> GiftCertificateUsages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoSaleLog> NoSaleLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRefund> OrderRefunds { get; set; }
        public virtual StationSetting StationSetting { get; set; }
    }
}