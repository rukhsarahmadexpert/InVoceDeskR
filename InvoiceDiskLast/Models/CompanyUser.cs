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
    
    public partial class CompanyUser
    {
        public int id { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> Authority { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}