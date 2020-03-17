using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;

namespace Omie.Api.Client.Request.City {
    /// <remarks/>
    public sealed class GetManyParameters : IRequestParameter {
        /// <remarks/>
        [JsonProperty("pagina")]
        public int Page { get; set; }

        /// <remarks/>
        [JsonProperty("registros_por_pagina")]
        public int Limit { get; set; }

        /// <remarks/>
        [JsonProperty("apenas_importado_api")]
        public string OnlyApiRecords { get; set; }
    }
}
