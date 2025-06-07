# Customer Invoice API Endpoint

## Endpoint Overview
- **Endpoint Name**: `/api/customers/{customerId}/invoices`
- **HTTP Method(s)**: GET
- **Purpose**: Generate invoice data for a customer based on inspections performed within a specified date range, including customer details and itemized inspection fees.

## Data Structure Requirements

### Entity Definition
No new entity required - will use existing entities:
- Customer
- Inspection
- PlantHolding
- Plant (for plant description)

### DTO Requirements

#### CustomerInvoiceDto (Response DTO)
```csharp
public class CustomerInvoiceDto
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<InvoiceLineItemDto> LineItems { get; set; }
    public decimal TotalAmount { get; set; }
}
```

#### InvoiceLineItemDto
```csharp
public class InvoiceLineItemDto
{
    public int InspectionId { get; set; }
    public DateTime InspectionDate { get; set; }
    public string Location { get; set; }
    public string PlantDescription { get; set; }
    public string SerialNumber { get; set; }
    public decimal InspectionFee { get; set; }
}
```

### Repository Layer
Use existing repositories:
- CustomerRepository
- InspectionRepository
- PlantHoldingRepository

New repository method needed:
- GetCustomerInspectionsForDateRange(int customerId, DateTime startDate, DateTime endDate)

### Service Layer
New service: `CustomerInvoiceService`

Methods:
- `GetCustomerInvoiceData(int customerId, DateTime startDate, DateTime endDate)`

Business Logic:
1. Validate customer exists
2. Validate date range
3. Retrieve customer details
4. Get all inspections for the customer within date range
5. For each inspection:
   - Get associated plant holding details
   - Get plant description
   - Calculate line item details
6. Calculate total amount
7. Compile all data into invoice DTO

### Controller Requirements
New Controller: `CustomerInvoiceController`

Endpoint Details:
- Route: `GET /api/customers/{customerId}/invoices`
- Query Parameters:
  - startDate (DateTime, required)
  - endDate (DateTime, required)
- Authorization: Requires authenticated user
- Response: CustomerInvoiceDto

Error Handling:
- 404 if customer not found
- 400 for invalid date range
- 401 for unauthorized access
- 500 for internal server errors

## Additional Considerations
- Caching: Consider caching customer details and plant descriptions
- Authentication: Required
- Authorization: User must have permission to view customer data
- Validation rules:
  - Start date must be before or equal to end date
  - Date range should not exceed 1 year
  - Customer must exist
- Performance considerations:
  - Include appropriate indexes on Inspection.InspectionDate
  - Consider pagination if large number of inspections
  - Optimize joins between tables

## Example Request
```
GET /api/customers/123/invoices?startDate=2025-01-01&endDate=2025-06-30
```

## Example Response
```json
{
    "customerId": 123,
    "customerName": "ABC Company",
    "address": "123 Main Street",
    "city": "London",
    "postCode": "SW1A 1AA",
    "startDate": "2025-01-01T00:00:00",
    "endDate": "2025-06-30T23:59:59",
    "lineItems": [
        {
            "inspectionId": 456,
            "inspectionDate": "2025-03-15T10:30:00",
            "location": "Main Warehouse",
            "plantDescription": "Forklift Model XYZ",
            "serialNumber": "FL123456",
            "inspectionFee": 150.00
        }
    ],
    "totalAmount": 150.00
}
```

## Special Instructions
- Follow existing naming conventions for DTOs and controllers
- Add appropriate XML documentation for API endpoints
- Include unit tests for service layer calculations
- Add integration tests for the entire endpoint
- Update API documentation with new endpoint details
- Consider adding export functionality for PDF/Excel in future iterations
