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
    
    public partial class ComapnyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComapnyInfo()
        {
            this.ProductTables = new HashSet<ProductTable>();
            this.QutationTables = new HashSet<QutationTable>();
            this.PurchaseOrderTables = new HashSet<PurchaseOrderTable>();
            this.ContactsTables = new HashSet<ContactsTable>();
            this.OrderStatusTables = new HashSet<OrderStatusTable>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyCell { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyTRN { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyCountry { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public string UserName { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Website { get; set; }
        public string BankName { get; set; }
        public string IBANNumber { get; set; }
        public string BIC { get; set; }
        public string KVK { get; set; }
        public string BTW { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTable> ProductTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutationTable> QutationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderTable> PurchaseOrderTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactsTable> ContactsTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStatusTable> OrderStatusTables { get; set; }
    }
}
