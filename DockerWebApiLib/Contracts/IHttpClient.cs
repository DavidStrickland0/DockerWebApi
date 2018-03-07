using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DockerWebApiLib.Contracts
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }
}
