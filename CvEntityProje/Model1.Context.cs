﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntityEntities : DbContext
    {
        public DbCvEntityEntities()
            : base("name=DbCvEntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Adres> Tbl_Adres { get; set; }
        public virtual DbSet<Tbl_Calismalar> Tbl_Calismalar { get; set; }
        public virtual DbSet<Tbl_Hakkimda> Tbl_Hakkimda { get; set; }
        public virtual DbSet<Tbl_Iletisim> Tbl_Iletisim { get; set; }
        public virtual DbSet<Tbl_Yetenekler> Tbl_Yetenekler { get; set; }
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
    }
}
