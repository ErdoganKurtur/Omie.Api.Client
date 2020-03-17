using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;

namespace Omie.Api.Client.Request.Country {
    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class GetManyParameters : IRequestParameter {
        /// <remarks/>
        [JsonProperty("filtrar_por_codigo")]
        public string Id { get; set; }

        /// <remarks/>
        [JsonProperty("filtrar_por_descricao")]
        public string Description { get; set; }
    }
}
