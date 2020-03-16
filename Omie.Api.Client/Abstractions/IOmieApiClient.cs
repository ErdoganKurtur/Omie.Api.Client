using Omie.Api.Client.Request;
using Refit;
using System.Threading.Tasks;

namespace Omie.Api.Client.Abstractions {
    /// <summary>
    /// Omie api client
    /// </summary>
    [Headers("accept: application/json","Content-Type: application/json")]
    internal interface IOmieApiClient {
        /// <summary>
        /// Do a request with POST method
        /// </summary>
        /// <typeparam name="T">Model result</typeparam>
        /// <param name="resourceGroupName">Api resource group name</param>
        /// /// <param name="modelName">Api resource name</param>
        /// <param name="requestParameter">Api request parameter</param>
        /// <returns></returns>
        [Post("/api/v1/{resourceGroupName}/{modelName}/")]
        
        Task<T> PostAsync<T>(
            [AliasAs("resourceGroupName")] string resourceGroupName,
            [AliasAs("modelName")] string modelName,
            [Body(BodySerializationMethod.Serialized)] ApiRequest requestParameter) where T : class;
    }
}
