﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class swishDBContext : DbContext
    {
        public swishDBContext()
            : base("name=swishDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<S_Avatar> S_Avatar { get; set; }
        public virtual DbSet<S_ConditionPrices> S_ConditionPrices { get; set; }
        public virtual DbSet<S_DailySentence> S_DailySentence { get; set; }
        public virtual DbSet<S_ItemPrice> S_ItemPrice { get; set; }
        public virtual DbSet<S_ItemWorth> S_ItemWorth { get; set; }
        public virtual DbSet<S_User> S_User { get; set; }
    }
}
