using Newtonsoft.Json;
using System.Collections.Generic;

namespace Omie.Api.Client.Models {
    /// <summary>
    /// Omie api default response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ApiResult<T> where T : class {
        /// <remarks/>
        [JsonProperty("pagina")]
        public int Page { get; set; }

        /// <remarks/>
        [JsonProperty("total_de_paginas")]
        public int TotalPages { get; set; }

        /// <remarks/>
        [JsonProperty("registros")]
        public int Records { get; set; }

        /// <remarks/>
        [JsonProperty("total_de_registros")]
        public int TotalRecords { get; set; }

        /// <remarks/>
        public abstract IEnumerable<T> Results { get; set; }
    }
}
