using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentDataDto {

        [JsonProperty("version")]
        public string Version { get; set; } = string.Empty;

        [JsonProperty("data")]
        public string Data { get; set; } = string.Empty;

        [JsonProperty("signature")]
        public string Signature { get; set; } = string.Empty;

        [JsonProperty("header")]
        public HeaderDto? Header { get; set; }

    }

}
