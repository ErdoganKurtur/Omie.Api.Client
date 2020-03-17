using Omie.Api.Client.Models;
using Omie.Api.Client.Request.Country;

namespace Omie.Api.Client.Abstractions {
    /// <remarks/>
    public interface ICountryResource : IBaseResource<Country, ApiGetManyResult, InsertResult> {
    }
}
