using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentMethodDto {

        [JsonProperty("displayName")]
        [Required(ErrorMessage = "Display name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Display name must be between 1 and 50 characters")]
        public string DisplayName { get; set; } = string.Empty;

        [JsonProperty("network")]
        [Required(ErrorMessage = "Network is required")]
        public string Network { get; set; } = string.Empty;

        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.PaymentMethodType Type { get; set; } = Enumerator.PaymentMethodType.credit;

        [JsonProperty("paymentPass")]
        public PaymentPassDto? PaymentPass { get; set; }

    }

}
