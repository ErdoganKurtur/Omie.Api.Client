using Omie.Api.Client.Models;
using System.Threading.Tasks;

namespace Omie.Api.Client.Abstractions {
    /// <summary>
    /// IBaseResource
    /// </summary>
    /// <typeparam name="TModel">Resource model</typeparam>
    /// <typeparam name="TGetManyResult">GetMany request result</typeparam>
    /// <typeparam name="TInsertResult">Insert request result</typeparam>
    public interface IBaseResource<TModel, TGetManyResult, TInsertResult>
        where TModel : class, IRequestParameter
        where TInsertResult : class
        where TGetManyResult : ApiResult<TModel> {
        /// <summary>
        /// Get model´s async
        /// </summary>
        /// <param name="limit">Limit request results</param>
        /// <param name="currentPage">Current request page</param>
        /// <returns>ApiResult - TModel</returns>
        Task<TGetManyResult> GetManyAsync(int limit = 50, int? currentPage = null);

        /// <summary>
        /// Insert one model into api
        /// </summary>
        /// <param name="modelToInsert">Model to insert</param>
        /// <returns>ApiResult - TInsertResult</returns>
        Task<TInsertResult> InsertAsync(TModel modelToInsert);
    }
}
