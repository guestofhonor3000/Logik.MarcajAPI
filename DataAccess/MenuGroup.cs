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
    
    public partial class MenuGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuGroup()
        {
            this.MenuItems = new HashSet<MenuItem>();
        }
    
        public int MenuGroupID { get; set; }
        public string MenuGroupText { get; set; }
        public int DisplayIndex { get; set; }
        public bool MenuGroupInActive { get; set; }
        public string SecLangMenuGroupText { get; set; }
        public Nullable<System.DateTime> AvailStartTime { get; set; }
        public Nullable<System.DateTime> AvailStopTime { get; set; }
        public string PictureName { get; set; }
        public bool ShowCaption { get; set; }
        public Nullable<int> ButtonColor { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public Nullable<bool> DineInNotAvail { get; set; }
        public Nullable<bool> BarNotAvail { get; set; }
        public Nullable<bool> TakeOutNotAvail { get; set; }
        public Nullable<bool> DriveThruNotAvail { get; set; }
        public Nullable<bool> DeliveryNotAvail { get; set; }
        public Nullable<bool> DefaultGroupDineIn { get; set; }
        public Nullable<bool> DefaultGroupBar { get; set; }
        public Nullable<bool> DefaultGroupToGo { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
