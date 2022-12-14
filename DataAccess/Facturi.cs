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
    
    public partial class Facturi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturi()
        {
            this.FacturaDetaliiPlatas = new HashSet<FacturaDetaliiPlata>();
            this.FacturiDetails = new HashSet<FacturiDetail>();
        }
    
        public int FacturaID { get; set; }
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
        public Nullable<int> OrderID { get; set; }
        public Nullable<float> ValFaraTVAV { get; set; }
        public Nullable<float> TVAV { get; set; }
        public Nullable<float> ValCuTVAV { get; set; }
        public Nullable<float> CursV { get; set; }
        public string ModalitatePlata { get; set; }
        public string Moneda { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetaliiPlata> FacturaDetaliiPlatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturiDetail> FacturiDetails { get; set; }
    }
}
