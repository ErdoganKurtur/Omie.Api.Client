using System;

namespace Omie.Api.Client.Helpers {
    /// <summary>
    /// Omie Api Client options
    /// </summary>
    public sealed class OmieApiClientOptions {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="token">Omie api token</param>
        /// <param name="applicationId">Omie application id</param>
        public OmieApiClientOptions(string token, string applicationId) {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token), "Token can't be null!");

            if (string.IsNullOrWhiteSpace(applicationId))
                throw new ArgumentNullException(nameof(applicationId), "Application Id can't be null!");

            Token = token;
            ApplicationId = applicationId;
        }

        /// <summary>
        /// Omie api access token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Omie api application id
        /// </summary>
        public string ApplicationId { get; set; }
    }
}
