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
    
    public partial class AccountTransictionTable
    {
        public int TransictionId { get; set; }
        public Nullable<System.DateTime> TransictionDate { get; set; }
        public Nullable<int> FK_AccountID { get; set; }
        public Nullable<double> Dr { get; set; }
        public Nullable<double> Cr { get; set; }
        public string TransictionNumber { get; set; }
        public string TransictionRefrenceId { get; set; }
        public string TransictionType { get; set; }
        public Nullable<System.TimeSpan> CreationTime { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> FK_CompanyId { get; set; }
        public Nullable<int> FKPaymentTerm { get; set; }
        public string Description { get; set; }
    
        public virtual PaymentTermTable PaymentTermTable { get; set; }
        public virtual ComapnyInfo ComapnyInfo { get; set; }
        public virtual AccountTable AccountTable { get; set; }
    }
}
