using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay {

    public class MerchantSessionRequestDto {

        [JsonProperty("merchantIdentifier")]
        public string MerchantIdentifier { get; set; } = string.Empty;

        [JsonProperty("domainName")]
        public string DomainName { get; set; } = string.Empty;

        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = string.Empty;

    }

}
