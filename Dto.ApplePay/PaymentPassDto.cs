using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentPassDto {

        [JsonProperty("primaryAccountIdentifier")]
        public string PrimaryAccountIdentifier { get; set; } = string.Empty;

        [JsonProperty("primaryAccountNumberSuffix")]
        public string PrimaryAccountSuffix { get; set; } = string.Empty;

        [JsonProperty("deviceAccountIdentifier")]
        public string DeviceAccountIdentifier {  get; set; } = string.Empty;

        [JsonProperty("deviceAccountNumberSuffix")]
        public string DeviceAccountNumberSuffix { get; set; } = string.Empty;

        [JsonProperty("activationState"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.PaymentPassActivationState ActivationState { get; set; }

    }

}
