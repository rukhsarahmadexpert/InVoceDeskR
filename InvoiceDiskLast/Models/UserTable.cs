//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceDiskLast.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string UserFname { get; set; }
        public string Insertion { get; set; }
        public string UserLname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> RememberMe { get; set; }
        public Nullable<int> Gender { get; set; }
        public string DOB { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<int> UserAuthorityID { get; set; }
    }
}
