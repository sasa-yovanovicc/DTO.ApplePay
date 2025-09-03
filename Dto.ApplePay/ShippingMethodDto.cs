using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class ShippingMethodDto {

    [JsonProperty("label")]
    public string Label { get; set; } = string.Empty;

    [JsonProperty("detail")]
    public string Detail { get; set; } = string.Empty;

    [JsonProperty("amount")]
    public string Amount { get; set; } = string.Empty;

    [JsonProperty("identifier")]
    public string Identifier { get; set; } = string.Empty;

    }

}
