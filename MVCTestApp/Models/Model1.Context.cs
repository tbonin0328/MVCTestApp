﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTestApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CommunityAssistEntities1 : DbContext
    {
        public CommunityAssistEntities1()
            : base("name=CommunityAssistEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BusinessRule> BusinessRules { get; set; }
        public DbSet<CommunityService> CommunityServices { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
        public DbSet<GrantReview> GrantReviews { get; set; }
        public DbSet<Jobtitle> Jobtitles { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<PersonContact> PersonContacts { get; set; }
        public DbSet<ServiceGrant> ServiceGrants { get; set; }
    }
}
