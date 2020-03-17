using Omie.Api.Client.Models;
using Omie.Api.Client.Request.City;

namespace Omie.Api.Client.Abstractions {
    /// <remarks/>
    public interface ICityResource : IBaseResource<City, ApiGetManyResult, InsertResult> {
    }
}
