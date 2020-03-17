using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;
using System.Collections.Generic;

namespace Omie.Api.Client.Request {
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    internal sealed class ApiRequest {
        [JsonProperty("call")]
        public string Action { get; set; }

        [JsonProperty("app_key")]
        public string ApplicationId { get; set; }

        [JsonProperty("app_secret")]
        public string Token { get; set; }

        [JsonProperty("param")]
        public IEnumerable<IRequestParameter> Parameters { get; set; }
    }
}
