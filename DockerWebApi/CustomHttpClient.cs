using DockerWebApiLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DockerWebApi
{
    public class CustomHttpClient : IHttpClient
    {
        private HttpClient httpClient = new HttpClient();
        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return httpClient.GetAsync(requestUri);
        }
    }
}
