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
    
    public partial class Discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discount()
        {
            this.OrderHeaders = new HashSet<OrderHeader>();
            this.OrderTransactions = new HashSet<OrderTransaction>();
        }
    
        public int DiscountID { get; set; }
        public string DiscountText { get; set; }
        public string DiscountDescription { get; set; }
        public bool DiscountedAmountTaxable { get; set; }
        public Nullable<System.DateTime> DiscountExpireDate { get; set; }
        public bool DiscountInActive { get; set; }
        public float DiscountAmount { get; set; }
        public string DiscountBasis { get; set; }
        public Nullable<float> DiscountAllowedMinTicket { get; set; }
        public string Barcode { get; set; }
        public Nullable<int> DiscountMenuItemID { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public Nullable<bool> DiscountItemNotAvail { get; set; }
        public Nullable<bool> DiscountOrderNotAvail { get; set; }
        public Nullable<short> DiscountSecurityLevel { get; set; }
        public string BaseMMGCode { get; set; }
        public Nullable<short> BaseMMGQty { get; set; }
        public string OfferMMGCode { get; set; }
        public Nullable<short> OfferMMGQty { get; set; }
        public Nullable<bool> BOGO { get; set; }
        public Nullable<bool> BXF { get; set; }
        public Nullable<bool> ExcludeBarItems { get; set; }
        public Nullable<bool> VIPUseOnly { get; set; }
        public Nullable<bool> DineInNotAvail { get; set; }
        public Nullable<bool> BarNotAvail { get; set; }
        public Nullable<bool> TakeOutNotAvail { get; set; }
        public Nullable<bool> DriveThruNotAvail { get; set; }
        public Nullable<bool> DeliveryNotAvail { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTransaction> OrderTransactions { get; set; }
    }
}