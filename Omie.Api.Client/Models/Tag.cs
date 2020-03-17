using Newtonsoft.Json;

namespace Omie.Api.Client.Models {
    /// <remarks/>
    public sealed class Tag {
        /// <remarks/>
        [JsonProperty("tag")]
        public string Name { get; set; }
    }
}
