﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YurtOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YurtOtomasyonEntities : DbContext
    {
        public YurtOtomasyonEntities()
            : base("name=YurtOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblOgrenci> tblOgrenci { get; set; }
        public virtual DbSet<tblPersonel> tblPersonel { get; set; }
        public virtual DbSet<tblRol> tblRol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblOda> tblOda { get; set; }
        public virtual DbSet<tblKullanici> tblKullanici { get; set; }
    }
}
