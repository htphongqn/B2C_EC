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
    
    public partial class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> Address_ID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public string Key { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
    
        public virtual Address Address { get; set; }
    }
}
