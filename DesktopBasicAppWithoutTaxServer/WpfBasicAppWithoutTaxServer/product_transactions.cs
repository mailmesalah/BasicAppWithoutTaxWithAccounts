//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfServerApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_transactions
    {
        public int id { get; set; }
        public string bill_no { get; set; }
        public System.DateTime bill_date_time { get; set; }
        public string bill_type { get; set; }
        public string supplier_code { get; set; }
        public string supplier { get; set; }
        public string supplier_address { get; set; }
        public string customer_code { get; set; }
        public string customer { get; set; }
        public string customer_address { get; set; }
        public string narration { get; set; }
        public Nullable<int> serial_no { get; set; }
        public string product_code { get; set; }
        public string product { get; set; }
        public Nullable<decimal> purchase_rate { get; set; }
        public Nullable<decimal> sales_rate { get; set; }
        public Nullable<decimal> mrp { get; set; }
        public string purchase_unit_code { get; set; }
        public string sales_unit_code { get; set; }
        public Nullable<decimal> purchase_unit_value { get; set; }
        public Nullable<decimal> sales_unit_value { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public string group_code { get; set; }
        public string barcode { get; set; }
        public Nullable<decimal> extra_charges { get; set; }
        public Nullable<decimal> discounts { get; set; }
        public Nullable<decimal> advance { get; set; }
        public string ref_bill_no { get; set; }
        public Nullable<System.DateTime> ref_bill_date_time { get; set; }
        public string financial_code { get; set; }
        public string sales_unit { get; set; }
        public string purchase_unit { get; set; }
        public string unit_code { get; set; }
        public decimal unit_value { get; set; }
        public Nullable<decimal> product_discount { get; set; }
        public decimal interstate_rate { get; set; }
        public decimal wholesale_rate { get; set; }
    }
}
