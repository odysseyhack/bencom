﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BenChainClient.Api.DbEntities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class odysseyEntities : DbContext
    {
        public odysseyEntities()
            : base("name=odysseyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appendix> Appendix { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<Signatory> Signatory { get; set; }
        public virtual DbSet<Context> Context { get; set; }
    }
}
