﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dime
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DimeEntities : DbContext
    {
        public DimeEntities()
            : base("name=DimeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Igrac> Igraci { get; set; }
        public virtual DbSet<Klub> Klubovi { get; set; }
        public virtual DbSet<Korisnik> Korisnici { get; set; }
        public virtual DbSet<StatistikaIgraca> StatistikeIgraca { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TipTreninga> TipoviTreninga { get; set; }
        public virtual DbSet<TipUtakmice> TipoviUtakmica { get; set; }
        public virtual DbSet<Trening> Treninzi { get; set; }
        public virtual DbSet<UlogaKorisnika> UlogeKorisnika { get; set; }
        public virtual DbSet<Utakmica> Utakmice { get; set; }
        public virtual DbSet<Clanarina> Clanarine { get; set; }
        public virtual DbSet<ClanarinaIgraca> ClanarineIgraca { get; set; }
        public virtual DbSet<TreningPrisustvo> TreningPrisustva { get; set; }
    }
}
