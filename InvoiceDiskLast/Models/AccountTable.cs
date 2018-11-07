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
    
    public partial class AccountTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountTable()
        {
            this.AccountTransictionTables = new HashSet<AccountTransictionTable>();
        }
    
        public int? AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string AccountDescription { get; set; }
        public Nullable<int> FK_HeadAccountId { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> FK_CompanyId { get; set; }
    
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        public virtual HeadAccountTable HeadAccountTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountTransictionTable> AccountTransictionTables { get; set; }
    }
}
