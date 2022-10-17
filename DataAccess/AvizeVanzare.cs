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
    
    public partial class AvizeVanzare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AvizeVanzare()
        {
            this.AvizeVanzareDetails = new HashSet<AvizeVanzareDetail>();
        }
    
        public int AvizVID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Serie { get; set; }
        public Nullable<int> Numar { get; set; }
        public Nullable<float> ValFaraTVA { get; set; }
        public Nullable<float> TVA { get; set; }
        public Nullable<float> ValCuTVA { get; set; }
        public string IntocmitDe { get; set; }
        public string CNP { get; set; }
        public Nullable<System.DateTime> DataEmiterii { get; set; }
        public Nullable<int> TermenDePlata { get; set; }
        public string DlgNume { get; set; }
        public string DlgBI { get; set; }
        public string DlgEliberat { get; set; }
        public string DlgMijTrans { get; set; }
        public string DlgNrAuto { get; set; }
        public string Observatii { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvizeVanzareDetail> AvizeVanzareDetails { get; set; }
    }
}
