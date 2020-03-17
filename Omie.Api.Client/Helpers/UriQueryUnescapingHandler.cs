using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Omie.Api.Client.Helpers {
    internal class UriQueryUnescapingHandler : DelegatingHandler {
        public UriQueryUnescapingHandler()
            : base(new HttpClientHandler()) { }

        public UriQueryUnescapingHandler(HttpMessageHandler innerHandler)
            : base(innerHandler) { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            var uri = request.RequestUri;
            var unescapedString = HttpUtility.UrlDecode(uri.OriginalString);

            request.RequestUri = new Uri(unescapedString);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
