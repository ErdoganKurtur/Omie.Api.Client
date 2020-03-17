using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;

namespace Omie.Api.Client.Models {
    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class City : IRequestParameter {
        /// <remarks/>
        [JsonProperty("cCod")]
        public string Id { get; set; }

        /// <remarks/>
        [JsonProperty("cNome")]
        public string Name { get; set; }

        /// <remarks/>
        [JsonProperty("cUF")]
        public string UF { get; set; }

        /// <remarks/>
        [JsonProperty("nCodIBGE")]
        public string IbgeId { get; set; }

        /// <remarks/>
        [JsonProperty("nCodSIAFI")]
        public int SiafiID { get; set; }
    }
}
