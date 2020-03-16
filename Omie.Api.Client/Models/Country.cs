using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;

namespace Omie.Api.Client.Models {
    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Country : IRequestParameter {
        /// <remarks/>
        [JsonProperty("cCodigo")]
        public string Id { get; set; }

        /// <remarks/>
        [JsonProperty("cDescricao")]
        public string Description { get; set; }
    }
}
