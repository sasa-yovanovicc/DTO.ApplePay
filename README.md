# DTO.ApplePay

A collection of Data Transformation Objects specifically designed for use with C# and Apple Pay, forked from [OpenPathInc/OpenPath.DTO.ApplePay](https://github.com/OpenPathInc/OpenPath.DTO.ApplePay).

## Overview

This library provides a complete set of DTOs for working with Apple Pay in C# applications. These DTOs facilitate serialization and deserialization of Apple Pay JSON objects and include helper DTOs for updating data in the Apple Pay payment pane.

## Improvements Over Original

This fork includes several significant improvements to the original codebase:

1. **Updated Language Features**
   - Upgraded to C# 8.0 language features
   - Added nullable reference type support

2. **Code Quality Enhancements**
   - Improved naming consistency across all DTOs
   - Added default values for non-nullable properties
   - Enabled treating warnings as errors for stricter code quality

3. **Validation**
   - Added data annotations for input validation
   - Implemented proper email, phone, and postal code validation

4. **Null Reference Protection**
   - All reference types properly marked as nullable where appropriate
   - Collection properties initialized with empty collections

5. **Security Updates**
   - Updated Newtonsoft.Json to version 13.0.3 (from 12.0.3) to address security vulnerabilities

## Usage Example

```csharp
// Create a payment method
var paymentMethod = new PaymentMethodDto
{
    DisplayName = "Visa ****1234",
    Network = "Visa",
    Type = PaymentMethodType.credit
};

// Create a contact
var contact = new ContactDto
{
    GivenName = "John",
    FamilyName = "Smith",
    AddressLines = new List<string> { "123 Main Street" },
    Locality = "New York",
    AdministrativeArea = "NY",
    PostalCode = "10001",
    Country = "United States",
    CountryCode = "US"
};

// Create a payment
var payment = new PaymentDto
{
    BillingContact = contact,
    ShippingContact = contact,
    Token = new TokenDto { TransactionIdentifier = "12345-ABCDE-67890" },
    PaymentData = "encrypted_payment_data_here"
};
```

## Original Resources

For a fully testable C# solution that utilizes these DTOs, check out the original [Apple Pay Example Project](https://github.com/OpenPathInc/Apple-Pay-Example-Project).

## Requirements

- .NET Standard 2.0 or higher
- C# 8.0 or higher for nullable reference types support
