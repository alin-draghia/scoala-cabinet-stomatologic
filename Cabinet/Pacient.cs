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
    
    public partial class Pacient
    {
        public Pacient()
        {
            this.Interventie = new HashSet<Interventie>();
            this.Programare = new HashSet<Programare>();
        }
    
        public int PacientID { get; set; }
        public int MedicID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public bool Sters { get; set; }
    
        public virtual ICollection<Interventie> Interventie { get; set; }
        public virtual Medic Medic { get; set; }
        public virtual ICollection<Programare> Programare { get; set; }
    }
}
