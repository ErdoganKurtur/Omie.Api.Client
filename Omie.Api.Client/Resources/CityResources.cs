using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Models;
using Omie.Api.Client.Request.City;
using System;
using System.Collections.Generic;

namespace Omie.Api.Client.Resources {
    /// <remarks/>
    public sealed class CityResource : BaseResource<City, ApiGetManyResult, InsertResult>, ICityResource {
        #region Properties

        /// <remarks/>
        protected override string ResourceName => "cidades";

        /// <remarks/>
        protected override string ResourceGroupName => "geral";

        /// <remarks/>
        protected override string GetManyActionName => "PesquisarCidades";

        /// <remarks/>
        protected override string InsertActionName =>
            throw new NotImplementedException("Omie Api's does not allow insert city!");

        #endregion

        #region Constructors

        /// <remarks/>
        public CityResource(string accessToken, string applicationId)
            : base(accessToken, applicationId) {
        }

        /// <remarks/>
        public CityResource(string accessToken, string applicationId, string baseUrl)
            : base(accessToken, applicationId, baseUrl) {
        }

        #endregion

        #region Override Methods

        internal override IEnumerable<IRequestParameter> ParseRequestManyParameters(int limit, int? currentPage, City modelFilter) {
            yield return new GetManyParameters() {
                PageLimit = limit,
                OnlyApiRecords = "N",
                Page = currentPage ?? 1
            };
        }

        #endregion
    }
}
