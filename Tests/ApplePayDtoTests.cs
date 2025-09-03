using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenPath.Dto.ApplePay;
using OpenPath.Dto.ApplePay.Enumerator;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dto.ApplePay.Tests
{
    [TestClass]
    public class ApplePayDtoTests
    {
        [TestMethod]
        public void ContactDto_Serialization_Test()
        {
            // Arrange
            var contact = new ContactDto
            {
                GivenName = "Petar",
                FamilyName = "Petrović",
                AddressLines = new List<string> { "Terazije 5" },
                Locality = "Beograd",
                CountryCode = "RS"
            };

            // Act
            var json = JsonConvert.SerializeObject(contact);
            var deserializedContact = JsonConvert.DeserializeObject<ContactDto>(json);

            // Assert
            Assert.IsNotNull(deserializedContact);
            Assert.AreEqual(contact.GivenName, deserializedContact.GivenName);
            Assert.AreEqual(contact.FamilyName, deserializedContact.FamilyName);
            Assert.AreEqual(contact.CountryCode, deserializedContact.CountryCode);
        }

        [TestMethod]
        public void PaymentMethodDto_EnumSerialization_Test()
        {
            // Arrange
            var paymentMethod = new PaymentMethodDto
            {
                DisplayName = "Test Card",
                Network = "Visa",
                Type = PaymentMethodType.credit
            };

            // Act
            var json = JsonConvert.SerializeObject(paymentMethod);

            // Assert
            Assert.IsTrue(json.Contains("\"type\":\"credit\""));
        }

        [TestMethod]
        public void LineItemDto_EnumSerialization_Test()
        {
            // Arrange
            var lineItem = new LineItemDto
            {
                Label = "Test Item",
                Amount = "10.00",
                Type = LineItemType.final
            };

            // Act
            var json = JsonConvert.SerializeObject(lineItem);

            // Assert
            Assert.IsTrue(json.Contains("\"type\":\"final\""));
        }

        [TestMethod]
        public void PaymentDto_ComplexSerialization_Test()
        {
            // Arrange
            var payment = new PaymentDto
            {
                BillingContact = new ContactDto
                {
                    GivenName = "Ana",
                    FamilyName = "Marić",
                    CountryCode = "RS"
                },
                Token = new TokenDto
                {
                    TransactionIdentifier = "TEST-12345"
                },
                PaymentData = "encrypted_data"
            };

            // Act
            var json = JsonConvert.SerializeObject(payment);
            var deserializedPayment = JsonConvert.DeserializeObject<PaymentDto>(json);

            // Assert
            Assert.IsNotNull(deserializedPayment);
            Assert.IsNotNull(deserializedPayment.BillingContact);
            Assert.AreEqual("Ana", deserializedPayment.BillingContact.GivenName);
            Assert.AreEqual("TEST-12345", deserializedPayment.Token.TransactionIdentifier);
        }
    }
}
