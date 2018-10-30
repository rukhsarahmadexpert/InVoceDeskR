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
    
    public partial class ProductTable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Nullable<double> SalePrice { get; set; }
        public Nullable<double> PurchasePrice { get; set; }
        public string Type { get; set; }
        public Nullable<int> OpeningQuantity { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> Company_ID { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<int> ProductUnit { get; set; }
    
          public string telephone { get; set; }
        public string Mobile { get; set; }
        public virtual ComapnyInfo ComapnyInfo { get; set; }
    }
}
