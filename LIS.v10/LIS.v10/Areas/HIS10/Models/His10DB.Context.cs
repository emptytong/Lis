﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.v10.Areas.HIS10.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class His10DBContainer : DbContext
    {
        public His10DBContainer()
            : base("name=His10DBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HisEntity> HisEntities { get; set; }
        public virtual DbSet<HisProfile> HisProfiles { get; set; }
        public virtual DbSet<HisCategory> HisCategories { get; set; }
        public virtual DbSet<HisEntCat> HisEntCats { get; set; }
        public virtual DbSet<HisOrder> HisOrders { get; set; }
        public virtual DbSet<HisOrderType> HisOrderTypes { get; set; }
        public virtual DbSet<HisPhysician> HisPhysicians { get; set; }
        public virtual DbSet<HisEntPhysician> HisEntPhysicians { get; set; }
        public virtual DbSet<HisInstrument> HisInstruments { get; set; }
        public virtual DbSet<HisResultField> HisResultFields { get; set; }
        public virtual DbSet<HisResult> HisResults { get; set; }
        public virtual DbSet<HisResultRange> HisResultRanges { get; set; }
        public virtual DbSet<HisOrderRemarks> HisOrderRemarks { get; set; }
        public virtual DbSet<HisProfileDetails> HisProfileDetails { get; set; }
    }
}