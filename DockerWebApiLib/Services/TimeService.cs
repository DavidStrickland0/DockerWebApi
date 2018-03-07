using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DockerWebApiLib.Contracts;
using DockerWebApiLib.Models;
using Newtonsoft.Json;


namespace DockerWebApiLib.Services
{
    public class TimeService
    {
        private IHttpClient _httpClient;
        public TimeService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TimeResult> GetTime()
        {
            try
            {
                var result = await _httpClient.GetAsync("http://worldclockapi.com/api/json/mst/now");
                return JsonConvert.DeserializeObject<TimeResult>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
