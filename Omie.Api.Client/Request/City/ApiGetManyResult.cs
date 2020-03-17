using Newtonsoft.Json;
using Omie.Api.Client.Models;
using System.Collections.Generic;
using CityModel = Omie.Api.Client.Models.City;

namespace Omie.Api.Client.Request.City {
    ///<remarks/>
    public sealed class ApiGetManyResult : ApiResult<CityModel> {
        /// <remarks/>
        [JsonProperty("lista_cidades")]
        public override IEnumerable<CityModel> Results { get; set; }
    }
}
