﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotoMy.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MOTOMYEntities : DbContext
    {
        public MOTOMYEntities()
            : base("name=MOTOMYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blob> Blobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Product_Header> Product_Header { get; set; }
        public DbSet<Product_Image> Product_Image { get; set; }
        public DbSet<Product_Type> Product_Type { get; set; }
        public DbSet<Stock_Status> Stock_Status { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Role> User_Role { get; set; }
    }
}