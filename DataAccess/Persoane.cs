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
    
    public partial class Persoane
    {
        public int PersoanaID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Firma { get; set; }
        public string Departament { get; set; }
        public string Cod { get; set; }
        public string Poza { get; set; }
        public Nullable<int> InventoryClientID { get; set; }
        public string Finger1 { get; set; }
        public string Finger2 { get; set; }
        public string NumeParinte1 { get; set; }
        public string PrenumeParinte1 { get; set; }
        public string TelefonParinte1 { get; set; }
        public string EmailParinte1 { get; set; }
        public string NumeParinte2 { get; set; }
        public string PrenumeParinte2 { get; set; }
        public string TelefonParinte2 { get; set; }
        public string EmailParinte2 { get; set; }
        public string Sex { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public string Motiv { get; set; }
        public Nullable<bool> NuAcceptaSoldNegativ { get; set; }
        public string Cod1 { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
