using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Helpers;
using Omie.Api.Client.Models;
using Omie.Api.Client.Request;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Omie.Api.Client.Resources {
    /// <summary>
    /// BaseResource
    /// </summary>
    /// <typeparam name="TModel">Resource model</typeparam>
    /// <typeparam name="TGetManyResult">GetMany request result</typeparam>
    /// <typeparam name="TInsertResult">Insert request result</typeparam>
    public abstract class BaseResource<TModel, TGetManyResult, TInsertResult> : IBaseResource<TModel, TGetManyResult, TInsertResult>
        where TModel : class, IRequestParameter
        where TInsertResult : class
        where TGetManyResult : ApiResult<TModel> {
        #region Fields

        private const int NUMBER_OF_RETRIES = 3;
        private const string OMIE_API_BASE_URL = "https://app.omie.com.br";

        private readonly IOmieApiClient _OmieApiClient;
        private readonly IAsyncPolicy _asyncPolicy;
        private readonly string _token;
        private readonly string _applicationId;

        #endregion

        #region Properties

        /// <summary>
        /// Resource name
        /// </summary>
        protected abstract string ResourceName { get; }

        /// <summary>
        /// Resource group name
        /// </summary>
        protected abstract string ResourceGroupName { get; }

        /// <summary>
        /// Get many action name
        /// </summary>
        protected abstract string GetManyActionName { get; }

        /// <summary>
        /// Insert action name
        /// </summary>
        protected abstract string InsertActionName { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Build resource with access token
        /// </summary>
        /// <param name="applicationId">Omie api application id</param>
        /// <param name="accessToken">Omie api access token</param>
        protected BaseResource(string accessToken, string applicationId)
            : this(accessToken, applicationId, OMIE_API_BASE_URL) { }

        /// <summary>
        /// Build resource with access token and baseurl
        /// </summary>
        /// <param name="accessToken">Omie api access token</param>
        /// <param name="applicationId">Omie api application id</param>
        /// <param name="baseUrl">Omie api base url</param>
        protected BaseResource(string accessToken, string applicationId, string baseUrl) {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken), "Token can't be null");

            if (string.IsNullOrWhiteSpace(applicationId))
                throw new ArgumentNullException(nameof(applicationId), "Application Id can't be null");

            _token = accessToken;
            _applicationId = applicationId;
            _OmieApiClient = RestService.For<IOmieApiClient>(baseUrl, new RefitSettings { HttpMessageHandlerFactory = () => new UriQueryUnescapingHandler() });

            _asyncPolicy = Policy
                .Handle<ApiException>(ex => ex.StatusCode != HttpStatusCode.NotFound && ex.StatusCode != HttpStatusCode.Forbidden)
                .RetryAsync(NUMBER_OF_RETRIES);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get model´s async
        /// </summary>
        /// <param name="limit">Limit request results</param>
        /// <param name="currentPage">Current request page</param>
        /// <returns>ApiResult - TModel</returns>
        public async Task<TGetManyResult> GetManyAsync(int limit = 50, int? currentPage = null) =>
            await RequestWithPolicy(GetModels(limit, currentPage)).ConfigureAwait(false);

        /// <summary>
        /// Insert one model into api
        /// </summary>
        /// <param name="modelToInsert">Model to insert</param>
        /// <returns></returns>
        public async Task<TInsertResult> InsertAsync(TModel modelToInsert) =>
            await RequestWithPolicy(InsertModel(modelToInsert)).ConfigureAwait(false);

        #endregion

        #region Protected Methods

        /// <summary>
        /// Get api function for models
        /// </summary>
        /// <param name="limit">Limit request results</param>
        /// <param name="currentPage">Current request page</param>
        /// <returns></returns>
        protected Func<Task<TGetManyResult>> GetModels(int limit = 50, int? currentPage = null) {
            var apiRequest = new ApiRequest() {
                Action = GetManyActionName,
                ApplicationId = _applicationId,
                Token = _token,
                Parameters = ParseRequestManyParameters(limit, currentPage)
            };

            return () => _OmieApiClient.PostAsync<TGetManyResult>(ResourceGroupName, ResourceName, apiRequest);
        }

        /// <summary>
        /// Insert api function for models
        /// </summary>
        /// <param name="modelToInsert">Model to insert on api</param>
        /// <returns></returns>
        protected Func<Task<TInsertResult>> InsertModel(TModel modelToInsert) {
            var apiRequest = new ApiRequest() {
                Action = InsertActionName,
                ApplicationId = _applicationId,
                Token = _token,
                Parameters = BuildInsertParameters(modelToInsert)
            };

            return ()=> _OmieApiClient.PostAsync<TInsertResult>(ResourceGroupName, ResourceName, apiRequest);
        }


        /// <summary>
        /// Do async request with policy
        /// </summary>
        /// <typeparam name="T">Request result</typeparam>
        /// <param name="func">Function to get async request</param>
        /// <returns>Request result</returns>
        protected async Task<T> RequestWithPolicy<T>(Func<Task<T>> func) =>
            await _asyncPolicy.ExecuteAsync(func).ConfigureAwait(false);

        /// <summary>
        /// Build a insert request parameters 
        /// </summary>
        /// <param name="modelToInsert"></param>
        /// <returns></returns>
        protected virtual IEnumerable<IRequestParameter> BuildInsertParameters(TModel modelToInsert) {
            yield return modelToInsert;
        }

        internal abstract IEnumerable<IRequestParameter> ParseRequestManyParameters(int limit, int? currentPage);

        #endregion
    }
}
