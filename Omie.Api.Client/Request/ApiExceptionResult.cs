using Newtonsoft.Json;

namespace Omie.Api.Client.Request {
    /// <remarks/>
    public sealed class ApiExceptionResult {
        /// <remarks/>
        [JsonProperty("faultstring")]
        public string FaultString { get; set; }

        /// <remarks/>
        [JsonProperty("faultcode")]
        public string FaultCode { get; set; }
    }
}