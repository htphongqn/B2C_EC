//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductImages = new HashSet<ProductImage>();
            this.ProductPriceHistories = new HashSet<ProductPriceHistory>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsBestSelling { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
        public Nullable<bool> IsPromo { get; set; }
        public Nullable<int> ProductType_ID { get; set; }
        public Nullable<int> Manufacuturer_ID { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductPriceHistory> ProductPriceHistories { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
