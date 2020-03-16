using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Models;
using Omie.Api.Client.Request.Country;
using System;
using System.Collections.Generic;

namespace Omie.Api.Client.Resources {
    /// <remarks/>
    public sealed class CountryResource : BaseResource<Country, ApiGetManyResult, InsertResult>, ICountryResource {
        #region Properties

        /// <remarks/>
        protected override string ResourceName => "paises";

        /// <remarks/>
        protected override string ResourceGroupName => "geral";

        /// <remarks/>
        protected override string GetManyActionName => "ListarPaises";

        /// <remarks/>
        protected override string InsertActionName =>
            throw new NotImplementedException("Omie Api's does not allow insert country!");

        #endregion

        #region Constructors

        /// <remarks/>
        public CountryResource(string accessToken, string applicationId)
            : base(accessToken, applicationId) {
        }

        /// <remarks/>
        public CountryResource(string accessToken, string applicationId, string baseUrl)
            : base(accessToken, applicationId, baseUrl) {
        }

        #endregion

        #region Override Methods

        internal override IEnumerable<IRequestParameter> ParseRequestManyParameters(int limit, int? currentPage, Country modelFilter) {
            yield return new GetManyParameters() {
                Description = modelFilter.Description,
                Id = modelFilter.Id
            };
        }

        #endregion
    }
}
