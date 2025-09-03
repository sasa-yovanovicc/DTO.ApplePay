using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class HeaderDto {

        [JsonProperty("ephemeralPublicKey")]
        public string EphemeralPublicKey { get; set; } = string.Empty;

        [JsonProperty("publicKeyHash")]
        public string PublicKeyHash { get; set; } = string.Empty;

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; } = string.Empty;

    }

}
