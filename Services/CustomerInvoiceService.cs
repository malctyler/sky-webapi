using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using sky_webapi.Exceptions;

namespace sky_webapi.Services
{
    public interface ICustomerInvoiceService
    {
        Task<CustomerInvoiceDto> GetCustomerInvoiceDataAsync(int customerId, DateTime startDate, DateTime endDate);
    }

    public class CustomerInvoiceService : ICustomerInvoiceService
    {
        private readonly AppDbContext _context;

        public CustomerInvoiceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerInvoiceDto> GetCustomerInvoiceDataAsync(int customerId, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new BadRequestException("Start date must be before or equal to end date");
            }

            if ((endDate - startDate).TotalDays > 365)
            {
                throw new BadRequestException("Date range cannot exceed 1 year");
            }

            // Get customer details with null-safe navigation
            var customer = await _context.Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CustID == customerId);

            if (customer == null)
            {
                throw new NotFoundException($"Customer with ID {customerId} not found");
            }

            // Get inspections with related plant holdings for the date range
            var lineItems = await _context.Inspections
                .AsNoTracking()
                .Where(i => i.PlantHolding != null &&
                           i.PlantHolding.CustID == customerId &&
                           i.InspectionDate.HasValue &&
                           i.InspectionDate.Value >= startDate &&
                           i.InspectionDate.Value <= endDate)
                .Select(i => new InvoiceLineItemDto
                {
                    InspectionId = i.UniqueRef,
                    InspectionDate = i.InspectionDate!.Value,
                    Location = i.Location ?? "Unknown",
                    PlantDescription = i.PlantHolding!.Plant != null 
                        ? i.PlantHolding.Plant.PlantDescription ?? "Unknown Plant"
                        : "Unknown Plant",
                    SerialNumber = i.PlantHolding.SerialNumber ?? "N/A",
                    InspectionFee = i.PlantHolding.InspectionFee ?? 0m
                })
                .ToListAsync();

            var totalAmount = lineItems.Sum(item => item.InspectionFee);

            return new CustomerInvoiceDto
            {
                CustomerId = customerId,
                CustomerName = customer.CompanyName ?? "Unknown",
                Address = customer.Line1 ?? "",
                AddressLine2 = customer.Line2 ?? "",
                AddressLine3 = customer.Line3 ?? "",
                AddressLine4 = customer.Line4 ?? "",
                PostCode = customer.Postcode ?? "",
                StartDate = startDate,
                EndDate = endDate,
                LineItems = lineItems,
                TotalAmount = totalAmount
            };
        }
    }
}
