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
    
    public partial class Avize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avize()
        {
            this.AvizeDetails = new HashSet<AvizeDetail>();
        }
    
        public int AvizID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Numar { get; set; }
        public Nullable<int> GestiuneID { get; set; }
        public Nullable<float> Total { get; set; }
        public string DlgNume { get; set; }
        public string DlgBI { get; set; }
        public string DlgEliberat { get; set; }
        public string DlgMijTrans { get; set; }
        public string DlgNrAuto { get; set; }
        public string Observatii { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvizeDetail> AvizeDetails { get; set; }
    }
}
