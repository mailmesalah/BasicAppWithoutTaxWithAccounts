﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database9005Entities : DbContext
    {
        public Database9005Entities()
            : base("name=Database9005Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<barcode_generator> barcode_generator { get; set; }
        public virtual DbSet<ledger_register> ledger_register { get; set; }
        public virtual DbSet<ledger_transactions> ledger_transactions { get; set; }
        public virtual DbSet<product_register> product_register { get; set; }
        public virtual DbSet<unit_register> unit_register { get; set; }
        public virtual DbSet<product_transactions> product_transactions { get; set; }
        public virtual DbSet<bill_nos> bill_nos { get; set; }
        public virtual DbSet<bank_deposits> bank_deposits { get; set; }
        public virtual DbSet<bank_withdrawals> bank_withdrawals { get; set; }
        public virtual DbSet<cash_payments> cash_payments { get; set; }
        public virtual DbSet<cash_receipts> cash_receipts { get; set; }
        public virtual DbSet<journal_vouchers> journal_vouchers { get; set; }
        public virtual DbSet<opening_balances> opening_balances { get; set; }
    }
}