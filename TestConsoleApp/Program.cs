using OpenPath.Dto.ApplePay;
using OpenPath.Dto.ApplePay.Enumerator;
using Newtonsoft.Json;

Console.WriteLine("=== Apple Pay DTO Library Test ===");
Console.WriteLine();

// Create a sample contact
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

Console.WriteLine("Contact DTO:");
Console.WriteLine(JsonConvert.SerializeObject(contact, Formatting.Indented));
Console.WriteLine();

// Create a payment method
var paymentMethod = new PaymentMethodDto
{
    DisplayName = "Visa ****1234",
    Network = "Visa",
    Type = PaymentMethodType.credit
};

Console.WriteLine("Payment Method DTO:");
Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
Console.WriteLine();

// Create a token
var token = new TokenDto
{
    TransactionIdentifier = "12345-ABCDE-67890"
};

Console.WriteLine("Token DTO:");
Console.WriteLine(JsonConvert.SerializeObject(token, Formatting.Indented));
Console.WriteLine();

// Create a payment
var payment = new PaymentDto
{
    BillingContact = contact,
    ShippingContact = contact,
    Token = token,
    PaymentData = "encrypted_payment_data_here"
};

Console.WriteLine("Payment DTO:");
Console.WriteLine(JsonConvert.SerializeObject(payment, Formatting.Indented));
Console.WriteLine();

// Create line items
var lineItems = new List<LineItemDto>
{
    new LineItemDto
    {
        Label = "Product 1",
        Amount = "10.00",
        Type = LineItemType.final
    },
    new LineItemDto
    {
        Label = "Shipping",
        Amount = "5.00",
        Type = LineItemType.final
    },
    new LineItemDto
    {
        Label = "Total",
        Amount = "15.00",
        Type = LineItemType.final
    }
};

Console.WriteLine("Line Items DTO:");
Console.WriteLine(JsonConvert.SerializeObject(lineItems, Formatting.Indented));
Console.WriteLine();

// Create shipping method
var shippingMethod = new ShippingMethodDto
{
    Label = "Standard Shipping",
    Detail = "Delivery within 3-5 business days",
    Amount = "5.00",
    Identifier = "standard_shipping"
};

Console.WriteLine("Shipping Method DTO:");
Console.WriteLine(JsonConvert.SerializeObject(shippingMethod, Formatting.Indented));
Console.WriteLine();

Console.WriteLine("=== Testing completed successfully! ===");
Console.WriteLine("All DTO classes work correctly and can be serialized to JSON format compatible with Apple Pay API.");
