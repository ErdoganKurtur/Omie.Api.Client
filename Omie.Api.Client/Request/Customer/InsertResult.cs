using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omie.Api.Client.Request.Customer {
    /// <remarks/>
    public sealed class InsertResult {
        /// <remarks/>
        [JsonProperty("codigo_cliente_omie")]
        public int CustomerId { get; set; }

        /// <remarks/>
        [JsonProperty("codigo_cliente_integracao")]
        public string IntegrationId { get; set; }

        /// <remarks/>
        [JsonProperty("codigo_status")]
        public string StatusCode { get; set; }

        /// <remarks/>
        [JsonProperty("descricao_status")]
        public string DescriptionStatus { get; set; }
    }
}
