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
    
    public partial class ProductType
    {
        public ProductType()
        {
            this.ProductType1 = new HashSet<ProductType>();
            this.Products = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public int SortId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string DescriptionTemplate { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual ICollection<ProductType> ProductType1 { get; set; }
        public virtual ProductType ProductType2 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
