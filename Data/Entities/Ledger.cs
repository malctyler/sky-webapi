using System;

namespace sky_webapi.Data.Entities
{
    public class Ledger
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceRef { get; set; }
        public decimal SubTotal { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        public bool Settled { get; set; }
    }
}
