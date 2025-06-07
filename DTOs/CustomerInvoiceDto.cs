using System;
using System.Collections.Generic;

namespace sky_webapi.DTOs
{
    public class CustomerInvoiceDto
    {
        public int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public required string Address { get; set; }
        public required string AddressLine2 { get; set; }
        public required string AddressLine3 { get; set; }
        public required string AddressLine4 { get; set; }
        public required string PostCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<InvoiceLineItemDto> LineItems { get; set; } = new List<InvoiceLineItemDto>();
        public decimal TotalAmount { get; set; }
    }

    public class InvoiceLineItemDto
    {
        public int InspectionId { get; set; }
        public DateTime InspectionDate { get; set; }
        public required string Location { get; set; }
        public required string PlantDescription { get; set; }
        public required string SerialNumber { get; set; }
        public decimal InspectionFee { get; set; }
    }
}
