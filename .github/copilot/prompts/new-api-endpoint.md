# New API Endpoint Request Template

## Endpoint Overview
- **Endpoint Name**: [Provide the name of the endpoint, e.g., /api/customers/{id}/orders]
- **HTTP Method(s)**: [GET/POST/PUT/DELETE]
- **Purpose**: [Describe the main purpose of this endpoint]

## Data Structure Requirements

### Entity Definition
Please provide the following details for the new entity:
- Entity Name:
- Properties:
  - List each property with:
    - Name
    - Data Type
    - Required/Optional
    - Any constraints (e.g., max length, range)
- Relationships with other entities:
  - Specify any foreign keys
  - Define relationship types (One-to-One, One-to-Many, Many-to-Many)

### DTO Requirements
Base DTO properties needed:
- List all properties that should be exposed via the API
- Specify any data transformations needed
- Indicate if properties should be read-only or updatable

Additional DTOs needed (if applicable):
- Response DTOs with extended data
- Create/Update DTOs with different property sets
- List any related entity data that should be included (e.g., CustomerDetails for a CustomerId)

### Repository Layer
Specify required repository operations:
- Read operations (Get, GetAll, GetBy...)
- Write operations (Create, Update, Delete)
- Any specific query requirements
- Include parameters for filtering, sorting, or pagination if needed

### Service Layer
Define business logic requirements:
- Data validation rules
- Business rules and constraints
- Required transformations or calculations
- Integration with other services
- Error handling requirements

### Controller Requirements
Specify for each endpoint:
- Route pattern
- Required query parameters
- Required request body
- Expected response structure
- Authorization requirements
- Rate limiting needs (if any)

## Additional Considerations
- Caching requirements
- Authentication/Authorization needs
- Validation rules
- Error scenarios to handle
- Performance considerations
- Required database migrations
- Any UI integration requirements

## Example Request
```json
// Example of expected request body (if applicable)
{
    "property1": "value1",
    "property2": "value2"
}
```

## Example Response
```json
// Example of expected response
{
    "id": 1,
    "property1": "value1",
    "property2": "value2",
    "relatedData": {
        "id": 123,
        "additionalInfo": "value"
    }
}
```

## Special Instructions
- Note any specific naming conventions to follow
- Mention any existing patterns to maintain
- List any required tests
- Specify any documentation requirements

---
Note: Please fill in all relevant sections above to ensure a complete understanding of the endpoint requirements. The more detailed the information, the more accurate the implementation will be.
