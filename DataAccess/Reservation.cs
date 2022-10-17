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
    
    public partial class Reservation
    {
        public int AutoID { get; set; }
        public string PartyName { get; set; }
        public string Occasion { get; set; }
        public short Adults { get; set; }
        public Nullable<short> Children { get; set; }
        public Nullable<short> HighChairs { get; set; }
        public Nullable<short> WheelChairs { get; set; }
        public System.DateTime ReserveDateTime { get; set; }
        public bool Smoking { get; set; }
        public bool Window { get; set; }
        public bool Booth { get; set; }
        public bool Privacy { get; set; }
        public string Notes { get; set; }
        public Nullable<int> TableIDAssigned { get; set; }
        public string CreditCardNumber { get; set; }
        public Nullable<System.DateTime> PartyCheckInDateTime { get; set; }
        public bool ReservationCancelled { get; set; }
        public string WhoPays { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public string Phone { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public Nullable<bool> bWaitingList { get; set; }
        public string PagerNumber { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
