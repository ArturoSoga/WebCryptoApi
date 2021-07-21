using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Crypto_WebApi.Attributes
{
    public class KeyAttribute : DelegatingHandler
    {
        private const string ApiKey = "4asd9862g4r87456geswea";
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage HttpMessage,CancellationToken CancelationToken)
        {
            bool IsValidKey = false;

            IEnumerable<string> requestHeaders;
            var IsApikeyExist = HttpMessage.Headers.TryGetValues("ApiKey", out requestHeaders);

            if (IsApikeyExist)
            {
                if (requestHeaders.FirstOrDefault().Equals(ApiKey))
                {
                    IsValidKey = true;
                }
            }

            if (!IsValidKey)
            {
                return HttpMessage.CreateResponse(HttpStatusCode.Forbidden, "ApiKey invalid");
            }

            return await base.SendAsync(HttpMessage, CancelationToken);
        }
    }
}