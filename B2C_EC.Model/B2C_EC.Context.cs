﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2C_EC.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    //using System.Data.Objects;
    //using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class B2C_ECEntities : DbContext
    {
        public B2C_ECEntities()
            : base("name=B2C_ECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatu> OrderStatus { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Promo> Promoes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    
        public virtual ObjectResult<SortRow_Result> SortRow(string tableName, string columnName, string sortName, Nullable<int> rowId, Nullable<int> direction)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnNameParameter = columnName != null ?
                new ObjectParameter("ColumnName", columnName) :
                new ObjectParameter("ColumnName", typeof(string));
    
            var sortNameParameter = sortName != null ?
                new ObjectParameter("SortName", sortName) :
                new ObjectParameter("SortName", typeof(string));
    
            var rowIdParameter = rowId.HasValue ?
                new ObjectParameter("RowId", rowId) :
                new ObjectParameter("RowId", typeof(int));
    
            var directionParameter = direction.HasValue ?
                new ObjectParameter("Direction", direction) :
                new ObjectParameter("Direction", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SortRow_Result>("SortRow", tableNameParameter, columnNameParameter, sortNameParameter, rowIdParameter, directionParameter);
        }
    }
}
