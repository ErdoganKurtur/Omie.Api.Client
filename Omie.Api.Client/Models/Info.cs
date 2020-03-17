using Newtonsoft.Json;

namespace Omie.Api.Client.Models {
    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Info {
        /// <remarks/>
        [JsonProperty("cImpAPI")]
        public string ApiImport { get; set; }

        /// <remarks/>
        [JsonProperty("dAlt")]
        public string UpdatedAt { get; set; }

        /// <remarks/>
        [JsonProperty("dInc")]
        public string CreatedAt { get; set; }

        /// <remarks/>
        [JsonProperty("hAlt")]
        public string UpdatedAtTime { get; set; }

        /// <remarks/>
        [JsonProperty("hInc")]
        public string CreatedAtTime { get; set; }

        /// <remarks/>
        [JsonProperty("uAlt")]
        public string UpdatedBy { get; set; }

        /// <remarks/>
        [JsonProperty("uInc")]
        public string CreatedBy { get; set; }
    }
}
