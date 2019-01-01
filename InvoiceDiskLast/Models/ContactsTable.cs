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
    
    public partial class ContactsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactsTable()
        {
            this.QutationTables = new HashSet<QutationTable>();
            this.InvoiceTables = new HashSet<InvoiceTable>();
        }
    
        public int ContactsId { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public Nullable<int> Company_Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Type { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string LandLine { get; set; }
        public string telephone { get; set; }
        public string Mobile { get; set; }
        public string BillingEmail { get; set; }
        public string Website { get; set; }
        public Nullable<System.DateTime> Addeddate { get; set; }
        public Nullable<bool> Status { get; set; }
        public string PersonCompany { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> PaymentTerm { get; set; }
    
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutationTable> QutationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTable> InvoiceTables { get; set; }
    }
}
