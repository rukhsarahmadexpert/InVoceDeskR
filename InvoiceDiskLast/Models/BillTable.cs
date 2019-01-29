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
    
    public partial class BillTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillTable()
        {
            this.BillDetailTables = new HashSet<BillDetailTable>();
        }
    
        public int BilID { get; set; }
        public string Bill_ID { get; set; }
        public string RefNumber { get; set; }
        public Nullable<int> PurchaseId { get; set; }
        public System.DateTime BillDate { get; set; }
        public System.DateTime BillDueDate { get; set; }
        public Nullable<double> SubTotal { get; set; }
        public Nullable<double> TotalVat6 { get; set; }
        public Nullable<double> TotalVat21 { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public string CustomerNote { get; set; }
        public string Status { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> VenderId { get; set; }
        public string Type { get; set; }
    
        public virtual UserTable UserTable { get; set; }
        public virtual UserTable UserTable1 { get; set; }
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        public virtual ContactsTable ContactsTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetailTable> BillDetailTables { get; set; }
    }
}
