//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teacher_recruitment_app.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHashAlgorithm { get; set; }
        public string Email { get; set; }
        public Nullable<long> Version { get; set; }
        public int InsId { get; set; }
        public System.DateTime InsDateTime { get; set; }
        public Nullable<int> UpdId { get; set; }
        public Nullable<System.DateTime> UpdDateTime { get; set; }
    
        public virtual UserRole UserRole { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
