using Omie.Api.Client.Models;
using Omie.Api.Client.Request;
using Omie.Api.Client.Request.Customer;

namespace Omie.Api.Client.Abstractions {
    /// <remarks/>
    public interface ICustomerResource : IBaseResource<Customer, ApiGetManyResult, InsertResult> {
    }
}
