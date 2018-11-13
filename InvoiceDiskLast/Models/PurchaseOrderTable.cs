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
    
    public partial class PurchaseOrderTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrderTable()
        {
            this.PurchaseOrderDetailsTables = new HashSet<PurchaseOrderDetailsTable>();
            this.OrderStatusTables = new HashSet<OrderStatusTable>();
        }
    
        public int PurchaseOrderID { get; set; }
        public string PurchaseID { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.DateTime> PurchaseDueDate { get; set; }
        public string PurchaseRefNumber { get; set; }
        public Nullable<double> PurchaseSubTotal { get; set; }
        public Nullable<double> PurchaseDiscountPercenteage { get; set; }
        public Nullable<double> PurchaseDiscountAmount { get; set; }
        public Nullable<double> PurchaseVatPercentage { get; set; }
        public Nullable<double> PurchaseTotoalAmount { get; set; }
        public string PurchaseVenderNote { get; set; }
        public string Status { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<double> Vat6 { get; set; }
        public Nullable<double> Vat21 { get; set; }
        public Nullable<int> VenderId { get; set; }
        public string Type { get; set; }
    
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetailsTable> PurchaseOrderDetailsTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStatusTable> OrderStatusTables { get; set; }
    }
}
