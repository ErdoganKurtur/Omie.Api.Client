using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Models;
using Omie.Api.Client.Request;
using Omie.Api.Client.Request.Customer;
using Omie.Api.Client.Request.CustomerParameters;
using System.Collections.Generic;

namespace Omie.Api.Client.Resources {
    /// <remarks/>
    public sealed class CustomerResource : BaseResource<Customer, ApiGetManyResult, InsertResult>, ICustomerResource {
        #region Properties

        /// <remarks/>
        protected override string ResourceName => "clientes";

        /// <remarks/>
        protected override string ResourceGroupName => "geral";

        /// <remarks/>
        protected override string GetManyActionName => "ListarClientes";

        /// <remarks/>
        protected override string InsertActionName => "IncluirCliente";

        #endregion

        #region Constructors

        /// <remarks/>
        public CustomerResource(string accessToken, string applicationId)
            : base(accessToken, applicationId) { }

        /// <remarks/>
        public CustomerResource(string accessToken, string applicationId, string baseUrl)
            : base(accessToken, applicationId, baseUrl) { }

        #endregion

        #region Override Methods

        internal override IEnumerable<IRequestParameter> ParseRequestManyParameters(int limit, int? currentPage, Customer modelFilter) {
            yield return new GetManyParameters() {
                Limit = limit,
                OnlyApiRecords = "N",
                Page = currentPage ?? 1,
                Filter = modelFilter
            };
        }

        #endregion
    }
}
