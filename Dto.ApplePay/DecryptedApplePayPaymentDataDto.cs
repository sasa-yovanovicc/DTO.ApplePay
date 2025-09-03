using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay
{
    public class DecryptedApplePayPaymentDataDto
    {
        [JsonProperty("applicationPrimaryAccountNumber")]
        public string ApplicationPrimaryAccountNumber { get; set; } = string.Empty;

        [JsonProperty("applicationExpirationDate")]
        public string ApplicationExpirationDate { get; set; } = string.Empty;

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; } = string.Empty;

        [JsonProperty("transactionAmount")]
        public decimal TransactionAmount { get; set; }

        [JsonProperty("deviceManufacturerIdentifier")]
        public string DeviceManufacturerIdentifier { get; set; } = string.Empty;

        [JsonProperty("paymentDataType")]
        public string PaymentDataType { get; set; } = string.Empty;

        [JsonProperty("paymentData")]
        public PaymentDataDictionaryDto? PaymentData { get; set; }
    }
}
