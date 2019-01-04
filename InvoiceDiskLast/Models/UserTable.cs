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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTable()
        {
            this.QutationTables = new HashSet<QutationTable>();
            this.InvoiceTables = new HashSet<InvoiceTable>();
            this.InvoiceTables1 = new HashSet<InvoiceTable>();
            this.BillTables = new HashSet<BillTable>();
            this.BillTables1 = new HashSet<BillTable>();
        }
    
        public int UserId { get; set; }
        public string UserFname { get; set; }
        public string Insertion { get; set; }
        public string UserLname { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Gender { get; set; }
        public string DOB { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string Username { get; set; }
    
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutationTable> QutationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTable> InvoiceTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTable> InvoiceTables1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillTable> BillTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillTable> BillTables1 { get; set; }
    }
}
