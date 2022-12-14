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
    
    public partial class StationSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StationSetting()
        {
            this.OrderHeaders = new HashSet<OrderHeader>();
            this.RegisterCashiers = new HashSet<RegisterCashier>();
            this.AccessDeniedLogs = new HashSet<AccessDeniedLog>();
        }
    
        public int StationID { get; set; }
        public string ComputerName { get; set; }
        public string ReceiptPrinterPort { get; set; }
        public int ReceiptPrinterType { get; set; }
        public bool CashDrawerAttached { get; set; }
        public string KitchenPrinter1Title { get; set; }
        public string KitchenPrinter1Port { get; set; }
        public int KitchenPrinter1Type { get; set; }
        public string KitchenPrinter1Name { get; set; }
        public string KitchenPrinter2Title { get; set; }
        public string KitchenPrinter2Port { get; set; }
        public Nullable<int> KitchenPrinter2Type { get; set; }
        public string KitchenPrinter2Name { get; set; }
        public string KitchenPrinter3Title { get; set; }
        public string KitchenPrinter3Port { get; set; }
        public Nullable<int> KitchenPrinter3Type { get; set; }
        public string KitchenPrinter3Name { get; set; }
        public string BarPrinterPort { get; set; }
        public Nullable<int> BarPrinterType { get; set; }
        public string ReportPrinterPort { get; set; }
        public bool DedicatedToCashier { get; set; }
        public string UserInterfaceLocale { get; set; }
        public string ReceiptPrinterName { get; set; }
        public string BarPrinterName { get; set; }
        public string ReportPrinterName { get; set; }
        public string PackagerPrinterPort { get; set; }
        public Nullable<int> PackagerPrinterType { get; set; }
        public string PackagerPrinterName { get; set; }
        public bool FastBar { get; set; }
        public Nullable<int> DefaultTableGroupID { get; set; }
        public bool BarTab { get; set; }
        public bool OrderRecallToBrowse { get; set; }
        public string OrderRecallOrderType { get; set; }
        public bool DefaultToMenuGroupsInOrderEntry { get; set; }
        public bool HasEDC { get; set; }
        public bool DriveThruStation { get; set; }
        public string BarTabCaption { get; set; }
        public string PoleDisplayCommPort { get; set; }
        public string PoleDisplayWelcomeMessage1 { get; set; }
        public string CallerIDCommPort { get; set; }
        public bool KeepInOrderEntryAfterSent { get; set; }
        public string PoleDisplayWelcomeMessage2 { get; set; }
        public string KitchenPrinter4Title { get; set; }
        public string KitchenPrinter4Name { get; set; }
        public Nullable<int> KitchenPrinter4Type { get; set; }
        public string KitchenPrinter5Title { get; set; }
        public string KitchenPrinter5Name { get; set; }
        public Nullable<int> KitchenPrinter5Type { get; set; }
        public string KitchenPrinter6Title { get; set; }
        public string KitchenPrinter6Name { get; set; }
        public Nullable<int> KitchenPrinter6Type { get; set; }
        public string LabelPrinterName { get; set; }
        public Nullable<int> LabelPrinterType { get; set; }
        public Nullable<System.DateTime> EditTimestamp { get; set; }
        public Nullable<short> RemoteSiteNumber { get; set; }
        public Nullable<int> RemoteOrigRowID { get; set; }
        public string GlobalID { get; set; }
        public string RowVer { get; set; }
        public Nullable<System.DateTime> SynchVer { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public string RerouteBar1Title { get; set; }
        public string RerouteBar1PrinterName { get; set; }
        public Nullable<int> RerouteBar1PrinterType { get; set; }
        public string RerouteBar2Title { get; set; }
        public string RerouteBar2PrinterName { get; set; }
        public Nullable<int> RerouteBar2PrinterType { get; set; }
        public string RerouteBar3Title { get; set; }
        public string RerouteBar3PrinterName { get; set; }
        public Nullable<int> RerouteBar3PrinterType { get; set; }
        public string RerouteBar4Title { get; set; }
        public string RerouteBar4PrinterName { get; set; }
        public Nullable<int> RerouteBar4PrinterType { get; set; }
        public string RerouteBar5Title { get; set; }
        public string RerouteBar5PrinterName { get; set; }
        public Nullable<int> RerouteBar5PrinterType { get; set; }
        public string RerouteBar6Title { get; set; }
        public string RerouteBar6PrinterName { get; set; }
        public Nullable<int> RerouteBar6PrinterType { get; set; }
        public string ExtendedSettings { get; set; }
        public string HQRowID { get; set; }
        public string LastRowHash { get; set; }
        public Nullable<short> RowOwner { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public Nullable<bool> PopUpBool { get; set; }
        public string Theme { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisterCashier> RegisterCashiers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessDeniedLog> AccessDeniedLogs { get; set; }
    }
}
