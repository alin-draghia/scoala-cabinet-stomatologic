﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CabinetEntities : DbContext
    {
        public CabinetEntities()
            : base("name=CabinetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Medic> Medic { get; set; }
        public DbSet<Pacient> Pacient { get; set; }
        public DbSet<Pret> Pret { get; set; }
        public DbSet<TipIntervenie> TipIntervenie { get; set; }
        public DbSet<Programare> Programare { get; set; }
        public DbSet<Interventie> Interventie { get; set; }
    }
}