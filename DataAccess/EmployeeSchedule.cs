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
    
    public partial class EmployeeSchedule
    {
        public int ScheduleID { get; set; }
        public int EmployeeID { get; set; }
        public string WeekDay { get; set; }
        public System.DateTime ClockInTime { get; set; }
        public System.DateTime ClockOutTime { get; set; }
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
        public Nullable<System.DateTime> Break1BeginTime { get; set; }
        public Nullable<System.DateTime> Break1EndTime { get; set; }
        public Nullable<bool> Break1Compensated { get; set; }
        public Nullable<System.DateTime> Break2BeginTime { get; set; }
        public Nullable<System.DateTime> Break2EndTime { get; set; }
        public Nullable<bool> Break2Compensated { get; set; }
        public Nullable<System.DateTime> Break3BeginTime { get; set; }
        public Nullable<System.DateTime> Break3EndTime { get; set; }
        public Nullable<bool> Break3Compensated { get; set; }
        public Nullable<System.DateTime> Break4BeginTime { get; set; }
        public Nullable<System.DateTime> Break4EndTime { get; set; }
        public Nullable<bool> Break4Compensated { get; set; }
        public Nullable<System.DateTime> Break5BeginTime { get; set; }
        public Nullable<System.DateTime> Break5EndTime { get; set; }
        public Nullable<bool> Break5Compensated { get; set; }
        public Nullable<int> TotalRegularMinutes { get; set; }
        public Nullable<int> TotalDailyOverTimeMinutes { get; set; }
        public Nullable<int> TotalWeeklyOverTimeMinutes { get; set; }
        public Nullable<int> TotalDoubleTimeMinutes { get; set; }
        public Nullable<int> TotalWorkMinutes { get; set; }
        public string RowGUID { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual EmployeeFile EmployeeFile { get; set; }
    }
}
