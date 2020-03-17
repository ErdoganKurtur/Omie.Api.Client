using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Helpers;
using Omie.Api.Client.Resources;
using System;

namespace Omie.Api.Client {
    /// <summary>
    /// Omie client
    /// </summary>
    public sealed class OmieClient {
        #region Fields

        private static OmieApiClientOptions _clientOptions;

        private readonly Lazy<ICustomerResource> _customerResource =
            new Lazy<ICustomerResource>(() => new CustomerResource(_clientOptions.Token, _clientOptions.ApplicationId));

        private readonly Lazy<ICountryResource> _countryResource =
            new Lazy<ICountryResource>(() => new CountryResource(_clientOptions.Token, _clientOptions.ApplicationId));

        private readonly Lazy<ICityResource> _cityResource =
            new Lazy<ICityResource>(() => new CityResource(_clientOptions.Token, _clientOptions.ApplicationId));

        #endregion

        #region Properties

        /// <summary>
        /// Customers resources
        /// </summary>
        public ICustomerResource Customers => _customerResource.Value;

        /// <summary>
        /// Country resources
        /// </summary>
        public ICountryResource Countrys => _countryResource.Value;

        /// <summary>
        /// City resources
        /// </summary>
        public ICityResource Citys => _cityResource.Value;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="clientOptions">Api client options</param>
        public OmieClient(OmieApiClientOptions clientOptions) {
            if (string.IsNullOrWhiteSpace(clientOptions.Token))
                throw new ArgumentNullException(nameof(clientOptions.Token), "Token can't be null");

            _clientOptions = clientOptions;
        }

        #endregion
    }
}
