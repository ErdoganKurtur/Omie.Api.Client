using Omie.Api.Client.Abstractions;
using Omie.Api.Client.Helpers;
using Omie.Api.Client.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omie.Api.Client {
    /// <summary>
    /// Omie client
    /// </summary>
    public sealed class OmieClient {
        #region Fields

        private static OmieApiClientOptions _clientOptions;

        private readonly Lazy<ICustomerResource> _customerResouce =
            new Lazy<ICustomerResource>(() => new CustomerResource(_clientOptions.Token, _clientOptions.ApplicationId));

        #endregion

        #region Properties

        /// <summary>
        /// Customers resources
        /// </summary>
        public ICustomerResource Customers => _customerResouce.Value;

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
