//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cabinet
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipIntervenie
    {
        public TipIntervenie()
        {
            this.Interventie = new HashSet<Interventie>();
            this.Pret = new HashSet<Pret>();
            this.Programare = new HashSet<Programare>();
        }
    
        public int TipInterventieID { get; set; }
        public string Denumire { get; set; }
    
        public virtual ICollection<Interventie> Interventie { get; set; }
        public virtual ICollection<Pret> Pret { get; set; }
        public virtual ICollection<Programare> Programare { get; set; }
    }
}
