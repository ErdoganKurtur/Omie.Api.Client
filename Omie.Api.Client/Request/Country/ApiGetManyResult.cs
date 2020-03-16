using Newtonsoft.Json;
using Omie.Api.Client.Models;
using System.Collections.Generic;
using CountryModel = Omie.Api.Client.Models.Country;

namespace Omie.Api.Client.Request.Country {
    /// <remarks/>
    public sealed class ApiGetManyResult : ApiResult<CountryModel> {
        /// <remarks/>
        [JsonProperty("lista_paises")]
        public override IEnumerable<CountryModel> Results { get; set; }
    }
}
