using Newtonsoft.Json;
using Omie.Api.Client.Models;
using System.Collections.Generic;
using CustomerModel = Omie.Api.Client.Models.Customer;

namespace Omie.Api.Client.Request {
    /// <remarks/>
    public sealed class ApiGetManyResult : ApiResult<CustomerModel> {
        /// <remarks/>
        [JsonProperty("clientes_cadastro")]
        public override IEnumerable<CustomerModel> Results { get; set; }
    }
}
