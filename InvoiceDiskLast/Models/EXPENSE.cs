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
    
    public partial class EXPENSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXPENSE()
        {
            this.ExpenseDetails = new HashSet<ExpenseDetail>();
        }
    
        public int Id { get; set; }
        public string REFERENCEno { get; set; }
        public Nullable<int> ACCOUNT_ID { get; set; }
        public Nullable<int> VENDOR_ID { get; set; }
        public string notes { get; set; }
        public Nullable<decimal> SUBTOTAL { get; set; }
        public Nullable<decimal> VAT_AMOUNT { get; set; }
        public Nullable<decimal> GRAND_TOTAL { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> comapny_id { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<decimal> Vat6 { get; set; }
        public Nullable<decimal> Vat21 { get; set; }
    
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        public virtual ContactsTable ContactsTable { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseDetail> ExpenseDetails { get; set; }
    }
}
