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
    
    public partial class NewsLetter:DomainObject<NewsLetter>
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
